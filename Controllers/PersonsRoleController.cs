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
     [Route("api/personroles")]
     [ApiController]
     public class PersonsRoleController : ControllerBase
     {
          private readonly ILogger<PersonsRole> _pLogger;
          private readonly IDataRepository<PersonsRole, PersonsRoleDto> _dataRepository;
          private IMapper _mapper;

          public PersonsRoleController(ILogger<PersonsRole> pLogger, IMapper mapper, IDataRepository<PersonsRole, PersonsRoleDto> dataRepository)
          {
               _pLogger = pLogger;
               _mapper = mapper;
               _dataRepository = dataRepository;
          }

          //GET api/PersonsRoles
          [HttpGet]
          public IActionResult Get()
          {
               //var personsRoles = _dataRepository.GetAll();
               //return Ok(personsRoles);
               var vRoles = _dataRepository.GetAll();
               var personsRoles = _mapper.Map<IEnumerable<PersonsRoleDto>>(vRoles);
               return Ok(personsRoles);
          }

     }
}
