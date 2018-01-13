using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Domain;
using Shop.Web.Models;

namespace Shop.Web.Controllers
{
    [Route("products")]
    public class ProductsController : Controller
    {

        private static readonly List<Product> _products = new List<Product>
        {
            new Product("Laptop", "Electronics", 3000),
            new Product("Jeans", "Trousers", 150),
            new Product("Hammer", "Tools", 47)
        };
        //private IProductRespository _productRepository;
        //public Guid Is = Guid.NewGuid();

        //    public object Name { get; private set; }
        //   public object Category { get; private set; }
        //    public object Price { get; private set; }

        //public ProductsController(IProductRespository productRespository)
        //{
        //    _productRepository = productRespository;
        //}

        [HttpGet]
        public IActionResult Index()
        {
            var products = _products.Select(p => new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Category = p.Category,
                Price = p.Price
            });


            return View(products);
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            var viewModel = new AddProductViewModel();
            return View(viewModel);
        }

        [HttpPost("add")]
        public IActionResult Add(AddProductViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            _products.Add(new Product(viewModel.Name, viewModel.Category, viewModel.Price));

            return RedirectToAction(nameof(Index));
        }
    }
}