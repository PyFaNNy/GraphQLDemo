using GraphQL.Types;
using GraphQLFirst.GraphQL.GraphQLQueries;

namespace GraphQLFirst.GraphQL.GraphQLSchema;

public class AppSchema : Schema
{
    public AppSchema(IServiceProvider provider)
        :base(provider)
    {
        Query = provider.GetRequiredService<AppQuery>();
    }
}