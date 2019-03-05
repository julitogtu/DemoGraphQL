using GraphQL;
using GraphQL.Types;

namespace DemoGraphql.Data.GraphQL
{
    public class DemoSchema : Schema
    {
        public DemoSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<DemoQuery>();
        }   
    }
}