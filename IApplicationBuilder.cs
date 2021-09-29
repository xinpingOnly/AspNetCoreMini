using System;
using System.Threading.Tasks;

namespace AspNetCoreMini
{
    /// <summary>
    /// 可等待的中间件
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public delegate Task RequestDelegate(HttpContext context);

    public interface IApplicationBuilder
    {
        /// <summary>
        /// 提供注册中间件功能
        /// </summary>
        /// <param name="middleware"></param>
        /// <returns></returns>
        IApplicationBuilder Use(Func<RequestDelegate,RequestDelegate> middleware);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        RequestDelegate Build();
    }
}
