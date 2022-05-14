using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantWebApi.Services.IServices
{
    public interface IBaseServices<T> where T : class
    {
        public void CreateAndUpdate<T>(ref T Dto, ref T Entity) where T : class;
    }
}
