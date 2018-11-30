using Consul;

namespace Easy.Rpc.Consul
{
    public class ConsulRpcOptionsConfiguration
    {
        /// <summary> ASP.NET Core runtime hosting </summary>
        public string HostingUrls { get; set; }

        /// <summary> hosting and rpc (or consul) health check status </summary>
        public string HostingAndRpcHealthCheck { get; set; }

        public Rpc GRpc { get; set; }

        public ServiceDescriptor ServiceDescriptors { get; set; }
        public ConsulRegister ConsulRegister { get; set; }
        public ConsulClientConfiguration ConsulClientConfiguration { get; set; }
    }

    /// <summary> Rpc remote invoke and Rpc hosting server address </summary>
    public class Rpc
    {
        public string Ip { get; set; }
        public int Port { get; set; }
    }

    public class ServiceDescriptor
    {
        public string Name { get; set; }
    }

    /// <summary> Register consul interface address </summary>
    public class ConsulRegister
    {
        public string Ip { get; set; }
        public int Port { get; set; }
        public int Timeout { get; set; }
    }
}