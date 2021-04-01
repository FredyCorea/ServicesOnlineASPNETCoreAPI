using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.Repository
{
     public interface IDataRepositoryForUpdates<TEntity, TInput>
     {
          void Update(TEntity entityToUpdate, TInput inputEntity);
     }
}
