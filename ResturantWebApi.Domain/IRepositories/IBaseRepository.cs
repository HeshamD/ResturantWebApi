

namespace ResturantWebApi.Domain.IRepositories
{
    public interface IBaseRepository<T> where T: class
    {
        public Task<T> GetByIdAsync(Guid id);
        public Task<T> GetByIdAsync(Guid? id);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> DeleteByIdAsync(Guid id);
        public Task<T> UpdateByIdAsync(Guid id);
        public Task<T> AddAsync(T entity);
        public Task<T> FindAnyAsync(Expression<Func<T, bool>> match, string[] includesFKdata = null);
        public IEnumerable<T> FindAll(Expression<Func<T, bool>> match, string[] includesFKdata = null, Expression<Func<T,object>> OrderBy=null,string orderByDirection = OrderBy.Ascending);
        public IEnumerable<T> GetAll();
        public T Add(T entity);
        public IEnumerable<T> BulkAdd(IEnumerable<T> entities);
        public T Update(T entity);
        public T FindIdWithIncludeData(Guid? id, string[] includesFKdata = null);
        public Task<T> GetByName(string name);
    }
}
