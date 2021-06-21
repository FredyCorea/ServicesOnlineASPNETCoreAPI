using ServicesOnLineAPI.Models.DataTransferObject;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class PromotionDataManager : IDataRepository<Promotion, PromotionDto>
     {

          //references to inject
          private readonly DataAccessContext DbContext;

          //injection
          public PromotionDataManager(DataAccessContext dbContext)
          {
               DbContext = dbContext;
          }

          //interface implemntation to maniulate data
          IEnumerable<Promotion> IDataRepository<Promotion, PromotionDto>.GetAll()
          {
               return DbContext.Promotions.ToList();
          }

          void IDataRepository<Promotion, PromotionDto>.Add(Promotion entity)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<Promotion, PromotionDto>.Delete(Promotion entity)
          {
               throw new NotImplementedException();
          }

          Promotion IDataRepository<Promotion, PromotionDto>.Get(long id)
          {
               throw new NotImplementedException();
          }

         

          PromotionDto IDataRepository<Promotion, PromotionDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<Promotion, PromotionDto>.Update(Promotion entityToUpdate, Promotion entity)
          {
               throw new NotImplementedException();
          }

          IEnumerable<Promotion> IDataRepository<Promotion, PromotionDto>.GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<Promotion, PromotionDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }
     }
}
