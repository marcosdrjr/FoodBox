using System;
using System.Collections.Generic;
using System.Text;

namespace FoodBoxLibrary.Models.DTOS
{
    public class ProducSnacksDTO
    {
        public int id_product_snacks { get; set; }
        public int id_snacks { get; set; }
        public int id_product { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime create_at { get; set; }
        public DateTime update_at { get; set; }
        public bool status { get; set; }

    }
}
