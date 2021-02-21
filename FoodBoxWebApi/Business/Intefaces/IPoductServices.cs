using FoodBoxLibrary.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBoxWebApi.Business.Intefaces
{
   public interface IPoductServices
    {
        Task<List<PoductDTO>> GetPoduct();
        Task<PoductDTO> GetPoductById(int ID);
    }
}
