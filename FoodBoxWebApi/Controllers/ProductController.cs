using FoodBoxLibrary.Models.DTOS;
using FoodBoxWebApi.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodBoxWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public async Task<ActionResult<List<ProductDTO>>> Get([FromServices] IPoductServices snacks)
        {
            var data = await snacks.GetPoduct();

            return Ok(data);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> Get(int id, [FromServices] IPoductServices snacks)
        {
            var data = await snacks.GetPoductById(id);

            return Ok(data);
        }
    }
}
