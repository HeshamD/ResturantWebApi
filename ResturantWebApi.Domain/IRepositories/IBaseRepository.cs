

namespace ResturantWebApi.Domain.IRepositories
{
    public interface IBaseRepository<T> where T: class
    {
        public Task<T> GetByIdAsync(Guid id);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> DeleteByIdAsync(Guid id);
        public Task<T> UpdateById(Guid id);
        public Task<T> AddAsync(T entity);
        public Task<T> FindAnyAsync(Expression<Func<T, bool>> match, string[] includesFKdata = null);
        public Task<T> FindAllAsync(Expression<Func<T, bool>> match, string[] includesFKdata = null);
        public IEnumerable<T> FindAll(Expression<Func<T, bool>> match, string[] includesFKdata = null, Expression<Func<T,object>> OrderBy=null,string orderByDirection = OrderBy.Ascending);

        public IEnumerable<T> GetAll();

    }
}
