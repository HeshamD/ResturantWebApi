using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantWebApi.Domain.Entities
{
    public class ProductEntity
    {
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? SKU { get; set; }
        public int? ProductQTY { get; set; }
        public int? ReOrderPoint { get; set; }
        public double? ProductSalePrice { get; set; }
        public double? ProductCostPrice { get; set; }
        public Guid CategoryIdFK { get; set; }

        //public CategoryEntity Category { get; set; }
        //img


    }
}
