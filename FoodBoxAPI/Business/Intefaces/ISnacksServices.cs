using FoodBoxLibrary.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBoxApi.Business.Intefaces
{
    public interface ISnacksServices
    {
        Task<List<SnacksDTO>> GetSnacks();
    }
}
