


namespace ResturantWebApi.Services
{
    public class ProductServices
    {

        private readonly IBaseRepository<ProductDto> _IbaseRepository;

        public ProductServices(IBaseRepository<ProductDto> baseRepository)
        {
            _IbaseRepository = baseRepository;
        }

        //make the creation function

    }
}
