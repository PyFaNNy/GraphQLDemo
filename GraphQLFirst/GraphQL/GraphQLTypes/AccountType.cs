using GraphQL.Types;
using GraphQLFirst.Entities;

namespace GraphQLFirst.GraphQL.GraphQLTypes;

public class AccountType : ObjectGraphType<Account>
{
    public AccountType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the account object.");
            Field(x => x.Description).Description("Description property from the account object.");
            Field(x => x.Type).Description("Type property from the owner object.");
        }
}