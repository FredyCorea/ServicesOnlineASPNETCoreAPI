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
     [Route("api/promotions")]
     [ApiController]
     public class PromotionController : ControllerBase
     {

          //references for injection
          private readonly IDataRepository<Promotion, PromotionDto> DataRepository;

          //injection
          public PromotionController(IDataRepository<Promotion, PromotionDto> dataRepository)
          {
               DataRepository = dataRepository;
          }

          //data manipulation
          //GET API/Promotions
          [HttpGet]
          public IActionResult Get()
          {
               var p = DataRepository.GetAll();
               return Ok(p);
          }
     }
}
