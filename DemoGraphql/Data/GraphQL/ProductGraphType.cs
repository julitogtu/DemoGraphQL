using DemoGraphql.Data.Entities;
using GraphQL.Types;

namespace DemoGraphql.Data.GraphQL
{
    public class ProductGraphType : ObjectGraphType<Product>
    {
        public ProductGraphType()
        {
            Field(t => t.Id).Description("Product id");
            Field(t => t.Name).Description("Product name");
            Field(t => t.Description).Description("Product description");
            Field(t => t.CreatedAt).Description("When the product was created");
            Field(t => t.Price).Description("Product price");
            Field<ProductTypeEnumType>("Type", "Product type");
        }
    }
}