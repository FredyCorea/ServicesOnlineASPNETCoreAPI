using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesOnLineAPI.Models.DataManager;
using ServicesOnLineAPI.Models.DataTransferObject;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Controllers
{
     [Route("api/ShoppingCart")]
     [ApiController]
     public class ShoppingCartController : ControllerBase
     {

          //references to dependencies for injection
          private readonly IDataRepository<ShoppingCart, ShoppingCartDto> DataRepository;
          private readonly IDataRepository<Entity, EntityDto> DataRepositoryEntity;
          private readonly IDataRepository<Person, PersonDto> DataRepositoryPerson;
          private readonly IDataRepository<Location, LocationDto> DataRepositoryLocation;

          private IMapper _mapper;

          //constructor and dependency injection
          //====================================
          //public ShoppingCartController(IDataRepository<ShoppingCart, ShoppingCartDto> dataRepository)
          //{
          //     DataRepository = dataRepository;
          //}

          public ShoppingCartController(IMapper mapper,
               IDataRepository<Entity, EntityDto> dataRepositoryEntity,
               IDataRepository<ShoppingCart, ShoppingCartDto> dataRepository,
               IDataRepository<Person, PersonDto> dataRepositoryPerson,
               IDataRepository<Location, LocationDto> dataRepositoryLocation)
          {
               _mapper = mapper;
               DataRepositoryEntity = dataRepositoryEntity;
               DataRepository = dataRepository;
               DataRepositoryPerson = dataRepositoryPerson;
               DataRepositoryLocation = dataRepositoryLocation;
          }


          //private ShoppingCartDto sch;
          //data manipulation

          //GET api/shoppingcart
          [HttpGet]
          public IActionResult Get()
          {
               List<ShoppingCart> sc1 = (List<ShoppingCart>)DataRepository.GetAll();

               var sc = _mapper.Map<IEnumerable<ShoppingCartDto>>(sc1);

               Nullable<int> personid = null;
               Nullable<int> locationid = null;
               //Nullable<int> propertyid = null;

               //TODO: SELECT LOCATION AS CUSTOMER ID

               foreach (ShoppingCartDto shopcart in sc)
               {
                    // rather than this code line
                    // personid = (int)shopcart.Entity.PersonId;
                    // use the ternary operator to check for null values and conver to 0 if found
                    personid = (shopcart.Entity.PersonId == null) ? 0 : shopcart.Entity.PersonId;

                    // locationid = (int)shopcart.Entity.LocationId;
                    locationid = (shopcart.Entity.LocationId == null) ? 0 : shopcart.Entity.LocationId;

                    // propertyid = (int)shopcart.Entity.PropertyId;

                    if (personid > 0)
                    {
                         //Get customer fom the persons list
                         var p = DataRepositoryPerson.Get((int)personid);
                         shopcart.Customer = new Models.Customer();
                         shopcart.Customer.CustomerId = (int)personid;
                         shopcart.Customer.CustomerName = p.PersonName + " " + p.LastName;
                    }
                    else if (locationid > 0)
                    {
                         //get customer form the locations list
                         var l = DataRepositoryLocation.Get((int)locationid);
                         shopcart.Customer = new Models.Customer();
                         shopcart.Customer.CustomerId = (int)locationid;
                         shopcart.Customer.CustomerName = l.LocationName;
                    }

               }

               return Ok(sc);
          }



          //GET api/shoppingcart
          [HttpGet("{CustomerId}")]
          //public IActionResult Get(long CustomerId)
          public IActionResult GetFilteredList(long CustomerId)
          {
               //Get the EntityId by person id or location id from the Entity object
               //Get the shopping cart by PersonId or LocationID
               var sc = DataRepository.GetFilteredList(CustomerId);      //this result cannot be mapped to DTO

               //To map IEnumerable collections
               //Obatained collected is mapped into the ShoppingCartDto which contains the Customer
               var scDto = _mapper.Map<IEnumerable<ShoppingCartDto>>(sc);

               //To map single objects, no usable in this situation because we gather a collection
               //var scDto = _mapper.Map<ShoppingCartDto>(sc1);

               Nullable<int> personid = null;
               Nullable<int> locationid = null;
               //Nullable<int> propertyid = null;

               //Decode the cumsomer name
               foreach (ShoppingCartDto shopcartLine in scDto)
               {
                    // Rather than this code line:
                    // personid = (int)shopcart.Entity.PersonId;
                    // use the ternary operator to check for null values and conver to 0 if found
                    personid = (shopcartLine.Entity.PersonId == null) ? 0 : shopcartLine.Entity.PersonId;
                    // locationid = (int)shopcart.Entity.LocationId;
                    locationid = (shopcartLine.Entity.LocationId == null) ? 0 : shopcartLine.Entity.LocationId;
                    // propertyid = (int)shopcart.Entity.PropertyId;

                    //Assign customer name
                    if (personid > 0)
                    {
                         //Get customer fom the persons list
                         var p = DataRepositoryPerson.Get((int)personid);
                         shopcartLine.Customer = new Models.Customer();
                         shopcartLine.Customer.CustomerId = (int)personid;
                         shopcartLine.Customer.CustomerName = p.PersonName + " " + p.LastName;
                    }
                    else if (locationid > 0)
                    {
                         //get customer form the locations list
                         var l = DataRepositoryLocation.Get((int)locationid);
                         shopcartLine.Customer = new Models.Customer();
                         shopcartLine.Customer.CustomerId = (int)locationid;
                         shopcartLine.Customer.CustomerName = l.LocationName;
                    }
               }
               return Ok(scDto);
          }

              
     }

}

