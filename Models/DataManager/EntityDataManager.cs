using ServicesOnLineAPI.Models.DataTransferObject;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class EntityDataManager : IDataRepository<Entity, EntityDto>
     {

          private readonly DataAccessContext DbContext;

          public EntityDataManager(DataAccessContext DataAccessContext)
          {
               DbContext = DataAccessContext;
          }

          IEnumerable<Entity> IDataRepository<Entity, EntityDto>.GetAll()
          {
               var ent = DbContext.Entity.ToList();
               return ent;
          }
                 
          Entity IDataRepository<Entity, EntityDto>.Get(long id)
          {
               //var results = entityCollection.Where(entity => entity.Property1 == 1 || entity.Property1 == 2 || entity.Property1 == 3);
               
               Entity selectedresult;    //create variable

               var entPerson = DbContext.Entity.SingleOrDefault(e => e.PersonId == id && e.LocationId == null);

               var entLoc = DbContext.Entity.SingleOrDefault(e => e.LocationId == id && e.PersonId == null);

               if (entPerson.PersonId > 0)
               {
                    selectedresult = entPerson;
               }
               else
               {
                    selectedresult = entLoc;
               }

               return selectedresult;
          }

          void IDataRepository<Entity, EntityDto>.Add(Entity entity)
          {
               DbContext.Entity.Add(entity);
               DbContext.SaveChanges();
          }

          void IDataRepository<Entity, EntityDto>.Delete(Entity entity)
          {
               DbContext.Entity.Remove(entity);
               DbContext.SaveChanges();
          }
          EntityDto IDataRepository<Entity, EntityDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<Entity, EntityDto>.Update(Entity entityToUpdate, Entity entity)
          {
               throw new NotImplementedException();
          }

          public IEnumerable<Entity> GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<Entity> IDataRepository<Entity, EntityDto>.GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<Entity, EntityDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }
     }
}
