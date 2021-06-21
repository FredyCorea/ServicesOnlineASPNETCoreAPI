using ServicesOnLineAPI.Models.DataTransferObject;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class ServiceSchedDataManager : IDataRepository<ServiceSched, ServiceSchedDto>
     {

          //inject
          private readonly DataAccessContext DbContext;

          //construct
          public ServiceSchedDataManager(DataAccessContext dbContext)
          {
               DbContext = dbContext;
          }

          //get data
          IEnumerable<ServiceSched> IDataRepository<ServiceSched, ServiceSchedDto>.GetAll()
          {
               //var sched = DbContext.ServiceScheds.ToList();
               //return sched;

               return DbContext.ServiceScheds.ToList();
          }

          void IDataRepository<ServiceSched, ServiceSchedDto>.Add(ServiceSched entity)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<ServiceSched, ServiceSchedDto>.Delete(ServiceSched entity)
          {
               throw new NotImplementedException();
          }

          ServiceSched IDataRepository<ServiceSched, ServiceSchedDto>.Get(long id)
          {
               throw new NotImplementedException();
          }

          ServiceSchedDto IDataRepository<ServiceSched, ServiceSchedDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<ServiceSched, ServiceSchedDto>.Update(ServiceSched entityToUpdate, ServiceSched entity)
          {
               throw new NotImplementedException();
          }

          public IEnumerable<ServiceSched> GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<ServiceSched, ServiceSchedDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }
     }
}
