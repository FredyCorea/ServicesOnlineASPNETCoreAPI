using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ServicesOnLineAPI.Models.DataTransferObject;


namespace ServicesOnLineAPI.Models.DataManager
{
     public class AddressDataManager : IDataRepository<Address, AddressDto>
     {

          private readonly DataAccessContext DbContext;

          //Constructor
          public AddressDataManager(DataAccessContext dataAccess)
          {
               DbContext = dataAccess;
          }

          //Interface implementation 
          void IDataRepository<Address, AddressDto>.Add(Address entity)
          {
               throw new NotImplementedException();
          }

          //Interface implementation 
          void IDataRepository<Address, AddressDto>.Delete(Address entity)
          {
               throw new NotImplementedException();
          }


          Address IDataRepository<Address, AddressDto>.Get(long id)
          {
               throw new NotImplementedException();
          }

          IEnumerable<Address> IDataRepository<Address, AddressDto>.GetAll()
          {
               //return DbContext.Addresses.ToList();
               //var addressList = DbContext.Addresses.Include(p => p.State).ToList();
               var addressList = DbContext.Addresses.Include(p => p.State).Include(p =>p.Nation).ToList();
               return addressList;
          }

          AddressDto IDataRepository<Address, AddressDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          IEnumerable<Address> IDataRepository<Address, AddressDto>.GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<Address, AddressDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }

          void IDataRepository<Address, AddressDto>.Update(Address entityToUpdate, Address entity)
          {
               throw new NotImplementedException();
          }
     }

}
