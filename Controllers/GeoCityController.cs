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
     [Route("api/cities")]
     [ApiController]
     public class GeoCityController : ControllerBase
     {
          //inject the data repository
          private readonly IDataRepository<GeoCity, GeoCityDto> DataRepository;

          public GeoCityController(IDataRepository<GeoCity, GeoCityDto> dataRepository)
          {
               DataRepository = dataRepository;
          }

          [HttpGet]
          public IActionResult Get()
          {
               var geoc = DataRepository.GetAll();
               return Ok(geoc);
          }
     }
}
