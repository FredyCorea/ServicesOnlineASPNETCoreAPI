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
     [Route("api/OrdersHeader")]
     [ApiController]
     public class OrdersHeaderController : ControllerBase
     {

          //references to dependencies for injection
          private readonly IDataRepository<OrdersHeader, OrdersHeaderDto> DataRepository;

          //constructor and dependencies injection
          public OrdersHeaderController(IDataRepository<OrdersHeader, OrdersHeaderDto> dataRepository)
          {
               DataRepository = dataRepository;
          }

          //Data manipulation calls
          //GET api/orderheaders
          [HttpGet]
          public IActionResult Get()
          {
               var oh = DataRepository.GetAll();
               return Ok(oh);
          }



     }
}
