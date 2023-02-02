using GraphQLFirst.Contracts;
using GraphQLFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQLFirst.Repository;

public class OwnerRepository : IOwnerRepository
{
    private readonly IApplicationContext _context;

    public OwnerRepository(IApplicationContext context)
    {
        _context = context;
    }
    
    public IEnumerable<Owner> GetAll() => _context.Owners.Include(x =>x.Accounts).ToList();
    public Owner GetById(Guid id) => _context.Owners.SingleOrDefault(o => o.Id.Equals(id));
}