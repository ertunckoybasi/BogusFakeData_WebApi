using Bogus;
using BogusFakeData_WebApi.Models;
using BogusFakeData_WebApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BogusFakeData_WebApi.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("api/[controller]/get")]
        public List<Product> GetFakeProducts()
        {
          return  _productRepository.Get().ToList();
        }
    }
}
