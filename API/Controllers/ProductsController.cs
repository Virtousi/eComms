using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            //new instance
            _context = context;
        }

        [HttpGet]
        //async is for performance, to get moving the thread so that it wont get stuck
        //public async Task<ActionResult<List<Product>>> GetProducts()
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products =await _context.Products.ToListAsync();
            
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}