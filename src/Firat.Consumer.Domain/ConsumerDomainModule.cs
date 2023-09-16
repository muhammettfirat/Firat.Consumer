using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Firat.Consumer;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ConsumerDomainSharedModule)
)]
public class ConsumerDomainModule : AbpModule
{

}
