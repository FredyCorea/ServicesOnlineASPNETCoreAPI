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
     [Route("api/services")]
     [ApiController]
     public class ServiceController : ControllerBase
     {
          private readonly ILogger<Service> _logger;
          private readonly IDataRepository<Service, ServiceDto> _dataRepository;
          private readonly IMapper _mapper;

          //Constructor
          public ServiceController(ILogger<Service> logger, IMapper mapper, IDataRepository<Service, ServiceDto> dataRepository) {
               _logger = logger;
               _dataRepository = dataRepository;
               _mapper = mapper;
          }

          //GET api/Services
          [HttpGet]
          public IActionResult Get()
          {
               var serv = _dataRepository.GetAll();
               return Ok(serv);
          }

     }
}
