using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServicesOnLineAPI.Models.DataTransferObject;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Controllers
{
     [Route("api/ServiceSched")]
     [ApiController]
     public class ServiceSchedController : ControllerBase
     {
          //references
          private readonly IDataRepository<ServiceSched, ServiceSchedDto> DataRepository;
          //IMapper mapper;
          //Logger<ServiceSched> logger;

          //construct/inject
          public ServiceSchedController(IDataRepository<ServiceSched, ServiceSchedDto> dataRepository)
          {
               DataRepository = dataRepository;
          }

          //get data
          [HttpGet]
          public IActionResult Get()
          {
               var sched = DataRepository.GetAll();
               return Ok(sched);
          }


     }
}
