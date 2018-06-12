using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.DesignPatterns.Singleton
{
    public sealed class LoadBalancer
    {
        private static readonly LoadBalancer Instance = new LoadBalancer();

        private readonly List<Server> _servers;
        private readonly Random _random = new Random();

        private  LoadBalancer()
        {
            _servers = new List<Server>()
            {
                new Server{Name = "ServerI", Ip = "120.14.220.18"},
                new Server{Name = "ServerII", Ip = "120.14.220.19"},
                new Server{Name = "ServerIII", Ip = "120.14.220.20"},
                new Server{Name = "ServerIV", Ip = "120.14.220.21"},
                new Server{Name = "ServerV", Ip = "120.14.220.22"},
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        public Server NextServer
        {
            get
            {
                var r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}
