using coffeeWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coffeeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;
        public ProductsController(ShopContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToArray();
        }

        //[HttpGet][Route("/api/Product/{id}")]

        //[HttpGet]
        //[Route("{id}")]

        [HttpGet("{id}")]
        public ActionResult GetProduct(int id)
        {
            var product = _context.Products.Find(id);
            return Ok(product);
        }

        //[HttpGet]
        //public ActionResult<Product> GetAllProducts()
        //{
        //    return Ok(_context.Products.ToArray());
        //}



    }
}
