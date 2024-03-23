using System.Diagnostics;
using System.IO.Compression;
using CosmicCore.Server.Utilities;
using CosmicCore.Server.Utilities.External;
using Downloader;
using Nito.AsyncEx;
using Serilog;
using Spectre.Console;

namespace CosmicCore.Server.LuaPlugin;

public class LuaScriptCompiler : Singleton<LuaScriptCompiler>, IExternalTool
{
    private const string LuaCompilerArchivePath = "lua.zip";

    private const string LuaCompilerArchiveDownloadUrl =
        "https://jaist.dl.sourceforge.net/project/luabinaries/5.4.2/Tools%20Executables/lua-5.4.2_Win64_bin.zip";

    private static readonly string LuaCompilerDirPath = Path.Combine("ExternalTool", "LuaCompiler");

    private static readonly DownloadConfiguration DownloadConf = new()
    {
        ChunkCount = 8,
        ParallelDownload = true,
        MaxTryAgainOnFailover = 3
    };

    private static readonly DownloadService DownloadSvc = new(DownloadConf);

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
        ZipFile.ExtractToDirectory(LuaCompilerArchivePath, LuaCompilerDirPath);
        File.Delete(LuaCompilerArchivePath);

        Log.Information("Installed external tool 'LuaCompiler'");
    }

    public byte[] Run(string path)
    {
        const string outputPath = "output.luac";

        Log.Information("Compiling Lua script {Path}", path);
        Process.Start(Path.Combine(LuaCompilerDirPath, "luac54.exe"), @$"-o {outputPath} ""{path}""").WaitForExit();
        var bytes = File.ReadAllBytes(outputPath);
        File.Delete(outputPath);
        return bytes;
    }
}
