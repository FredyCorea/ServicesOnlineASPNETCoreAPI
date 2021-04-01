using AutoMapper;
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
     [Route("api/OrdersDetails")]
     [ApiController]
     public class OrderController : ControllerBase
     {
          //references to dependencies for injection
          private readonly IDataRepository<Order, OrderDto> DataRepository;
          private IMapper Mapp;

          //constructor and dependencies injection
          public OrderController(IMapper mapp, IDataRepository<Order, OrderDto> dataRepository)
          {
               Mapp = mapp;
               DataRepository = dataRepository;
          }

          //Data manipulation
          //Get api/orders
          [HttpGet]
          public IActionResult Get()
          {
               var o = DataRepository.GetAll();
               var om = Mapp.Map<IEnumerable<OrderDto>>(o);
               return Ok(om);
          }

     }
}
