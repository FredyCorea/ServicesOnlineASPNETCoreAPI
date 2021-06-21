using Microsoft.EntityFrameworkCore;
using ServicesOnLineAPI.Models.DataTransferObject;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class PersonsRoleDataManager : IDataRepository<PersonsRole, PersonsRoleDto>
     {
          readonly DataAccessContext DataAccessContext;
          public PersonsRoleDataManager(DataAccessContext dataAccessContext)
          {
               DataAccessContext = dataAccessContext;
          }

          IEnumerable<PersonsRole> IDataRepository<PersonsRole, PersonsRoleDto>.GetAll()
          {
               //return _DataAccessContext.PersonsRoles.ToList();
               //includes the Role navigation property
               var prsonRoleWithRole = DataAccessContext.PersonsRoles.Include(p => p.Role).ToList();
               return prsonRoleWithRole;
          }
          void IDataRepository<PersonsRole, PersonsRoleDto>.Add(PersonsRole entity)
          {
               DataAccessContext.PersonsRoles.Add(entity);
               DataAccessContext.SaveChanges();
          }

          void IDataRepository<PersonsRole, PersonsRoleDto>.Delete(PersonsRole entity)
          {
               try
               {
                    DataAccessContext.PersonsRoles.Remove(entity);
                    DataAccessContext.SaveChanges();
               }
               catch (Exception e){
                    throw new Exception();
               }

          }

          PersonsRole IDataRepository<PersonsRole, PersonsRoleDto>.Get(long id)
          {
               return DataAccessContext.PersonsRoles.SingleOrDefault(pr => pr.PersonId == id);
          }

          PersonsRoleDto IDataRepository<PersonsRole, PersonsRoleDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<PersonsRole, PersonsRoleDto>.Update(PersonsRole entityToUpdate, PersonsRole entity)
          {

               throw new NotImplementedException();
          }

          public IEnumerable<PersonsRole> GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<PersonsRole, PersonsRoleDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }
     }
}
