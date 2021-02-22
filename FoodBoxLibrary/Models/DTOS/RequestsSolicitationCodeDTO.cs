using System;
using System.Collections.Generic;
using System.Text;

namespace FoodBoxLibrary.Models.DTOS
{
   public class RequestsSolicitationCodeDTO
    {
        public string codes { get; set; }

        public RequestsSolicitationCodeDTO()
        {
        }

        public RequestsSolicitationCodeDTO(int codes)
        {
            this.codes = codes.ToString().PadLeft(6, '0');
        }
    }
}
