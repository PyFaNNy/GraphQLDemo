using GraphQL.Types;
using GraphQLFirst.Contracts;
using GraphQLFirst.Entities;

namespace GraphQLFirst.GraphQL.GraphQLTypes;

public class OwnerType : ObjectGraphType<Owner>
{
    public OwnerType(IAccountRepository repository)
    {
        Name = nameof(Owner);
        
        Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the owner object.");
        Field(x => x.Name).Description("Name property from the owner object.");
        Field(x => x.Address).Description("Address property from the owner object.");
        Field<ListGraphType<AccountType>>(
            "accounts",
            resolve: context => repository.GetAllAccountsPerOwner(context.Source.Id)
        );
    }   
}