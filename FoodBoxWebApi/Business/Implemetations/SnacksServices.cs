using FoodBoxLibrary.Models.DTOS;
using FoodBoxWebApi.Business.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBoxWebApi.Business.Implemetations
{
    public class SnacksServices : ISnacksServices
    {
        public async Task<List<SnacksDTO>> GetSnacks()
        {
            var listSnacks = new List<SnacksDTO>();
            listSnacks.Add(new SnacksDTO {id_snacks = 1, name = "1", description = "01" });
            listSnacks.Add(new SnacksDTO {id_snacks = 2, name = "2", description = "02" });
            listSnacks.Add(new SnacksDTO {id_snacks = 3, name = "3", description = "03" });
            listSnacks.Add(new SnacksDTO {id_snacks = 4, name = "4", description = "04" });
            listSnacks.Add(new SnacksDTO {id_snacks = 5, name = "5", description = "05" });
            return listSnacks;
        }
    }
}
