using System.Collections.Specialized;
using System.IO;

namespace AspNetCoreMini
{
    public class HttpResponse
    {
        private IHttpResponseFeature _feature;
        public Stream Body => _feature.Body;
        public NameValueCollection Headers => _feature.Headers;
        public int StatusCode { get => _feature.StatusCode; set => _feature.StatusCode = value; }

        public HttpResponse(IFeatureCollections features) => _feature = features.Get<IHttpResponseFeature>();

    }
}
