using System;
using System.Collections.Generic;
using System.Text;

namespace FoodBoxLibrary.Models.DTOS
{
    public class RequestsSolicitationDTO
    {
        public string codes { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public RequestsSolicitationDTO()
        {
        }

        public RequestsSolicitationDTO(string codes, string name, string description)
        {
            this.codes = codes;
            this.name = name;
            this.description = description;
        }
    }
}
