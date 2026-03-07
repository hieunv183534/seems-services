using Microsoft.EntityFrameworkCore;
using System;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace VNEmsResource.EntityFrameworkCore;

[ConnectionStringName(VNEmsResourceDbProperties.ConnectionStringName)]
public class VNEmsResourceDbContext : AbpDbContext<VNEmsResourceDbContext>
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public VNEmsResourceDbContext(DbContextOptions<VNEmsResourceDbContext> options)
        : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureVNEmsResource();
    }
}
