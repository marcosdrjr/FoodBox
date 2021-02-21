﻿using FoodBoxLibrary.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBoxWebApi.Business.Intefaces
{
    public interface ISnacksServices
    {
        Task<List<SnacksDTO>> GetSnacks();
        Task<SnacksDTO> GetSnacksById(int ID);
        Task<SolicitationProductSnacksDTO> PostSnacks(SolicitationProductSnacksDTO  body);

    }
}
