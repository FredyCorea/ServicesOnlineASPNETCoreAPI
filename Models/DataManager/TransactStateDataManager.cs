using ServicesOnLineAPI.Models.DTO;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class TransactStateDataManager : IDataRepository<TransactState, TransactStateDto>
     {
          //references to dependencies for injection
          private readonly DataAccessContext DbContext;

          //constructor and injection
          public TransactStateDataManager(DataAccessContext dbContext)
          {
               DbContext = dbContext;
          }

          //interface implementation and data manipulation

          IEnumerable<TransactState> IDataRepository<TransactState, TransactStateDto>.GetAll()
          {
               return DbContext.TransactStates;
          }
          void IDataRepository<TransactState, TransactStateDto>.Add(TransactState entity)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<TransactState, TransactStateDto>.Delete(TransactState entity)
          {
               throw new NotImplementedException();
          }

          TransactState IDataRepository<TransactState, TransactStateDto>.Get(long id)
          {
               throw new NotImplementedException();
          }

          TransactStateDto IDataRepository<TransactState, TransactStateDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<TransactState, TransactStateDto>.Update(TransactState entityToUpdate, TransactState entity)
          {
               throw new NotImplementedException();
          }

          IEnumerable<TransactState> IDataRepository<TransactState, TransactStateDto>.GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<TransactState, TransactStateDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }
     }
}
