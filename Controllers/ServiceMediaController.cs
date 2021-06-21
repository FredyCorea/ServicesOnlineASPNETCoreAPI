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
     [Route("api/ServiceMedia")]
     [ApiController]
     public class ServiceMediaController : ControllerBase
     {

          //references to inject
          private readonly IDataRepository<ServiceMedia, ServiceMediaDto> DataRepository;

          //constructor and injection
          public ServiceMediaController(IDataRepository<ServiceMedia, ServiceMediaDto> dataRepository)
          {
               DataRepository = dataRepository;
          }

          //data manipulation
          //GET api/ServiceMedia
          [HttpGet]
          public IActionResult Get()
          {
               var sm = DataRepository.GetAll();
               return Ok(sm);
          }

     }
}
