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
     [Route("api/PaymentHistory")]
     [ApiController]
     public class PaymentHistController : ControllerBase
     {
          //inject the data repository
          private readonly IDataRepository<PaymentHist, PaymentHistDto> DataRepository;

          public PaymentHistController(IDataRepository<PaymentHist, PaymentHistDto> dataRepository)
          {
               DataRepository = dataRepository;
          }

          [HttpGet]
          public IActionResult Get()
          {
               return Ok(DataRepository.GetAll());
          }
     }
}
