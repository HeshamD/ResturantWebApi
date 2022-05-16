


using ResturantWebApi.Infrastructure;
using ResturantWebApi.Services.IServices;

namespace ResturantWebApi.Services
{
    public class BaseServicesImp<T>:IBaseServices<T> where T : class
    {

        private readonly IBaseRepository<T> repository;

        public BaseServicesImp(IBaseRepository<T> _repository)
        {
                repository = _repository;
        }

        public void CreateAndUpdate(T Entity)
        {
            //Create

        }

        public void Delete(Guid id)
        {
            
            repository.DeleteByIdAsync(id);
            
        }

        public IEnumerable<T> GetAll()
        {
            return repository.GetAll();
        }

        public async Task<T> GetByName(string name)
        {
            return await repository.GetByName(name);
        }
    }
}
