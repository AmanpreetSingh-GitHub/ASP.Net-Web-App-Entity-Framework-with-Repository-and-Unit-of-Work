using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkOne.Repository.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}