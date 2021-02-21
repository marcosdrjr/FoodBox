using System;
using System.Collections.Generic;
using System.Text;

namespace FoodBoxLibrary.Models.DTOS
{
    public class SolicitationFoodDTO
    {
        public int id_solicitation_food { get; set; }
        public int id_snacks { get; set; }
        public int id_status_solicitation { get; set; }
        public double value { get; set; }
        //public DateTime create_at { get; set; }
        //public DateTime update_at { get; set; }
        //public bool status { get; set; }
    }
}
