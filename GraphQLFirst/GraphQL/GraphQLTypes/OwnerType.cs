using GraphQL.Types;
using GraphQLFirst.Entities;

namespace GraphQLFirst.GraphQL.GraphQLTypes;

public class OwnerType : ObjectGraphType<Owner>
{
    public OwnerType()
    {
        Name = nameof(Owner);
        
        Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the owner object.");
        Field(x => x.Name).Description("Name property from the owner object.");
        Field(x => x.Address).Description("Address property from the owner object.");
        Field(
            name: "Accounts",
            description: "Personal accounts.",
            type: typeof(ListGraphType<AccountType>),
            resolve: x => x.Source.Accounts
        );
    }
}