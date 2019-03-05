using System;

namespace DemoGraphql.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ProductType Type { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
    }
}