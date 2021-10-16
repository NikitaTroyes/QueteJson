using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Quete_JSON
{
    class MainMeteo
    {

        public double temp { get; set; }
        public double pressure { get; set; }
        public double humidity { get; set; }
       
        [JsonProperty("temp_min")]
        public double tempMin { get; set; }
        [JsonProperty("temp_max")]
        public double tempMmax { get; set; }

    }
}
