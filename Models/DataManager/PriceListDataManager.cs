using ServicesOnLineAPI.Models.DTO;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class PriceListDataManager : IDataRepository<PriceList, PriceListDto>
     {

          //inject
          private readonly DataAccessContext DbContext;


          //construcct
          public PriceListDataManager(DataAccessContext DataAccessContext)
          {
               DbContext = DataAccessContext;
          }

          //get data
          IEnumerable<PriceList> IDataRepository<PriceList, PriceListDto>.GetAll()
          {
               var pl = DbContext.PriceLists.ToList();
               return pl;
          }

          void IDataRepository<PriceList, PriceListDto>.Add(PriceList entity)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<PriceList, PriceListDto>.Delete(PriceList entity)
          {
               throw new NotImplementedException();
          }

          PriceList IDataRepository<PriceList, PriceListDto>.Get(long id)
          {
               throw new NotImplementedException();
          }

          PriceListDto IDataRepository<PriceList, PriceListDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<PriceList, PriceListDto>.Update(PriceList entityToUpdate, PriceList entity)
          {
               throw new NotImplementedException();
          }

          IEnumerable<PriceList> IDataRepository<PriceList, PriceListDto>.GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<PriceList, PriceListDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }
     }
}
