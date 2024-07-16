using Microsoft.AspNetCore.Mvc;
using Products_.Data;
using Products_.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Products_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            _appDbContext.Products.Add(product);
            await _appDbContext.SaveChangesAsync();
            return Ok(product);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var products = await _appDbContext.Products.ToListAsync();
            return Ok(products);
        }
    }
}
