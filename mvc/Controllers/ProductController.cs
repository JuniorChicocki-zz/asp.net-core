using Microsoft.AspNetCore.Mvc;

namespace MVC
{
    [Route("api/product")]
    public class ProductController : Controller
    {
        [HttpGet("{id:int}")]
        public string Get(int id){
            //return id;
            return HttpContext.Request.Path;
        }
    }
}
