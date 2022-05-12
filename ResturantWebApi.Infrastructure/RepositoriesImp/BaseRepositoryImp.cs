using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace ResturantWebApi.Infrastructure.RepositoriesImp
{
    public class BaseRepositoryImp<T> : IBaseRepository<T> where T : class
    {
        protected ApplicationDbContext _db { get; set; }

        public BaseRepositoryImp(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            _db.SaveChanges();
            return entity;
        }

        public async Task<T> DeleteByIdAsync(Guid id)
        {
            var TT = await _db.Set<T>().FindAsync(id);

            _db.Remove(TT);
            _db.SaveChanges();
            return TT;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public async Task<T> UpdateById(Guid id)
        {
            var TT = await GetByIdAsync(id);

            _db.Update(TT);
            _db.SaveChanges();

            return TT;
        }

        public async Task<T> DeleteByNameAsync(string Name)
        {
            var TT = await _db.Set<T>().SingleOrDefaultAsync<T>(n => n.Equals(Name));

            _db.Set<T>().Remove(TT);

            _db.SaveChanges();

            return TT;

        }

        public async Task<T> FindAnyAsync(Expression<Func<T, bool>> match, string[] includesFKdata = null)
        {
            IQueryable<T> query = _db.Set<T>();

            if(includesFKdata != null)
            {
                foreach(var includeFK in includesFKdata)
                {
                    query = query.Include(includeFK);
                }
            }

            return await query.SingleOrDefaultAsync(match);
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> match, string[] includesFKdata = null)
        {
            IQueryable<T> query = _db.Set<T>();

            if(includesFKdata != null)
            {
                foreach(var includeFK in includesFKdata)
                {
                    query = query.Include(includeFK);
                }
            }

            return await query.Where(match).ToListAsync();


        }

        Task<T> IBaseRepository<T>.FindAllAsync(Expression<Func<T, bool>> match, string[] includesFKdata)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll(Expression<Func<T, bool>> match, string[] includesFKdata = null, Expression<Func<T, object>> orderBy = null, string orderByDirection = OrderBy.Ascending)
        {
            IQueryable<T> Query = _db.Set<T>().Where(match);

            if(orderBy != null)
            {
                if(orderByDirection == OrderBy.Ascending)
                {
                    Query = Query.OrderByDescending(orderBy);
                }
                else
                {
                    Query = Query.OrderByDescending(orderBy);
                }
            }


            return Query.ToList(); 

        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }
    }
}
