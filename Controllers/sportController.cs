using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sportApi.models;
using System.Net.Http;


namespace sportApi.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    public class sportController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<sport> hent()
        {
            sport[] sportsArray = new sport[]
            {
                new sport{id=0, navn="fotball", beskrivelse="suger", dato= matte(1,1)},
                new sport{id=1, navn="basketball", beskrivelse="duger", dato=matte(2,2)}

            };
            return sportsArray; 

        } 

        private float matte(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        [HttpGet("getSum")] //returnere sum i en ny filepath //api/sport/getumm
        public int getSum([FromQuery]int x, [FromQuery]int y)
        {
            return x+y;
        }

        [HttpGet("tull")] //returner sport "arket" i en ny filepath //api/sport/tull
        public sport tull([FromQuery] sport a)
        {
            return a; 
        }

    }  
}
