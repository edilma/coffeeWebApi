using coffeeWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        //[HttpGet]
        //public IEnumerable<Product> GetAllProducts()
        //{
        //    return _context.Products.ToArray();
        //}

        //[HttpGet]
        //public async Task<IEnumerable<Product>> GetAllProducts
        //{
        //    return await _context.Products.ToArrayAsync();
        //}


        [HttpGet]
        public async Task<ActionResult> GetAllProducts()
        {
            return Ok(await _context.Products.ToArrayAsync());
        }

        //[HttpGet][Route("/api/Product/{id}")]

        //[HttpGet]
        //[Route("{id}")]

        [HttpGet("{id}")]
        public async Task<ActionResult> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return  BadRequest(ModelState);
            }
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return CreatedAtAction(
                "GetProduct",
                new {id = product.Id },
                product);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutProduct (int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            _context.Entry(product).State= EntityState.Modified; 

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Products.Any(p=>p.Id==id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
           
            if (product == null)
            {
                return NotFound();
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        [Route("Delete")]
        public async Task<ActionResult> DeleteManyProducts([FromQuery]  int[] ids)
        {
            var products = new List<Product>();
            foreach (var id in ids)
            {
                var aproduct = await _context.Products.FindAsync(id);
                if (aproduct == null)
                {
                    return NotFound();
                }
                products.Add(aproduct);
            }

            _context.Products.RemoveRange(products);
 
            await _context.SaveChangesAsync();

            return Ok(products);
        }



    }
}
