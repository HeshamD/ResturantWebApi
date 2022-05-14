using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace ResturantWebApi.Services.ServicesImp
{
    public class ProductServicesImp : IProductServices
    {

        private IBaseRepository<ProductEntity> _baseRepository;

        public ProductServicesImp(IBaseRepository<ProductEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public void CreateAndUpdateProduct(ProductDto productDto, Guid? id)
        {

            if(id == null)
            {
                ProductEntity newProduct = new ProductEntity
                {
                    CategoryIdFK = productDto.CategoryIdFK,
                    ProductName = productDto.ProductName,
                    ProductDescription = productDto.ProductDescription,
                    ProductCostPrice = productDto.ProductCostPrice,
                    ProductQTY = productDto.ProductQTY,
                    ProductSalePrice = productDto.ProductSalePrice,
                    ReOrderPoint = productDto.ReOrderPoint,
                    SKU = productDto.SKU,
                };

                _baseRepository.Add(newProduct);

            }
            else
            {
                var product = _baseRepository.


                

            }




        }
    }
}
