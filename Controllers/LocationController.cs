using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesOnLineAPI.Models.DataTransferObject;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Controllers
{
     [Route("api/locations")]
     [ApiController]
     public class LocationController : ControllerBase
     {

          //references to dependencies for injection
          private readonly IDataRepository<Location, LocationDto> DataRepository;

          //constructor and depenency  injection
          public LocationController(IDataRepository<Location, LocationDto> dataRepository)
          {
               DataRepository = dataRepository;
          }

          //data manipulation
          //GET api/locations
          [HttpGet]
          public IActionResult Get()
          {
               var l = DataRepository.GetAll();
               return Ok(l);
          }
     }
}
