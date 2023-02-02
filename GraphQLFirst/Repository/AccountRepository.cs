using GraphQLFirst.Contracts;
using GraphQLFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQLFirst.Repository;

public class AccountRepository : IAccountRepository
{
    private readonly IApplicationContext _context;

    public AccountRepository(IApplicationContext context)
    {
        _context = context;
    }

    public IEnumerable<Account> GetAllAccountsPerOwner(Guid ownerId) => _context.Accounts
        .Where(a => a.OwnerId.Equals(ownerId))
        .ToList();
    public async Task<ILookup<Guid, Account>> GetAccountsByOwnerIds(IEnumerable<Guid> ownerIds)
    {
        var accounts = await _context.Accounts.Where(a => ownerIds.Contains(a.OwnerId)).ToListAsync();
        return accounts.ToLookup(x => x.OwnerId);
    }
}