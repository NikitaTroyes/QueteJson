
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;



namespace Quete_JSON
{
    class Program
    {

        static void Main(string[] args)
        {

            string path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
            string filename = "weather.json";
            string pathAndFile = Path.Combine(path, filename);
            string jsonFile = File.ReadAllText(pathAndFile);

            CaracteristicsWeather caracteristicsWeather = JsonConvert.DeserializeObject<CaracteristicsWeather>(jsonFile);

            Console.WriteLine(caracteristicsWeather.Visibility) ;
            Console.ReadLine();
        }


    }

    
}
