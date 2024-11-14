using Microsoft.AspNetCore.Mvc;
using Shop.Models;

//Endpoint => URL
//https://localhost:5001/Categories/metodo

namespace Shop.Controllers
{
    [ApiController]
    [Route("Categories")]
    public class CategoryController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Get()
        {
            return "Olá mundo";
        }
        
        [HttpGet]
        [Route("{id:int}")]
        public string GetById(int id)
        {
            return "Get";
        }

        [HttpPost]
        [Route("")]
        public Category Post([FromBody]Category model)
        {
            return model;
        }

        [HttpPut]
        [Route("")]
        public string Put()
        {
            return "Put";
        }

        [HttpDelete]
        [Route("")]
        public string Delete()
        {
            return "Delete";
        }
    }
}
