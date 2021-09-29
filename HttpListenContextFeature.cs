using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;

namespace AspNetCoreMini
{
    public class HttpListenContextFeature : IHttpRequestFeature, IHttpResponseFeature
    {
        private readonly HttpListenerContext _context;
        public Uri Url => _context.Request.Url;

        Stream IHttpResponseFeature.Body => _context.Response.OutputStream;
        Stream IHttpRequestFeature.Body => _context.Request.InputStream;

        NameValueCollection IHttpRequestFeature.Headers => _context.Request.Headers;
        NameValueCollection IHttpResponseFeature.Headers => _context.Response.Headers;

        public int StatusCode { get => _context.Response.StatusCode; set => _context.Response.StatusCode = value; }


        public HttpListenContextFeature(HttpListenerContext context)
        {
            _context = context;
        }
    }
}
