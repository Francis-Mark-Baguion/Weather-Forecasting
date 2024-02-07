using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWeatherLang
{
    public class Program
    {
        static void Main(string[] args)
        {
            System AppInterface = new System();

            string control;
            Console.WriteLine("Welcome to WeatherWeatherLang");

            string id, name, location;

            //control = Console.ReadLine();

           
                id = "6";
                name = "John";
                location = "New York";
                AppInterface.addUser(id,name, location);

            AppInterface.showAllUsers();    

            AppInterface.removeUser(AppInterface.findUser("6"));

            AppInterface.showAllCities();

            AppInterface.showAllWeather();


            AppInterface.userWeatherLocation("1");
            Console.ReadLine();

        }
    }
}
