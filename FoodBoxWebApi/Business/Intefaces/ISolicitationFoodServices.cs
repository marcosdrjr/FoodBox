using FoodBoxLibrary.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBoxWebApi.Business.Intefaces
{
    public interface ISolicitationFoodServices
    {
        Task<List<SolicitationFoodDTO>> GetSolicitationFood();
        Task<SolicitationFoodDTO> GetSolicitationFoodById(int ID);
    }
}
