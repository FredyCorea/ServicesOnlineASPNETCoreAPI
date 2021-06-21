using AutoMapper;
using ServicesOnLineAPI.Models.DataManager;
using ServicesOnLineAPI.Models.DataTransferObject;
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
               CreateMap<Address, AddressDto>();
               //more mappings for each class
          }
     }
}
