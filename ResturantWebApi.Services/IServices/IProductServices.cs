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
        public void DeleteProduct(Guid productId);
        public IEnumerable<ProductEntity> GetAll();
        public Task<ProductEntity> GetByName(string name);
        public Task<ProductEntity> GetById(Guid? id);
    }
}
