using System.Threading.Tasks;

namespace AspNetCoreMini
{
    
    public interface IServer
    {
        /// <summary>
        /// 提供服务器的启动
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        Task StartAsync(RequestDelegate handler);
    }
}
