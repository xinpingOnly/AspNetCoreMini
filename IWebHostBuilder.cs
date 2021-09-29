using System;

namespace AspNetCoreMini
{
    /// <summary>
    /// 提供WebHost的构建
    /// </summary>
    public interface IWebHostBuilder
    {
        IWebHostBuilder UseServer(IServer server);

        IWebHostBuilder Configure(Action<IApplicationBuilder> configure);

        IWebHost Build();
    }
}
