using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWeatherLang
{
    public class Location
    {
        public string id { get; set; }
        private string city { get; set; }

        private Day day { get; set; }

        public Location()
        {

        }
        public Location(string id ,string city , Day day)
        {
            this.id = id;
            this.city = city;
            this.day = day;
        }

        
        

        public override string ToString()
        {
            return city +" "+ day;
        }
    }
}
