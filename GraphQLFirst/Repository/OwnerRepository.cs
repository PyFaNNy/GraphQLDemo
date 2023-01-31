using GraphQLFirst.Contracts;
using GraphQLFirst.Entities;

namespace GraphQLFirst.Repository;

public class OwnerRepository : IOwnerRepository
{
    private readonly IApplicationContext _context;

    public OwnerRepository(IApplicationContext context)
    {
        _context = context;
    }
    
    public IEnumerable<Owner> GetAll() => _context.Owners.ToList();
}