using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesOnLineAPI.Models.DataTransferObject
{
     public class ServicesTypeDto
     {
          public ServicesTypeDto(){ }

          public int ServTypeId { get; set; }
          public string ServTypeName { get; set; }
     }
}
