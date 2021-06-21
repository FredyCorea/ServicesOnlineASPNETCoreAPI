using Microsoft.EntityFrameworkCore;
using ServicesOnLineAPI.Models.DataTransferObject;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class OrderDataManager : IDataRepository<Order, OrderDto>
     {
          //references to dependencies for injection
          private readonly DataAccessContext DbContext;

          //constructor and dependency injection
          public OrderDataManager(DataAccessContext dataAccess)
          {
               DbContext = dataAccess;
          }

          IEnumerable<Order> IDataRepository<Order, OrderDto>.GetAll()
          {
               //var o = DbContext.Orders.ToList();

               var o = DbContext.Orders
                    .Include(o => o.Service)
                    .Include(o => o.State).ToList();

               return o.ToList();
          }
          void IDataRepository<Order, OrderDto>.Add(Order entity)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<Order, OrderDto>.Delete(Order entity)
          {
               throw new NotImplementedException();
          }

          Order IDataRepository<Order, OrderDto>.Get(long id)
          {
               throw new NotImplementedException();
          }

          OrderDto IDataRepository<Order, OrderDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          IEnumerable<Order> IDataRepository<Order, OrderDto>.GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<Order, OrderDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<Order, OrderDto>.Update(Order entityToUpdate, Order entity)
          {
               throw new NotImplementedException();
          }
     }
}
