using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantWebApi.Infrastructure.FluentApis
{
    public class CategoryFluentApi : IEntityTypeConfiguration<CategoryDto>
    {
        public void Configure(EntityTypeBuilder<CategoryDto> builder)
        {
            builder.HasData(new { Id = Guid.NewGuid() ,CategoryName = "Fresh Poutlry" });
        }
    }
}
