using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNEms.Shared.Constants;

namespace VNEms.Hosting.Shared
{
    public static class HostApplicationBuilderExtensions
    {
        public static IHostApplicationBuilder AddSharedEndpoints(this IHostApplicationBuilder builder)
        {
            builder.AddRabbitMQClient(
                connectionName: VNEmsNames.RabbitMq,
                action =>
                    action.ConnectionString = builder.Configuration.GetConnectionString(
                        VNEmsNames.RabbitMq
                    )
            );
            builder.AddRedisDistributedCache(connectionName: VNEmsNames.Redis);
            builder.AddSeqEndpoint(connectionName: VNEmsNames.Seq);

            return builder;
        }
    }
}
