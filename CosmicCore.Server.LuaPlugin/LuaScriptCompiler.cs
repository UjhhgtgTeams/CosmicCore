using System.Diagnostics;
using System.Formats.Tar;
using System.IO.Compression;
using System.Runtime.InteropServices;
using CosmicCore.Server.Utilities;
using CosmicCore.Server.Utilities.External;
using Downloader;
using Nito.AsyncEx;
using Serilog;
using Spectre.Console;

namespace CosmicCore.Server.LuaPlugin;

public class LuaScriptCompiler : Singleton<LuaScriptCompiler>, IExternalTool
{
    private static readonly string LuaCompilerDirPath = Path.Combine("ExternalTool", "LuaCompiler");

    private static readonly DownloadConfiguration DownloadConf = new()
    {
        ChunkCount = 8,
        ParallelDownload = true,
        MaxTryAgainOnFailover = 3
    };

    private static readonly DownloadService DownloadSvc = new(DownloadConf);

    private static string LuaCompilerArchivePath
    {
        get
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return "lua.zip";
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                throw new NotSupportedException("no apple for you sorry");
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                return "lua.tar.gz";
            else
                throw new NotSupportedException("Lua binaries unavailable for current operating system");
        }
    }

    private static string LuaCompilerArchiveDownloadUrl
    {
        get
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return
                    "https://jaist.dl.sourceforge.net/project/luabinaries/5.4.2/Tools%20Executables/lua-5.4.2_Win64_bin.zip";
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                throw new NotSupportedException("no apple for you sorry");
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                return
                    "https://jaist.dl.sourceforge.net/project/luabinaries/5.4.2/Tools%20Executables/lua-5.4.2_Linux54_64_bin.tar.gz";
            else
                throw new NotSupportedException("Lua binaries unavailable for current operating system");
        }
    }

    private static string LuaCompilerExePath
    {
        get
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return "luac54.exe";
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                throw new NotSupportedException("no apple for you sorry");
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                return "luac54";
            else
                throw new NotSupportedException("Lua binaries unavailable for current operating system");
        }
    }

    public bool Ready => Directory.Exists(LuaCompilerDirPath);

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    public void EnsureExists()
    {
        if (Ready)
            return;

        Install();
    }

    public void Install()
    {
        Directory.CreateDirectory(LuaCompilerDirPath);

        var downloadStarted = false;
        var currentBytes = 0L;
        var maxBytes = 0L;

        Log.Information("Downloading Lua compiler...");

        AnsiConsole.Progress()
            .AutoRefresh(true)
            .AutoClear(false)
            .HideCompleted(false)
            .Columns([
                new TaskDescriptionColumn(),
                new ProgressBarColumn(),
                new PercentageColumn(),
                new ElapsedTimeColumn(),
                new RemainingTimeColumn(),
                new TransferSpeedColumn(),
                new SpinnerColumn()
            ])
            .Start(ctx =>
            {
                var task = ctx.AddTask("Download Lua Compiler", false);

                DownloadSvc.DownloadStarted += (_, args) =>
                {
                    downloadStarted = true;
                    maxBytes = args.TotalBytesToReceive;
                };
                DownloadSvc.DownloadProgressChanged += (_, args) =>
                {
                    Interlocked.Exchange(ref currentBytes, args.ReceivedBytesSize);
                };
                AsyncContext.Run(async () =>
                    await DownloadSvc.DownloadFileTaskAsync(LuaCompilerArchiveDownloadUrl, LuaCompilerArchivePath));

                while (true)
                {
                    if (downloadStarted)
                    {
                        task.Value = Interlocked.Read(ref currentBytes);
                        task.MaxValue = Interlocked.Read(ref maxBytes);
                    }

                    if (Interlocked.Read(ref currentBytes) == Interlocked.Read(ref maxBytes))
                    {
                        task.StopTask();
                        break;
                    }
                }
            });

        Log.Information("Extracting Lua compiler...");
        if (LuaCompilerArchivePath.EndsWith(".zip"))
            ZipFile.ExtractToDirectory(LuaCompilerArchivePath, LuaCompilerDirPath);
        else if (LuaCompilerArchivePath.EndsWith(".tar.gz"))
            TarFile.ExtractToDirectory(LuaCompilerArchivePath, LuaCompilerDirPath, true);
        File.Delete(LuaCompilerArchivePath);

        Log.Information("Installed external tool 'LuaCompiler'");
    }

    public byte[] Run(string path)
    {
        const string outputPath = "output.luac";

        Log.Information("Compiling Lua script {Path}", path);
        Process.Start(Path.Combine(LuaCompilerDirPath, LuaCompilerExePath), @$"-o {outputPath} ""{path}""")
            .WaitForExit();
        var bytes = File.ReadAllBytes(outputPath);
        File.Delete(outputPath);
        return bytes;
    }
}
