using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Firat.Consumer;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ConsumerHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ConsumerConsoleApiClientModule : AbpModule
{

}
