using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesOnLineAPI.Models.DTO;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Controllers
{
     [Route("api/[controller]")]
     [ApiController]
     public class LocationsTypeController : ControllerBase
     {
          //references to dependencies for injection
          private readonly IDataRepository<LocationsType, LocationTypeDto> DataRepository;

          //constructor
          public LocationsTypeController(IDataRepository<LocationsType, LocationTypeDto> dataRepository)
          {
               DataRepository = dataRepository;
          }

          //data manipulation
          [HttpGet]
          public IActionResult Get()
          {
               var lt = DataRepository.GetAll();
               return Ok(lt);
          }
     }

     internal class LocationsTypeDto
     {
     }
}
