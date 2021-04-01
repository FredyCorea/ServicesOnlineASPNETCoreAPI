using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.Repository
{
     public interface IDataRepository<TEntity, TDto>
     {
          IEnumerable<TEntity> GetAll();
          IEnumerable<TEntity> GetFilteredList();
          TEntity Get(long id);
          TDto GetDto(long id);
          void Add(TEntity entity);
          void Update(TEntity entityToUpdate, TEntity entity);
          void Delete(TEntity entity);
          IEnumerable<ShoppingCart> GetFilteredList(long id);
     }
}
