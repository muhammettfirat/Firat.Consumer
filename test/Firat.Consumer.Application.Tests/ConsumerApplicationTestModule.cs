using Volo.Abp.Modularity;

namespace Firat.Consumer;

[DependsOn(
    typeof(ConsumerApplicationModule),
    typeof(ConsumerDomainTestModule)
    )]
public class ConsumerApplicationTestModule : AbpModule
{

}
