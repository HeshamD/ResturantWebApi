using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantWebApi.Services.IServices
{
    public interface IBaseServices<T> where T : class
    {
        public void CreateAndUpdate(T Entity);
        public void Delete(Guid id);
        public IEnumerable<T> GetAll();
        public Task<T> GetByName(string name);


    }
}
