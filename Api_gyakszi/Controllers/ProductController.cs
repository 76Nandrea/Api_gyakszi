using Api_gyakszi.DAL.Data;
using Api_gyakszi.DAL.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_gyakszi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //ha csak osztályból jelenítem meg, nem DBből 
        //[HttpGet]
        //public async Task<ActionResult<List<Product>>>GetAllProduct()
        //{
        //    var productsList = new List<Product>
        //    {
        //        new Product
        //        { Id = 1,
        //        }

        //    };
        //    return Ok (productsList);
        //}


        //dbből való megjelenítés
        private readonly MySQLDBContext _dbContext;

        public ProductController(MySQLDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>>GetAllProduct()
        {
            var products = _dbContext.products.ToList();
            return Ok(products);   //(products) - amit meg akarok jeleníteni ha üres, nem fog visszaadni semmit!!! FONTOS!
        }
    }
}
