


namespace ResturantWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IBaseRepository<ProductDto> _ProductRepository;

        public ProductsController (IBaseRepository<ProductDto> ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }

        [HttpGet("GetAllProductsAsync")]
        public async Task<IActionResult> GetAllProductsAsync()
        {
            return Ok(await _ProductRepository.GetAllAsync());
        }

        [HttpGet("GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            return Ok(_ProductRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            return Ok(await _ProductRepository.GetByIdAsync(id));
        }

        [HttpGet("GetByName")]
        public async Task<IActionResult> GetByName(string name)
        {
            var Product = await _ProductRepository.FindAnyAsync(p=>p.ProductName == name);
            return Ok(Product);
        }

        
       

        //[HttpGet("GetProductsWithPrices")]
        //public async Task<IActionResult> GetProductsWithPrices()
        //{
        //    var productsList = await _ProductRepository.GetAllAsync();

        //    var ProductsName = string.Empty;
        //    var ProductsPrices = string.Empty;

        //    foreach(var productName in productsList)
        //    {
        //        ProductsName = productName.ProductName;

        //        foreach(var productPrice in productsList)
        //        {
        //            ProductsPrices = Convert.ToString(productPrice.ProductSalePrice);
        //        }

        //    }

        //    return Ok(ProductsName+ProductsPrices);


        //}



        [HttpPost("{id}")]
        public async Task<IActionResult> CreateOrUpdateProduct(Guid? id,ProductDto productDto)
        {
            if(id == null)
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest("Check your input!");
                }

                

            }

        }



        //?GET All by Category
    }
}
