namespace AspNetCoreMini
{
    public class HttpContext
    {
        public HttpRequest Request { get; set; }
        public HttpResponse Response { get; set; }

        public HttpContext(IFeatureCollections features)
        {
            Request = new HttpRequest(features);
            Response = new HttpResponse(features);
        }
    }
}
