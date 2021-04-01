using ServicesOnLineAPI.Models.DTO;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class UnitOfMeasureDataManager : IDataRepository<UnitOfMeasure, UnitOfMeasureDto>
     {
          //inject
          private readonly DataAccessContext DbContext;

          //construct
          public UnitOfMeasureDataManager(DataAccessContext dbContext)
          {
               DbContext = dbContext;
          }
          IEnumerable<UnitOfMeasure> IDataRepository<UnitOfMeasure, UnitOfMeasureDto>.GetAll()
          {
               var uom = DbContext.UnitOfMeasures.ToList();
               return uom;
          }
          void IDataRepository<UnitOfMeasure, UnitOfMeasureDto>.Add(UnitOfMeasure entity)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<UnitOfMeasure, UnitOfMeasureDto>.Delete(UnitOfMeasure entity)
          {
               throw new NotImplementedException();
          }

          UnitOfMeasure IDataRepository<UnitOfMeasure, UnitOfMeasureDto>.Get(long id)
          {
               throw new NotImplementedException();
          }

          UnitOfMeasureDto IDataRepository<UnitOfMeasure, UnitOfMeasureDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<UnitOfMeasure, UnitOfMeasureDto>.Update(UnitOfMeasure entityToUpdate, UnitOfMeasure entity)
          {
               throw new NotImplementedException();
          }

          IEnumerable<UnitOfMeasure> IDataRepository<UnitOfMeasure, UnitOfMeasureDto>.GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<UnitOfMeasure, UnitOfMeasureDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }

          //construct


     }
}
