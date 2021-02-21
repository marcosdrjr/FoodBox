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
    public class SnacksController : ControllerBase
    {
        // GET: api/<SnacksController>
        [HttpGet]
        public async Task<ActionResult<List<SnacksDTO>>> Get([FromServices] ISnacksServices snacks)
        {
            var data = await snacks.GetSnacks();

            return Ok(data);
        }

        // GET api/<SnacksController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SnacksDTO>> Get(int id, [FromServices] ISnacksServices snacks)
        {
            var data = await snacks.GetSnacksById(id);

            return Ok(data);
        }
        // POST api/<SnacksController>
        [HttpPost]
        public async Task<ActionResult<SolicitationProductSnacksDTO>> Post([FromBody] SolicitationProductSnacksDTO body, [FromServices] ISnacksServices snacks)
        {
            var data = await snacks.PostSnacks(body);

            return Ok(data);
        }
    }
}
