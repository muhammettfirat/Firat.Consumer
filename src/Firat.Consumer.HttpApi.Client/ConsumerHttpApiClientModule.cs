using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Firat.Consumer;

[DependsOn(
    typeof(ConsumerApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class ConsumerHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ConsumerApplicationContractsModule).Assembly,
            ConsumerRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ConsumerHttpApiClientModule>();
        });

    }
}
