using Demo_OData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using System.Collections.Generic;
using System.Linq;

namespace Demo_OData.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private ODataDbContext context { get; set; }

        public ProductController(ODataDbContext context)
        {
            this.context = context;
        }


        [HttpGet()]
        [EnableQuery()]
        public IQueryable<Product> Index()
        {
            IQueryable<Product> queryProducts = context.Products;

            return queryProducts;
        }



        [HttpGet("low")]
        [EnableQuery()]
        public ActionResult Index2()
        {
            List<Product> productos = context.Products.ToList();

            return Ok(productos);
        }

    }
}
