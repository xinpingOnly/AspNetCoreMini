using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreMini
{
    public class WebHost : IWebHost
    {
        private IServer _server;
        private RequestDelegate _handler;
        public WebHost(IServer server,RequestDelegate handler)
        {
            _server = server;
            _handler = handler;
        }

        public Task StartAsync() => _server.StartAsync(_handler);
    }
}
