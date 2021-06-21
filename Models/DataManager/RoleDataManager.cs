using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServicesOnLineAPI.Models.DataTransferObject;
using ServicesOnLineAPI.Models.Repository;

namespace ServicesOnLineAPI.Models.DataManager
{
     public class RoleDataManager : IDataRepository<Role, RoleDto>
     {
          readonly DataAccessContext _DataAccessContext;

          public RoleDataManager(DataAccessContext DataAccessContext)
          {
               _DataAccessContext = DataAccessContext;
          }

          IEnumerable<Role> IDataRepository<Role, RoleDto>.GetAll()
          {
               var rolesList = _DataAccessContext.Roles;
               return rolesList.OrderBy(r => r.RoleName).ToList();
          }

          void IDataRepository<Role, RoleDto>.Add(Role entity)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<Role, RoleDto>.Delete(Role entity)
          {
               throw new NotImplementedException();
          }

          Role IDataRepository<Role, RoleDto>.Get(long id)
          {
               throw new NotImplementedException();
          }



          RoleDto IDataRepository<Role, RoleDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<Role, RoleDto>.Update(Role entityToUpdate, Role entity)
          {
               throw new NotImplementedException();
          }

          public IEnumerable<Role> GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<Role, RoleDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }
     }
}
