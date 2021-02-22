using FoodBoxLibrary.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBoxWebApi.Business.Intefaces
{
   public interface IPoductServices
    {
        Task<List<ProductDTO>> GetPoduct();
        Task<ProductDTO> GetPoductById(int ID);
    }
}
