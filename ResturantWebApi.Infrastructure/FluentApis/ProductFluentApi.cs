using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantWebApi.Infrastructure
{
    public class ProductFluentApi : IEntityTypeConfiguration<ProductEntity>
    {

        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.HasOne<CategoryDto>().WithMany().HasForeignKey(p=>p.CategoryIdFK);
        }


    }
}
