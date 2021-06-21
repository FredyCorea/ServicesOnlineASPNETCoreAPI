using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesOnLineAPI.Models.DataTransferObject;
using ServicesOnLineAPI.Models.DataManager;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Controllers
{
     [Route("api/UnitOfMeasure")]
     [ApiController]
     public class UnitOfMeasureController : ControllerBase
     {
          //inject
          private readonly IDataRepository<UnitOfMeasure, UnitOfMeasureDto> DataRepository;

          //constructor
          public UnitOfMeasureController(IDataRepository<UnitOfMeasure, UnitOfMeasureDto> dataRepository)
          {
               DataRepository = dataRepository;
          }
          
          //functions
          //GET 
          [HttpGet]
          public IActionResult Get()
          {
               var uom = DataRepository.GetAll();
               return Ok(uom);
          }
     }
}
