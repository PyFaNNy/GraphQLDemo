using GraphQLFirst.Entities;

namespace GraphQLFirst.Contracts;

public interface IOwnerRepository
{
    IEnumerable<Owner> GetAll();
    Owner GetById(Guid id);
}