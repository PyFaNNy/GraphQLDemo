using GraphQLFirst.Contracts;

namespace GraphQLFirst.Repository;

public class AccountRepository : IAccountRepository
{
    private readonly IApplicationContext _context;

    public AccountRepository(IApplicationContext context)
    {
        _context = context;
    }
}