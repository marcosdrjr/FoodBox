using System;
using System.Collections.Generic;
using System.Text;

namespace FoodBoxLibrary.Models.DTOS
{
    public class ProductSnacksDTO : ProductDTO
    {
        public int QtdPoduct { get; set; }

        public ProductSnacksDTO(int qtdPoduct ,ProductDTO poduct)
        {
            QtdPoduct = qtdPoduct;
            this.name = poduct.name;
            this.id_product = poduct.id_product;
            this.description = poduct.description;
            this.value = poduct.value;
            this.expiration_date = poduct.expiration_date;
        }
    }
}
