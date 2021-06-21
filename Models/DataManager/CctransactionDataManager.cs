using ServicesOnLineAPI.Models.Repository;
using ServicesOnLineAPI.Models.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class CctransactionDataManager : IDataRepository<Cctransaction, CctransactionDto>
     {

          //references to dependencies for injection
          private readonly DataAccessContext DbContext;

          //constructor and dependency injection
          public CctransactionDataManager(DataAccessContext dataAccess)
          {
               DbContext = dataAccess;
          }

          //Interface implementation 
          IEnumerable<Cctransaction> IDataRepository<Cctransaction, CctransactionDto>.GetAll()
          {
               return DbContext.Cctransactions.ToList();
          }

          void IDataRepository<Cctransaction, CctransactionDto>.Add(Cctransaction entity)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<Cctransaction, CctransactionDto>.Delete(Cctransaction entity)
          {
               throw new NotImplementedException();
          }

          Cctransaction IDataRepository<Cctransaction, CctransactionDto>.Get(long id)
          {
               throw new NotImplementedException();
          }

          CctransactionDto IDataRepository<Cctransaction, CctransactionDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          IEnumerable<Cctransaction> IDataRepository<Cctransaction, CctransactionDto>.GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<Cctransaction, CctransactionDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<Cctransaction, CctransactionDto>.Update(Cctransaction entityToUpdate, Cctransaction entity)
          {
               throw new NotImplementedException();
          }

          //interface implementation for data manipulation
     }
}
