using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServicesOnLineAPI.Models.DTO;
using ServicesOnLineAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Controllers
{
     [Route("api/entity")]
     [ApiController]
     public class EntityController : ControllerBase
     {
          private readonly ILogger<Entity> _logger;
          private readonly IDataRepository<Entity, EntityDto> _dataRepository;
          private IMapper _mapper;

          //costructor
          public EntityController(ILogger<Entity> logger, IMapper mapper, IDataRepository<Entity, EntityDto> dataRepository)
          {
               _logger = logger;
               _mapper = mapper;
               _dataRepository = dataRepository;
          }

          //Get api/Entities
          [HttpGet]
          public IActionResult Get()
          {
               var ent = _dataRepository.GetAll();
               return Ok(ent);
          }

     }
}
