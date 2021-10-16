using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Quete_JSON
{
    class CaracteristicsWeather
    {
        public Coordonnees coord { get; set; }
        public List<Weather> Weather { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }
        public int cod { get; set; }
        public Clouds clouds { get; set; }
        public int id { get; set; }
        public int dt { get; set; }

        [JsonProperty("main")]
        public MainMeteo MainMeteo { get; set; }
        public string name { get; set; }
        public int Visibility { get; set; }
        public Wind Wind { get; set; }
        public Sys Sys { get; set; }





    }
}
