using System.Linq;
using DemoGraphql.Data.Entities;
using GraphQL.Types;

namespace DemoGraphql.Data.GraphQL
{
    public class DemoQuery : ObjectGraphType
    {
        public DemoQuery(DemoRepository repository)
        {
            Field<ListGraphType<ProductGraphType>>(
                "products",
                resolve: context => repository.GetAllProducts()
            );

            Field<ListGraphType<UserGraphType>>(
                "users",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "top" }),
                resolve: context =>
                {
                    var top = context.GetArgument<int>("top");
                    if (top == 0) top = 50;
                    var data = repository.GetAllUsers().Take(top);
                    return data;
                });

            Field<UserGraphType>(
                "user",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return repository.GetAllUsers().FirstOrDefault(c => c.Id == id);
                });
        }
    }
}