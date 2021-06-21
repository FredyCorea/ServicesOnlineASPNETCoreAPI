using Microsoft.EntityFrameworkCore;
using ServicesOnLineAPI.Models.DataTransferObject;
using ServicesOnLineAPI.Models.Inputs;

using ServicesOnLineAPI.Models.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ServicesOnLineAPI.Models.DataManager
{
     public class PersonDataManager :
          IDataRepository<Person, PersonDto>,
          IDataRepositoryForUpdates<Person, PersonInput>
     {

          readonly DataAccessContext DataAccessContext;
          public PersonDataManager(DataAccessContext dataAccessContext)
          {
               DataAccessContext = dataAccessContext;
          }

          IEnumerable<Person> IDataRepository<Person, PersonDto>.GetAll()
          {
               //var personsList = _DataAccessContext.Persons;
               //return personsList.OrderBy(p => p.LastName).ToList();

               //To include navigation property PersonRoles
               //var personsListWithRoles = _DataAccessContext.Persons.Include(p => p.PersonsRoles).ThenInclude(r => r.Role).ToList();

               //Person -> PersonRoles
               //Person -> Entity
               //var personsListWithRoles = _DataAccessContext.Persons.Include(p => p.PersonsRoles).Include(p => p.Entity);

               //Person->PersonRoles->Role
               //Person -> Entity
               var personsListWithRoles = DataAccessContext.Persons.Include(p => p.PersonsRoles)
                                                                  .ThenInclude(r => r.Role)
                                                                  .Include(p => p.Entity);
               return personsListWithRoles.ToList();
          }


          Person IDataRepository<Person, PersonDto>.Get(long id)
          {
               var personsListWithRoles = DataAccessContext.Persons.SingleOrDefault(b => b.PersonId == id);
               return personsListWithRoles;
          }

          void IDataRepository<Person, PersonDto>.Add(Person person)
          {
               DataAccessContext.Persons.Add(person);
               DataAccessContext.SaveChanges();
          }


          void IDataRepository<Person, PersonDto>.Update(Person entityToUpdate, Person entity)
          {
               //There is a separated functionality for updates using special input classes for security 
               throw new NotImplementedException();
          }

          void IDataRepository<Person, PersonDto>.Delete(Person person)
          {
               try
               {
                    DataAccessContext.Persons.Remove(person);
                    DataAccessContext.SaveChanges();
               }
               catch (Exception e)
               {
                    var err = e.ToString();
               }

          }

          PersonDto IDataRepository<Person, PersonDto>.GetDto(long id)
          {
               throw new NotImplementedException();
          }

          public IEnumerable<Person> GetFilteredList()
          {
               throw new NotImplementedException();
          }

          IEnumerable<ShoppingCart> IDataRepository<Person, PersonDto>.GetFilteredList(long id)
          {
               throw new NotImplementedException();
          }


          void IDataRepositoryForUpdates<Person, PersonInput>.Update(Person entityToUpdate, PersonInput inputEntity)
          {

               //Trasfer data from person input to a real person object
               entityToUpdate.PersonName = inputEntity.PersonName;
               entityToUpdate.LastName = inputEntity.LastName;
               entityToUpdate.RoomId = inputEntity.RoomId;
               DataAccessContext.Update(entityToUpdate);
               DataAccessContext.SaveChanges();

          }

     }
}
