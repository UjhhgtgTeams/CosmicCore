using System.Net;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Ceen;
using Ceen.Httpd;
using Ceen.Httpd.Logging;
using CosmicCore.Server.Dispatch.Handlers;
using CosmicCore.Server.Utilities;
using CosmicCore.Server.Utilities.Config;
using ServerConfig = Ceen.Httpd.ServerConfig;

namespace CosmicCore.Server.Dispatch.Service;

internal static class DispatchService
{
    public static void Start(DispatchServerConfig config)
    {
        var serverConfig = new ServerConfig
            {
                SSLCertificate = config.UseSsl
                    ? Utilities.Cryptography.Certificate.GetOrGenX509Cert(config.SslCertPath, config.SslCertPassword)
                    : null,
                SSLEnabledProtocols = config.UseSsl ? SslProtocols.Tls12 | SslProtocols.Tls13 : SslProtocols.None
            }
            .AddLogger(new CLFStdOut())

            .AddRoute("_ts", new GetTsHandler())

            .AddRoute("/query_dispatch", new QueryDispatchHandler())
            .AddRoute("/query_gateway", new QueryGatewayHandler())

            .AddRoute("/hkrpg_global/mdk/shield/api/login", new LoginRequestHandler())
            .AddRoute("/hkrpg_global/mdk/shield/api/verify", new TokenLoginRequestHandler())
            .AddRoute("/hkrpg_global/mdk/agreement/api/getAgreementInfos", new GetAgreementInfosHandler())
            .AddRoute("/hkrpg_global/combo/granter/login/v2/login", new ComboTokenRequestHandler())
            .AddRoute("/account/risky/api/check", new RiskyApiCheckHandler())

            .AddRoute("/data_abtest_api/config/experiment/list", new GetExperimentListHandler())
            .AddRoute("/hkrpg_global/combo/granter/api/getConfig", new ComboGranterApiGetConfigHandler())
            .AddRoute("/common/hkrpg_cn/announcement/api/getAlertAnn", new AnnouncementGetAlertAnnHandler())

            .AddRoute("/combo/box/api/config/sdk/combo", new ComboBoxGetComboHandler())
            .AddRoute("/combo/box/api/config/sw/precache", new ComboBoxGetPrecacheHandler())

            .AddRoute("/sdk/dataUpload", new SdkDataUploadHandler())
            .AddRoute("/hkrpg/dataUpload", new HkrpgDataUploadHandler())
            .AddRoute("/crashdump/dataUpload", new CrashDumpDataUploadHandler());

        HttpServer.ListenAsync(new IPEndPoint(
            IPAddress.Parse(config.Address),
            config.Port), config.UseSsl, serverConfig);
    }

    public static void Stop() { }
}
