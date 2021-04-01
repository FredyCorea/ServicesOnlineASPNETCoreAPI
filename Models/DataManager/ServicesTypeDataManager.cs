using ServicesOnLineAPI.Models.DTO;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class ServicesTypeDataManager : IDataRepository<ServicesType, ServicesTypeDto>
     {
          private readonly DataAccessContext DbContext;

          public ServicesTypeDataManager(DataAccessContext dbContex)
          {
               DbContext = dbContex;
          }

          IEnumerable<ServicesType> IDataRepository<ServicesType, ServicesTypeDto>.GetAll()
          {
               var st = DbContext.ServicesTypes.ToList();
               return st;
          }

          void IDataRepository<ServicesType, ServicesTypeDto>.Add(ServicesType entity)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<ServicesType, ServicesTypeDto>.Delete(ServicesType entity)
          {
               throw new NotImplementedException();
          }

          ServicesType IDataRepository<ServicesType, ServicesTypeDto>.Get(long id)
          {
               throw new NotImplementedException();
          }

          ServicesTypeDto IDataRepository<ServicesType, ServicesTypeDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<ServicesType, ServicesTypeDto>.Update(ServicesType entityToUpdate, ServicesType entity)
          {
               throw new NotImplementedException();
          }

          IEnumerable<ServicesType> IDataRepository<ServicesType, ServicesTypeDto>.GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<ServicesType, ServicesTypeDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }
     }
}
