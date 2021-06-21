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
     [Route("api/roles")]
     [ApiController]
     public class RoleController : ControllerBase
     {
          //interfaces injection
          private readonly ILogger<Role> _pLogger;
          private readonly IDataRepository<Role, RoleDto> _dataRepository;
          private IMapper _mapper;

          //Constructor
          public RoleController(ILogger<Role> pLogger, IMapper mapper, IDataRepository<Role, RoleDto> dataRepository)
          {
               _pLogger = pLogger;
               _mapper = mapper;
               _dataRepository = dataRepository;
          }

          //GET api/Roles
          [HttpGet]
          public IActionResult Get()
          {
               try
               {
                    var roles = _dataRepository.GetAll();
                    _pLogger.LogInformation($"Returned all roles from database ");

                    //map the results from previous query, into the DTO 
                    var rolesResultMapped = _mapper.Map<IEnumerable<RoleDto>>(roles);
                    return Ok(rolesResultMapped);
               }
               catch (Exception ex)
               {
                    _pLogger.LogError($"Error occured in Get roles action: {ex.Message} ");
                    return StatusCode(500, "Internal server error");
               }
          }

     }
}
