using System;
using System.Collections.Generic;

namespace DemoGraphql.Data.Entities
{
    public class DemoRepository
    {
        public List<Product> GetAllProducts()
        {
            var products = new List<Product>();

            for (var i = 1; i < 50; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    CreatedAt = DateTimeOffset.Now.AddMinutes(i),
                    Description = $"Product description {i}",
                    Name = $"Product {i}",
                    Price = new Random(i).Next(1000,99999),
                    Type = i % 2 == 0 ? ProductType.Books : ProductType.Movies
                });    
            }

            return products;
        }

        public List<User> GetAllUsers()
        {
            var users = new List<User>();

            for (var i = 1; i < 50; i++)
            {
                users.Add(new User
                {
                    Id = i,
                    Name = $"user {i}",
                });
            }

            return users;
        }
    }
}