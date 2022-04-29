using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAP.Application.Interfaces
{
    public interface IGenericRepository<T>
    {
        // Get All entities
        Task<IEnumerable<T>> GetAll();
        // Get By Id
        Task<T> GetById(int id);
        // Add Entity
        Task<bool> Add(T entity);
        // Delete Audited
      
    }
}
