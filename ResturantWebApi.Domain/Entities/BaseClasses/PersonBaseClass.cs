using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantWebApi.Domain.Entities.BaseClasses
{
    public class PersonBaseClass
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string? email { get; set; } = string.Empty;
        public string? StreetAddress { get; set; }= string.Empty;
        public string? ZipCode { get; set; }=string.Empty;
        public string? State { get; set; }=string.Empty;
        public string? Phone { get; set; } = string.Empty;


    }
}
