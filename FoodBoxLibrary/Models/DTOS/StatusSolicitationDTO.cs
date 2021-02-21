using System;
using System.Collections.Generic;
using System.Text;

namespace FoodBoxLibrary.Models.DTOS
{
    public class StatusSolicitationDTO
    {
        public int id_status_solicitation { get; set; }
        public string name { get; set; }
        public DateTime create_at { get; set; }
        public DateTime update_at { get; set; }
        public bool status { get; set; }
    }
}
