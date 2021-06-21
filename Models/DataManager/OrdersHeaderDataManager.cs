using Microsoft.EntityFrameworkCore;
using ServicesOnLineAPI.Models.DataTransferObject;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class OrdersHeaderDataManager : IDataRepository<OrdersHeader, OrdersHeaderDto>
     {
          //references to dependencies for injection
          private readonly DataAccessContext DbContext;

          //constructor and dependency injection
          public OrdersHeaderDataManager(DataAccessContext dataAccess)
          {
               DbContext = dataAccess;
          }

          //interface implementation for data manipulation
          IEnumerable<OrdersHeader> IDataRepository<OrdersHeader, OrdersHeaderDto>.GetAll()
          {
               //return DbContext.OrdersHeaders.ToList();
               var oh = DbContext.OrdersHeaders
                    .Include(e => e.Entity)
                    .Include(e => e.State)
                    .Include(e => e.Orders).ThenInclude(o => o.Service)
                    .Include(e => e.Cctransactions)
                    .Include(e => e.PaymentHist).ThenInclude(ph => ph.PaymntState);

               return oh;
          }

          void IDataRepository<OrdersHeader, OrdersHeaderDto>.Add(OrdersHeader entity)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<OrdersHeader, OrdersHeaderDto>.Delete(OrdersHeader entity)
          {
               throw new NotImplementedException();
          }

          OrdersHeader IDataRepository<OrdersHeader, OrdersHeaderDto>.Get(long id)
          {
               return DbContext.OrdersHeaders.Include(o => o.Entity).SingleOrDefault(o => o.Entity.PersonId == id);
          }


          OrdersHeaderDto IDataRepository<OrdersHeader, OrdersHeaderDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          IEnumerable<OrdersHeader> IDataRepository<OrdersHeader, OrdersHeaderDto>.GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<OrdersHeader, OrdersHeaderDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<OrdersHeader, OrdersHeaderDto>.Update(OrdersHeader entityToUpdate, OrdersHeader entity)
          {
               throw new NotImplementedException();
          }
     }
}
