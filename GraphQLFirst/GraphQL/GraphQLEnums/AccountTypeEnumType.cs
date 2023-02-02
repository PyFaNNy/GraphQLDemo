using GraphQL.Types;
using GraphQLFirst.Enums;

namespace GraphQLFirst.GraphQL.GraphQLEnums;

public class AccountTypeEnumType : EnumerationGraphType<TypeOfAccount>
{
    public AccountTypeEnumType()
    {
        Name = "Type";
        Description = "Enumeration for the account type object.";
    }
}