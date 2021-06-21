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
     [Route("api/regions")]
     [ApiController]
     public class GeoRegionController : ControllerBase
     {
          //class injecton
          private readonly IDataRepository<GeoRegion, GeoRegionDto> _dataRepository;

          //construcotr
          public GeoRegionController(IDataRepository<GeoRegion, GeoRegionDto> dataRepository)
          {
               _dataRepository = dataRepository;
          }

          //GET api/regions
          [HttpGet]
          public IActionResult Get()
          {
               var geor = _dataRepository.GetAll();
               return Ok(geor);
          }
     }
}
