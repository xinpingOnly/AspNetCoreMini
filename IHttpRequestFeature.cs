using System;
using System.Collections.Specialized;
using System.IO;

namespace AspNetCoreMini
{
    public interface IHttpRequestFeature
    {
        Uri Url { get; }
        Stream Body { get; }
        NameValueCollection Headers { get; }
    }
}
