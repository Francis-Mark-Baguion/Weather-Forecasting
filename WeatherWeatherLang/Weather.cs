using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWeatherLang
{
    public class Weather
    {
        private int temperature { get; set; }
        private int humidity { get; set; }
        private int windSpeed { get; set; }

        private  Location location { get; set; }

        private Condition condition { get; set; }

        public Weather(Location location, int temperature, int humidity, int windSpeed, Condition condition)
        {
            this.location = location;
            this.temperature = temperature;
            this.humidity = humidity;
            this.windSpeed = windSpeed;
            this.condition = condition;

        }

        public Location GetLocation()
        {
            return location;
        }

        public bool isEqual(User user)
        {
            if (user.getLocation().id == this.location.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public override string ToString() 
        {
            return "Temperature: " + temperature + "°C, Humidity: " + humidity + "%, Wind Speed: " + windSpeed + "km/h " + location.ToString();
        }
    }
}
