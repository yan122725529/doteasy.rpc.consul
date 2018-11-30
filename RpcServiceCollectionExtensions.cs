using Easy.Rpc.Core.Communally.Serialization;
using Easy.Rpc.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Easy.Rpc.Consul
{
    public static class RpcServiceCollectionExtensions
    {
        public static IRpcBuilder UseConsulRouteManager(this IRpcBuilder builder,
            ConsulRpcOptionsConfiguration consulRpcOptionsConfiguration)
        {
            return builder.UseRouteManager(provider =>
                new ConsulServiceRouteManager(
                    consulRpcOptionsConfiguration,
                    provider.GetRequiredService<ISerializer<byte[]>>(),
                    provider.GetRequiredService<ISerializer<string>>(),
                    provider.GetRequiredService<IServiceRouteFactory>(),
                    provider.GetRequiredService<ILogger<ConsulServiceRouteManager>>()
                ));
        }
    }
}