using Microsoft.EntityFrameworkCore;
using ServicesOnLineAPI.Models.DTO;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class ServiceDataManager : IDataRepository<Service, ServiceDto>
     {
          private readonly DataAccessContext _DataAccessContext;

          public ServiceDataManager(DataAccessContext DataAccessContext)
          {
               _DataAccessContext = DataAccessContext;
          }

          //Manipulate data
          IEnumerable<Service> IDataRepository<Service, ServiceDto>.GetAll()
          {
               //simple list 
               //var services = _DataAccessContext.Services.ToList();

               //list with regions
               //var services = _DataAccessContext.Services.Include(r => r.Region);

               //list with regions, city
               //var services = _DataAccessContext.Services.Include(r => r.Region).Include(c=>c.City);

               //list with regions, city, service tupe
               //var services = _DataAccessContext.Services.Include(r => r.Region).Include(c => c.City).Include(st=>st.ServType);

               //list with regions, city, service type, uom
               //var services = _DataAccessContext.Services.Include(r => r.Region)
               //     .Include(c => c.City)
               //     .Include(st => st.ServType)
               //     .Include(um=> um.UnitOfMeasure);

               //list with regions, city, service type, uom, prices list
               //var services = _DataAccessContext.Services.Include(r => r.Region)
               //     .Include(c => c.City)
               //     .Include(st => st.ServType)
               //     .Include(um => um.UnitOfMeasure)
               //     .Include(pl => pl.PriceLists);

               //list with regions, city, service type, uom, prices list, schedule
               //var services = _DataAccessContext.Services.Include(r => r.Region)
               //     .Include(c => c.City)
               //     .Include(st => st.ServType)
               //     .Include(um => um.UnitOfMeasure)
               //     .Include(pl => pl.PriceLists)
               //     .Include(sc=>sc.ServiceScheds);

               //list with regions, city, service type, uom, prices list, schedule, promotions list
               //var services = _DataAccessContext.Services.Include(r => r.Region)
               //     .Include(c => c.City)
               //     .Include(st => st.ServType)
               //     .Include(um => um.UnitOfMeasure)
               //     .Include(pl => pl.PriceLists)
               //     .Include(sc => sc.ServiceScheds)
               //     .Include(p=> p.Promotions);

               //list with regions, city, service type, uom, prices list, schedule, promotions list, media
               var services = _DataAccessContext.Services.Include(r => r.Region)
                   .Include(c => c.City)
                   .Include(st => st.ServType)
                   .Include(um => um.UnitOfMeasure)
                   .Include(pl => pl.PriceLists)
                   .Include(sc => sc.ServiceScheds)
                   .Include(p => p.Promotions)
                   .Include(m=> m.ServiceMedia);

               return services;
          }

          void IDataRepository<Service, ServiceDto>.Add(Service entity)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<Service, ServiceDto>.Delete(Service entity)
          {
               throw new NotImplementedException();
          }

          Service IDataRepository<Service, ServiceDto>.Get(long id)
          {
               throw new NotImplementedException();
          }

          ServiceDto IDataRepository<Service, ServiceDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<Service, ServiceDto>.Update(Service entityToUpdate, Service entity)
          {
               throw new NotImplementedException();
          }

          IEnumerable<Service> IDataRepository<Service, ServiceDto>.GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<Service, ServiceDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }
     }
}
