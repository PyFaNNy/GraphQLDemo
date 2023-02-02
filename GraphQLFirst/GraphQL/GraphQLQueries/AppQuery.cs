using GraphQL.Types;
using GraphQLFirst.Contracts;
using GraphQLFirst.GraphQL.GraphQLTypes;

namespace GraphQLFirst.GraphQL.GraphQLQueries;

public class AppQuery : ObjectGraphType
{
    public AppQuery(IOwnerRepository repository)
    {
        Field<ListGraphType<OwnerType>>(
            "owners",
            resolve: context => repository.GetAll()
        );
    }
}