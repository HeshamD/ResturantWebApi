

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
                var product = _baseRepository.FindIdWithIncludeData(id);

                product.ProductName = productDto.ProductName;
                product.ProductDescription = productDto.ProductDescription;
                product.ReOrderPoint = productDto.ReOrderPoint;
                product.SKU = productDto.SKU; 
                product.ProductSalePrice = productDto.ProductSalePrice;
                product.CategoryIdFK = productDto.CategoryIdFK;
                product.ProductCostPrice = productDto.ProductCostPrice;
                product.ProductQTY = productDto.ProductQTY;

                _baseRepository.Update(product);

            }


        }

        public void DeleteProduct(Guid productId)
        {
            _baseRepository.DeleteByIdAsync(productId);
        }

        public IEnumerable<ProductEntity> GetAll()
        {
            return _baseRepository.GetAll();
        }

        public async Task<ProductEntity> GetById(Guid? id)
        {
            return await _baseRepository.GetByIdAsync(id);
        }

        public async Task<ProductEntity> GetByName(string name)
        {
            return await _baseRepository.GetByName(name);
        }
    }
}
