using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantWebApi.Infrastructure
{
    public class ProductFluentApi : IEntityTypeConfiguration<ProductDto>
    {

        public void Configure(EntityTypeBuilder<ProductDto> builder)
        {
            builder.HasOne<CategoryDto>().WithMany().HasForeignKey(p=>p.CategoryIdFK);
        }


    }
}
