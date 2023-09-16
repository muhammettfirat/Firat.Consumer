using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Firat.Consumer;

[DependsOn(
    typeof(ConsumerDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class ConsumerApplicationContractsModule : AbpModule
{

}
