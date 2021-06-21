using Microsoft.EntityFrameworkCore;
using ServicesOnLineAPI.Models.DataTransferObject;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class ShoppingCartDataManager : IDataRepository<ShoppingCart, ShoppingCartDto>
     {
          //references to be injected
          private readonly DataAccessContext DbContext;

          //constructor and class injection
          public ShoppingCartDataManager(DataAccessContext dbContext)
          {
               DbContext = dbContext;
          }


          //Interface implementate for data manipulation
          IEnumerable<ShoppingCart> IDataRepository<ShoppingCart, ShoppingCartDto>.GetAll()
          {
               //decode the most importante navigation properties
               var sc = DbContext.ShoppingCarts
                    .Include(e => e.Entity)
                    .Include(p => p.PriceList)
                    .Include(s => s.Service)
                    .Include(s => s.State);

               if (sc == null)
               {
                    return null;
               }

               
               return sc.ToList();
          }

          IEnumerable<ShoppingCart> IDataRepository<ShoppingCart, ShoppingCartDto>.GetFilteredList(long id)
          {
               var sc = DbContext.ShoppingCarts
                    .Include(e => e.Entity).Where(w => w.Entity.PersonId == id || w.Entity.LocationId == id)
                    .Include(p => p.PriceList)
                    .Include(s => s.Service)
                    .Include(s => s.State)
                    .ToList();

               if (sc == null)
               {
                    return null;
               }

               return sc.ToList();
          }



          //  var personsListWithRoles = _DataAccessContext.Persons.SingleOrDefault(b => b.PersonId == id);
          //  return personsListWithRoles;
          ShoppingCart IDataRepository<ShoppingCart, ShoppingCartDto>.Get(long id)
          {
               //SingleOrDefault enters into error if the result has more than one row:
               //======================================================================
               //var sc = DbContext.ShoppingCarts
               //   .Include(e => e.Entity)
               //   .Include(p => p.PriceList)
               //   .Include(s => s.Service)
               //   .Include(s => s.State)
               //   .SingleOrDefault(e => e.Entity.PersonId == id || e.Entity.LocationId == id);

               //This produces an anomallous list with two repead records
               var sc = DbContext.ShoppingCarts
                 .Include(e => e.Entity)
                 .Include(p => p.PriceList)
                 .Include(s => s.Service)
                 .Include(s => s.State)
                 .FirstOrDefault(e => e.Entity.PersonId == id || e.Entity.LocationId == id);

               return sc;
          }


          ShoppingCartDto IDataRepository<ShoppingCart, ShoppingCartDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }


          void IDataRepository<ShoppingCart, ShoppingCartDto>.Add(ShoppingCart entity)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<ShoppingCart, ShoppingCartDto>.Delete(ShoppingCart entity)
          {
               throw new NotImplementedException();
          }


          void IDataRepository<ShoppingCart, ShoppingCartDto>.Update(ShoppingCart entityToUpdate, ShoppingCart entity)
          {
               throw new NotImplementedException();
          }

          public IEnumerable<ShoppingCart> GetFilteredList()
          {
               throw new NotImplementedException();
          }
     }
}
