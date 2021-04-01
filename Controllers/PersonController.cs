using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServicesOnLineAPI.Models.DTO;
using ServicesOnLineAPI.Models.Inputs;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Controllers
{
     [Route("api/person")]
     [ApiController]
     public class PersonController : ControllerBase
     {
          private readonly ILogger<Person> _pLogger;
          private IMapper _mapper;

          private readonly IDataRepository<Person, PersonDto> DataRepositoryPer;
          private readonly IDataRepositoryForUpdates<Person, PersonInput> DataRepositoryForUpdates;
          private readonly IDataRepository<Entity, EntityDto> DataRepositoryEnt;
          private readonly IDataRepository<PersonsRole, PersonsRoleDto> DataRepositoryRole;
          private readonly IDataRepository<OrdersHeader, OrdersHeaderDto> DataRepositoryOh;

          public PersonController(ILogger<Person> pLogger, IMapper mapper,
               IDataRepository<Person, PersonDto> dataRepositoryPer,
               IDataRepositoryForUpdates<Person, PersonInput> dataRepositoryPerUpd,
               IDataRepository<Entity, EntityDto> dataRepositoryEnt,
               IDataRepository<PersonsRole, PersonsRoleDto> dataRepositoryRole,
               IDataRepository<OrdersHeader, OrdersHeaderDto> dataRepositoryOh)
          {
               _pLogger = pLogger;
               _mapper = mapper;

               DataRepositoryPer = dataRepositoryPer;
               DataRepositoryForUpdates = dataRepositoryPerUpd;
               DataRepositoryEnt = dataRepositoryEnt;
               DataRepositoryRole = dataRepositoryRole;
               DataRepositoryOh = dataRepositoryOh;
          }

          //GET api/Persons
          [HttpGet]
          public IActionResult Get()
          {
               try
               {
                    var persons = DataRepositoryPer.GetAll();
                    _pLogger.LogInformation($"Returned all persons from the database.");

                    var personsResult = _mapper.Map<IEnumerable<PersonDto>>(persons);
                    return Ok(personsResult);
               }
               catch (Exception ex)
               {
                    _pLogger.LogError($"Error occurred in Get persons action: {ex.Message}");
                    return StatusCode(500, "Internal server error");
               }
          }


          //GET api/PersonsRoles/?id
          [HttpGet("{id}")]
          public IActionResult Get(int id)
          {
               var p = DataRepositoryPer.Get(id);
               return Ok(p);
          }


          [HttpPost]
          public IActionResult Post([FromBody] PersonInput personInput)
          {
               //default values
               Person person = new Person();
               person.PersonName = personInput.PersonName;
               person.LastName = personInput.LastName;
               person.RoomId = personInput.RoomId;

               DataRepositoryPer.Add(person);

               //get the person id, then

               //create then entity record
               Entity entity = new Entity();
               entity.EntityId = 0;
               entity.PersonId = person.PersonId;
               DataRepositoryEnt.Add(entity);

               //create the default role
               PersonsRole pr = new PersonsRole();
               pr.PersonId = person.PersonId;
               pr.RoleId = 1;    //customer
               DataRepositoryRole.Add(pr);

               //the address

               return Created("URI", person);
          }


          [HttpPut("{pesonId}")]
          public IActionResult Put(int pesonId, [FromBody] PersonInput personInput)
          {

               if (personInput == null)
               {
                    return BadRequest("Author is null.");
               }

               //create person object and check
               Person personToUpdate = DataRepositoryPer.Get(pesonId);
               if (personToUpdate == null)
               {
                    return NotFound("The person record couldn't be found.");
               }

               if (!ModelState.IsValid)
               {
                    return BadRequest();
               }
               //Perfrom the update
               DataRepositoryForUpdates.Update(personToUpdate, personInput);
               return NoContent();
          }

          [HttpDelete("{pesonId}")]
          public IActionResult Delete(int pesonId)
          {
               if (pesonId == 0)
               {
                    return BadRequest("Person id is invalid.");
               }

               //create person object and check
               Person personToDelete = DataRepositoryPer.Get(pesonId);
               if (personToDelete == null)
               {
                    return NotFound("The person record couldn't be found.");
               }

               //Check if there is any order for the person
               var o = DataRepositoryOh.Get(pesonId);
               if (o != null)              
               {
                    return BadRequest("The person record has orders history!");
               }

               //Delete person's roles
               PersonsRole pr = DataRepositoryRole.Get(pesonId);
               if (pr != null) { 
                    DataRepositoryRole.Delete(pr); 
               }

               //Delete entity
               Entity ent = DataRepositoryEnt.Get(pesonId);

               if (ent != null)
               {
                    DataRepositoryEnt.Delete(ent);
               }
             
               if (!ModelState.IsValid)
               {
                    return BadRequest();
               }

               //Perfrom the deletion
               DataRepositoryPer.Delete(personToDelete);
               return NoContent();

          }
     }
}
