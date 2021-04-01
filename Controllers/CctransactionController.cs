using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesOnLineAPI.Models.DataManager;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Controllers
{
     [Route("api/Cctransaction")]
     [ApiController]
     public class CctransactionController : ControllerBase
     {

          //references to dependencies for injection
          private readonly IDataRepository<Cctransaction, CctransactionDto> DataRepository;

          //constructor and dependencies injection
          public CctransactionController(IDataRepository<Cctransaction, CctransactionDto> dataRepository)
          {
               DataRepository = dataRepository;
          }

          //Data manipulation

          //GET api/Cctransaction
          [HttpGet]
          public IActionResult Get()
          {
               var cct = DataRepository.GetAll();
               return Ok(cct);
          }

     }
}
