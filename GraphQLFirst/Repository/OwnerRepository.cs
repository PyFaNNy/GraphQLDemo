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

    public IEnumerable<Owner> GetAll() => _context.Owners.Include(x => x.Accounts).ToList();
    public Owner GetById(Guid id) => _context.Owners.SingleOrDefault(o => o.Id.Equals(id));

    public Owner CreateOwner(Owner owner)
    {
        _context.Owners.Add(owner);
        _context.SaveChanges();
        return owner;
    }

    public Owner UpdateOwner(Owner dbOwner, Owner owner)
    {
        dbOwner.Name = owner.Name;
        dbOwner.Address = owner.Address;
        _context.SaveChanges();
        return dbOwner;
    }
    
    public void DeleteOwner(Owner owner)
    {
        _context.Owners.Remove(owner);
        _context.SaveChanges();
    }
}