using GraphQLFirst.Contracts;

namespace GraphQLFirst.Repository;

public class OwnerRepository : IOwnerRepository
{
    private readonly IApplicationContext _context;

    public OwnerRepository(IApplicationContext context)
    {
        _context = context;
    }
}