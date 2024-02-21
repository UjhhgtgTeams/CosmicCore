using System.Net;
using System.Net.Security;
using Titanium.Web.Proxy;
using Titanium.Web.Proxy.EventArguments;
using Titanium.Web.Proxy.Models;

_ = new ProxyService("127.0.0.1", 8888);
Thread.Sleep(-1);

internal class ProxyService
{
    private const string QueryGatewayRequestString = "query_gateway";

    private static readonly string[] RedirectedDomains =
    [
        ".bhsr.com",
        ".starrails.com",
        ".hoyoverse.com",
        ".mihoyo.com"
    ];

    private readonly ProxyServer _webProxyServer;
    private readonly string _targetRedirectHost;
    private readonly int _targetRedirectPort;

    public ProxyService(string targetRedirectHost, int targetRedirectPort)
    {
        _webProxyServer = new ProxyServer();
        _webProxyServer.CertificateManager.EnsureRootCertificate();

        _webProxyServer.BeforeRequest += BeforeRequest;
        _webProxyServer.ServerCertificateValidationCallback += OnCertValidation;

        _targetRedirectHost = targetRedirectHost;
        _targetRedirectPort = targetRedirectPort;

        SetEndPoint(new ExplicitProxyEndPoint(IPAddress.Any, 8080, true));
    }

    private void SetEndPoint(ExplicitProxyEndPoint explicitEp)
    {
        explicitEp.BeforeTunnelConnectRequest += BeforeTunnelConnectRequest;

        _webProxyServer.AddEndPoint(explicitEp);
        _webProxyServer.Start();

        _webProxyServer.SetAsSystemHttpProxy(explicitEp);
        _webProxyServer.SetAsSystemHttpsProxy(explicitEp);
    }

    public void Shutdown()
    {
        _webProxyServer.Stop();
        _webProxyServer.Dispose();
    }

    private Task BeforeTunnelConnectRequest(object sender, TunnelConnectSessionEventArgs args)
    {
        var hostname = args.HttpClient.Request.RequestUri.Host;
        Console.WriteLine(hostname);
        args.DecryptSsl = ShouldRedirect(hostname);

        return Task.CompletedTask;
    }

    private Task OnCertValidation(object sender, CertificateValidationEventArgs args)
    {
        if (args.SslPolicyErrors == SslPolicyErrors.None)
            args.IsValid = true;

        return Task.CompletedTask;
    }

    private Task BeforeRequest(object sender, SessionEventArgs args)
    {
        var hostname = args.HttpClient.Request.RequestUri.Host;
        if (ShouldRedirect(hostname) || (hostname == _targetRedirectHost &&
                                         args.HttpClient.Request.RequestUri.AbsolutePath.Contains(
                                             QueryGatewayRequestString)))
        {
            var requestUrl = args.HttpClient.Request.Url;
            var local = new Uri($"http://{_targetRedirectHost}:{_targetRedirectPort}/");

            var replacedUrl = new UriBuilder(requestUrl)
            {
                Scheme = local.Scheme,
                Host = local.Host,
                Port = local.Port
            }.Uri.ToString();

            Console.WriteLine("Redirecting " + replacedUrl);
            args.HttpClient.Request.Url = replacedUrl;
        }

        return Task.CompletedTask;
    }

    private static bool ShouldRedirect(string hostname)
    {
        return RedirectedDomains.Any(hostname.EndsWith);
    }
}
