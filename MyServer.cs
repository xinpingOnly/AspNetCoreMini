using System;
using System.Net;
using System.Threading.Tasks;
using System.Linq;

namespace AspNetCoreMini
{
    public class MyServer : IServer
    {
        private readonly HttpListener _httpListener;
        private readonly string[] _urls;

        public MyServer(params string[] urls)
        {
            _httpListener = new HttpListener();
            _urls = urls.Any() ? urls : new string[] { "http://*:5000/" };
        }
        public async Task StartAsync(RequestDelegate handler)
        {
            Array.ForEach(_urls, url => _httpListener.Prefixes.Add(url));
            _httpListener.Start();


            while (true)
            {
                var context = await _httpListener.GetContextAsync();

                var features = new FeatureCollection();
                var feature = new HttpListenContextFeature(context);
                features.Set<IHttpRequestFeature>(feature).Set<IHttpResponseFeature>(feature);

                HttpContext httpContext = new HttpContext(features);
                await handler(httpContext);
                context.Response.Close();
            }
        }
    }
    
}
