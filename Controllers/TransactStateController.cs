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
     [Route("api/TransactState")]
     [ApiController]
     public class TransactStateController : ControllerBase
     {

          //references to dependencies for injection
          private readonly IDataRepository<TransactState, TransactStateDto> DataRepository;

          //construction and dependency injection
          public TransactStateController(IDataRepository<TransactState, TransactStateDto> dataRepository)
          {
               DataRepository = dataRepository;
          }

          //data manipulation
          //GET api/TransactState
          [HttpGet]
          public IActionResult Get()
          {
               var t = DataRepository.GetAll();
               return Ok(t);
          }

     }
}
