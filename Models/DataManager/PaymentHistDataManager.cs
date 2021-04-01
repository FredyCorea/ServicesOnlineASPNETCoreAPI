using Microsoft.EntityFrameworkCore;
using ServicesOnLineAPI.Models.DTO;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class PaymentHistDataManager : IDataRepository<PaymentHist, PaymentHistDto>
     {

          //references to dependencies for injection
          private readonly DataAccessContext DbContext;

          //constructor and dependency injection
          public PaymentHistDataManager(DataAccessContext dataAccess)
          {
               DbContext = dataAccess;
          }

          //Interface implementation

          IEnumerable<PaymentHist> IDataRepository<PaymentHist, PaymentHistDto>.GetAll()
          {
               var ph = DbContext.PaymentHist.Include(ph => ph.PaymntState);
               return ph;
          }
          void IDataRepository<PaymentHist, PaymentHistDto>.Add(PaymentHist entity)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<PaymentHist, PaymentHistDto>.Delete(PaymentHist entity)
          {
               throw new NotImplementedException();
          }

          PaymentHist IDataRepository<PaymentHist, PaymentHistDto>.Get(long id)
          {
               throw new NotImplementedException();
          }



          PaymentHistDto IDataRepository<PaymentHist, PaymentHistDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          IEnumerable<PaymentHist> IDataRepository<PaymentHist, PaymentHistDto>.GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<PaymentHist, PaymentHistDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<PaymentHist, PaymentHistDto>.Update(PaymentHist entityToUpdate, PaymentHist entity)
          {
               throw new NotImplementedException();
          }
     }
}
