using System;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreMini
{
    public static partial class Extension
    {
        public static IWebHostBuilder UseMyServer(this IWebHostBuilder builder) => builder.UseServer(new MyServer());
        public static T Get<T>(this IFeatureCollections features) => features.TryGetValue(typeof(T), out object value) ? (T)value : default;

        public static IFeatureCollections Set<T>(this IFeatureCollections features, T feature)
        {
            features[typeof(T)] = feature;
            return features;
        }
        public static Task WriteAsync(this HttpResponse reponse,string content)
        {
            var contentBody = Encoding.UTF8.GetBytes(content);
            return reponse.Body.WriteAsync(contentBody, 0, contentBody.Length);
        }

        public static Task WriteAsync<T>(this HttpResponse reponse,T obj)
        {
            var content = JsonConvert.SerializeObject(obj);
            var body = Encoding.UTF8.GetBytes(content);
            return reponse.Body.WriteAsync(body, 0, body.Length);
        }
        public static HttpResponse Write(this HttpResponse reponse, string content)
        {
            var contentBody = Encoding.UTF8.GetBytes(content);
            reponse.Body.Write(contentBody, 0, contentBody.Length);
            return reponse;
        }

        public static IApplicationBuilder UseRoute(this IApplicationBuilder app)
        {
            app.Use(next => async context =>
            {
                await context.Response.WriteAsync(context.Response.Headers);
            });
            return app;
        }
        public static T GetService<T>(this IServiceProvider provider)
        {
            return default;
        }
    }
}
