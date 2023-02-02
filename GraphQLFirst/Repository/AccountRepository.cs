using GraphQLFirst.Contracts;
using GraphQLFirst.Entities;

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
}