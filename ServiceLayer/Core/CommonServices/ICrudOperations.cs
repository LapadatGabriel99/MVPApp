using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Core.CommonServices
{
    public interface ICrudOperations<T> where T: class
    {
        void Add(T model);
        void Add(IEnumerable<T> rangeOfModels);

        void Remove(T model);
        void Remove(IEnumerable<T> rangeOfModels);

        T Get(int id);
        IEnumerable<T> GetAll();

        void Update();

        void Complete();
    }
}
