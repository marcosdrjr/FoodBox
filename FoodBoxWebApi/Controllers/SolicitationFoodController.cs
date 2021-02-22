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
    public class SolicitationFoodController : ControllerBase
    {
        // GET: api/<SolicitationFoodController>
        [HttpGet]
        public async Task<ActionResult<List<SolicitationFoodDTO>>> Get([FromServices] ISolicitationFoodServices solicitationFood)
        {
            var data = await solicitationFood.GetSolicitationFood();

            return Ok(data);
        }

        // GET api/<SolicitationFoodController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SolicitationFoodDTO>> Get(int id, [FromServices] ISolicitationFoodServices solicitationFood)
        {
            var data = await solicitationFood.GetSolicitationFoodById(id);

            return Ok(data);
        }
    }
}
