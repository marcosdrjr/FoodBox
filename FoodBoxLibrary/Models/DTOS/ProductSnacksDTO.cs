using System;
using System.Collections.Generic;
using System.Text;

namespace FoodBoxLibrary.Models.DTOS
{
    public class ProductSnacksDTO : ProductDTO
    {
        public int qtdProduct { get; set; }

        public ProductSnacksDTO()
        {
        }
        public ProductSnacksDTO(int qtdProduct ,ProductDTO product)
        {
            this.qtdProduct = qtdProduct;
            this.name = product.name;
            this.id_product = product.id_product;
            this.description = product.description;
            this.value = product.value;
            this.expiration_date = product.expiration_date;
        }
    }
}
