using Demo_OData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace Demo_OData.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    public class ProductsController : ODataController
    {
        private ODataDbContext context { get; set; }

        public ProductsController(ODataDbContext context)
        {
            this.context = context;
        }


        //[HttpGet()]
        //[EnableQuery]
        //public IQueryable<Product> Get()
        //{
        //    IQueryable<Product> queryProducts = context.Products;

        //    return queryProducts;
        //}


        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(context.Products);
        }


        //[HttpGet("low")]
        //[EnableQuery()]
        //public ActionResult Index2()
        //{
        //    List<Product> productos = context.Products.ToList();

        //    return Ok(productos);
        //}

    }
}
