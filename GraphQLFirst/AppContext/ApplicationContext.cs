using System.Reflection;
using GraphQLFirst.Contracts;
using GraphQLFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQLFirst.AppContext;

public class ApplicationContext : DbContext, IApplicationContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> dbContextOptions) : base(dbContextOptions)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<Owner> Owners { get; set; }
    
    public override int SaveChanges()
    {
        var result = base.SaveChanges();

        return result;
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        var result = await base.SaveChangesAsync(cancellationToken);

        return result;
    }
}