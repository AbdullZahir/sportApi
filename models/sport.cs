using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sportApi.models
{
    public class sport
    {
        public int id { get; set; }
        public string navn { get; set; }
        public string beskrivelse { get; set; }
        public float dato { get; set;  }

    }
}
