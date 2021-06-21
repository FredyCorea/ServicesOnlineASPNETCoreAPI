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
     [Route("api/PriceLists")]
     [ApiController]
     public class PriceListController : ControllerBase
     {

          //inject
          private readonly IDataRepository<PriceList, PriceListDto> DataRepository;
          IMapper mapper;
          Logger<PriceList> logger;

          //construct
          public PriceListController( IDataRepository<PriceList,PriceListDto> dataRepository)
          {
               DataRepository = dataRepository;
          }

          //get data
          [HttpGet]
          public IActionResult Get()
          {
               var pl = DataRepository.GetAll();
               return Ok(pl);
          }
     }
}
