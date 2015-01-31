using System;
using System.Collections.Generic;

namespace Singleton
{
    public class LoadBalancer
    {
        private static readonly object SyncLock = new object();
        private static LoadBalancer loadBalancer;

        private readonly List<string> servers;
        private readonly Random random;

        private LoadBalancer()
        {
            this.servers = new List<string>();
            this.random = new Random();

            this.servers.Add("ServerI");
            this.servers.Add("ServerII");
            this.servers.Add("ServerIII");
            this.servers.Add("ServerIV");
            this.servers.Add("ServerV");
        }

        public string Server
        {
            get
            {
                int r = this.random.Next(this.servers.Count);
                return this.servers[r];
            }
        }

        public static LoadBalancer GetLoadBalancer()
        {
            if (loadBalancer == null)
            {
                lock (SyncLock)
                {
                    if (loadBalancer == null)
                    {
                        loadBalancer = new LoadBalancer();
                    }
                }
            }

            return loadBalancer;
        }
    }
}