using GraphQLFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQLFirst.Contracts;

public interface IApplicationContext
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Owner> Owners { get; set; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    int SaveChanges();
}