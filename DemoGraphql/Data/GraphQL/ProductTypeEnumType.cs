using DemoGraphql.Data.Entities;
using GraphQL.Types;

namespace DemoGraphql.Data.GraphQL
{
    public class ProductTypeEnumType : EnumerationGraphType<ProductType>
    {
        public ProductTypeEnumType()
        {
            Name = "Type";
            Description = "The type of product";
        }
    }
}