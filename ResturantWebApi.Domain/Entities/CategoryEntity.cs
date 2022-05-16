using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantWebApi.Domain.Entities
{
    public class CategoryEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        //public List<ProductEntity>? ProductEntities { get; set; }

    }
}
