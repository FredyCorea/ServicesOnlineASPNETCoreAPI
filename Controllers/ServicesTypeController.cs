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
     [Route("api/servicestype")]
     [ApiController]
     public class ServicesTypeController : ControllerBase
     {
          //inject
          private readonly IDataRepository<ServicesType, ServicesTypeDto> DataRepository;

          //construct
          public ServicesTypeController(IDataRepository<ServicesType, ServicesTypeDto> dataRepository)
          {
               DataRepository = dataRepository;
          }

          //GET 
          [HttpGet]
          public IActionResult Get()
          {
               var st = DataRepository.GetAll();
               return Ok(st);
          }
     }
}
