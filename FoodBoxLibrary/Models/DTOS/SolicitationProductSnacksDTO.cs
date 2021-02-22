using System;
using System.Collections.Generic;
using System.Text;

namespace FoodBoxLibrary.Models.DTOS
{
    public class SolicitationProductSnacksDTO
    {
        public int code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double calculation { get; set; }
        public List<ProductSnacksDTO> ProductSnacks { get; set; }

        public SolicitationProductSnacksDTO(string name, string description, double calculation, List<ProductSnacksDTO> productSnacks)
        {
            this.name = name;
            this.description = description;
            this.calculation = calculation;
            ProductSnacks = productSnacks;
        }
    }
}
