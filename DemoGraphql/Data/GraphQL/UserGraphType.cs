using DemoGraphql.Data.Entities;
using GraphQL.Types;

namespace DemoGraphql.Data.GraphQL
{
    public class UserGraphType : ObjectGraphType<User>
    {
        public UserGraphType()
        {
            Field(t => t.Id).Description("User id");
            Field(t => t.Name).Description("User name");
        }
    }
}