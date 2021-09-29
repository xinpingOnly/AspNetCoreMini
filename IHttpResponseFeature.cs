using System.Collections.Specialized;
using System.IO;

namespace AspNetCoreMini
{
    /// <summary>
    /// 适配任何服务器所生产Context
    /// </summary>
    public interface IHttpResponseFeature
    {
        int StatusCode { get; set; }

        Stream Body { get; }

        NameValueCollection Headers { get; }
    }
}
