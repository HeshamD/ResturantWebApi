


using ResturantWebApi.Infrastructure;
using ResturantWebApi.Services.IServices;

namespace ResturantWebApi.Services
{
    public class BaseServicesImp<T>:IBaseServices<T> where T : class
    {

        private readonly IBaseRepository<T> repository;

        protected ApplicationDbContext _db { get; set; }

        public BaseServicesImp(IBaseRepository<T> _repository, ApplicationDbContext db)
        {
                repository = _repository;
                _db = db;
        }

        public void CreateAndUpdate<T1>(ref T1 Dto, ref T1 Entity) where T1 : class
        {
            throw new NotImplementedException();
        }
    }
}
