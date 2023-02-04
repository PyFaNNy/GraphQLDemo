﻿using GraphQL.Types;

namespace GraphQLFirst.GraphQL.GraphQLTypes;

public class OwnerInputType : InputObjectGraphType
{
    public OwnerInputType()
    {
        Name = "ownerInput";
        Field<NonNullGraphType<StringGraphType>>("name");
        Field<NonNullGraphType<StringGraphType>>("address");
    }
}