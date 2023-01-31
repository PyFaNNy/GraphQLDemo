using GraphQLFirst.Contracts;
using GraphQLFirst.Entities;

namespace GraphQLFirst.GraphQL.Queries;

public class Query
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Owner> getOwners([Service] IApplicationContext context) =>
        context.Owners;
}