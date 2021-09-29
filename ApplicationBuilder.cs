using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreMini
{
    public class ApplicationBuilder : IApplicationBuilder
    {
        /// <summary>
        /// 可等待中间件集合
        /// </summary>
        private List<Func<RequestDelegate, RequestDelegate>> _middlewares = new List<Func<RequestDelegate, RequestDelegate>>();

        public RequestDelegate Build()
        {
            _middlewares.Reverse();
            return context =>
            {
                RequestDelegate next =  _ => { Console.WriteLine("default-404"); _.Response.StatusCode = 404; return Task.CompletedTask; };
                foreach (var middleware in _middlewares)
                {
                    next = middleware(next);
                }
                return next(context);
            };
        }

        public IApplicationBuilder Use(Func<RequestDelegate,RequestDelegate> middleware)
        {
            _middlewares.Add(middleware);
            return this;
        }
    }
}
