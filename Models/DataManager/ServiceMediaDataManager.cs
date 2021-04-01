using ServicesOnLineAPI.Models.DTO;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class ServiceMediaDataManager : IDataRepository<ServiceMedia, ServiceMediaDto>
     {
          //references to inject
          private readonly DataAccessContext DbContext;

          //constructor and injection
          public ServiceMediaDataManager(DataAccessContext dDbContext)
          {
               DbContext = dDbContext;
          }

          //IDataRepository implenetation to manupulate data

          IEnumerable<ServiceMedia> IDataRepository<ServiceMedia, ServiceMediaDto>.GetAll()
          {
               return DbContext.ServiceMedia.ToList();
          }

          void IDataRepository<ServiceMedia, ServiceMediaDto>.Add(ServiceMedia entity)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<ServiceMedia, ServiceMediaDto>.Delete(ServiceMedia entity)
          {
               throw new NotImplementedException();
          }

          ServiceMedia IDataRepository<ServiceMedia, ServiceMediaDto>.Get(long id)
          {
               throw new NotImplementedException();
          }

          ServiceMediaDto IDataRepository<ServiceMedia, ServiceMediaDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<ServiceMedia, ServiceMediaDto>.Update(ServiceMedia entityToUpdate, ServiceMedia entity)
          {
               throw new NotImplementedException();
          }

          IEnumerable<ServiceMedia> IDataRepository<ServiceMedia, ServiceMediaDto>.GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<ServiceMedia, ServiceMediaDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }
     }
}
