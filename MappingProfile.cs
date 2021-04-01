using AutoMapper;
using ServicesOnLineAPI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI
{
     public class MappingProfile : Profile
     {
          public MappingProfile()
          {
               CreateMap<Person, PersonDto>();
               CreateMap<Role, RoleDto>();
               CreateMap<PersonsRole, PersonsRoleDto>();
               CreateMap<Entity, EntityDto>();
               CreateMap<Service, ServiceDto>();
               CreateMap<ShoppingCart, ShoppingCartDto>();
               CreateMap<Order, OrderDto>();
               //more mappings for each class
          }
     }
}
