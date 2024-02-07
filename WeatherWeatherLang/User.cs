using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWeatherLang
{
    public class User
    {
        public string id { get; set; }
        private string name { get; set; }
        private Location location { get; set; }

        public User(string id, string name, Location location)
        {
            this.id = id;
            this.name = name;
            this.location = location;
        }
        public Location getLocation()
        {
            return location;
        }
        public string getId()
        {
            return id;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
