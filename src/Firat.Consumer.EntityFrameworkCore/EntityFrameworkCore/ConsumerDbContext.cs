using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Firat.Consumer.EntityFrameworkCore;

[ConnectionStringName(ConsumerDbProperties.ConnectionStringName)]
public class ConsumerDbContext : AbpDbContext<ConsumerDbContext>, IConsumerDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public ConsumerDbContext(DbContextOptions<ConsumerDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureConsumer();
    }
}
