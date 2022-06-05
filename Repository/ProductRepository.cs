using Bogus;
using BogusFakeData_WebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace BogusFakeData_WebApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> Get()
        {
            var productFaker = new Faker<Product>("en")
            .RuleFor(i => i.Id, i => i.IndexFaker)
            .RuleFor(i => i.Name, i => i.Commerce.ProductName())
            .RuleFor(i => i.Description, i => i.Commerce.ProductDescription())
            .RuleFor(i => i.PictureUri, i => i.Image.PicsumUrl())
            .RuleFor(i => i.Price, i => i.Commerce.Price(5, 1000, 2).First())
            .RuleFor(i => i.Category, i => i.Commerce.Categories(1).First());

            List<Product> products = productFaker.Generate(400);
            return products;
        }
    }
}
