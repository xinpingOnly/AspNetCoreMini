using System.Threading.Tasks;

namespace AspNetCoreMini
{
    /// <summary>
    /// 提供服务器启动,中间件服务注册等Web宿主
    /// </summary>
    public interface IWebHost
    {
        Task StartAsync();
    }
}
