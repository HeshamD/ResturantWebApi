using ResturantWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantWebApi.Services.IServices
{
    public interface IProductServices
    {
        public void CreateAndUpdateProduct(ProductDto productDto, Guid? id);
    }
}
