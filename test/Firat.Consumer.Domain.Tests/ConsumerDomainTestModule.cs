using Firat.Consumer.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Firat.Consumer;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(ConsumerEntityFrameworkCoreTestModule)
    )]
public class ConsumerDomainTestModule : AbpModule
{

}
