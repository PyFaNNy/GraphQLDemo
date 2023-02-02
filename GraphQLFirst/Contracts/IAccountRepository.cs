using GraphQLFirst.Entities;

namespace GraphQLFirst.Contracts;

public interface IAccountRepository
{
    IEnumerable<Account> GetAllAccountsPerOwner(Guid ownerId);
}