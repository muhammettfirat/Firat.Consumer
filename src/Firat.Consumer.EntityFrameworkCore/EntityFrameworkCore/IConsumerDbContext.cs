using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Firat.Consumer.EntityFrameworkCore;

[ConnectionStringName(ConsumerDbProperties.ConnectionStringName)]
public interface IConsumerDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
