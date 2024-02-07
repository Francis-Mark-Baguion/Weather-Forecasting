using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWeatherLang
{
    public class System
    {
        
        List <Weather> forecast = new List<Weather>();
        List <User> users = new List<User>();
        List <Location> cities = new List<Location>();

        int LocId = 0;

        public System()
        {
            forecast.Add(new Weather(new Location("1", "London", Day.Sunday), 30, 50, 50, Condition.Sunny));
            forecast.Add(new Weather(new Location("2", "Paris", Day.Monday), 20, 60, 60, Condition.Rainy));
            forecast.Add(new Weather(new Location("3", "New York", Day.Saturday), 25, 40, 40, Condition.Cloudy));
            forecast.Add(new Weather(new Location("4", "Tokyo" , Day.Sunday), 35, 70, 70, Condition.Stormy));
            forecast.Add(new Weather(new Location("5", "Berlin", Day.Sunday), 15, 30, 30, Condition.Windy));

            users.Add(new User("1", "John", new Location("1", "London", Day.Saturday)));
            users.Add(new User("2", "Jane", new Location("2", "Paris", Day.Saturday)));
            users.Add(new User("3", "Jack", new Location("3", "New York", Day.Saturday)));
            users.Add(new User("4", "Jill", new Location("4", "Tokyo", Day.Saturday)));
            users.Add(new User("5", "James", new Location("5", "Berlin", Day.Saturday)));

            cities.Add(new Location("1", "London", Day.Saturday));
            cities.Add(new Location("2", "Paris", Day.Saturday));
            cities.Add(new Location("3", "New York", Day.Saturday));
            cities.Add(new Location("4", "Tokyo", Day.Saturday));
            cities.Add(new Location("5", "Berlin" , Day.Saturday));
            
        }

        private string idGenerator()
        {
            return LocId++ + "";
        }
        private string findLoc(string loc)
        {
            foreach(Location location in cities)
            {
                if(location.ToString() == loc)
                {
                    return location.ToString();
                }
            }
            return null;
        }

        public void showAllCities()
        {
            foreach(Location location in cities)
            {
                Console.WriteLine(location);
            }
        }

        public void showAllUsers()
        {
            foreach(User user in users)
            {
                Console.WriteLine(user);
            }
        }

        public void showAllWeather()
        {
            foreach(Weather weather in forecast)
            {
                Console.WriteLine(weather);
            }
        }

        private Day dayRandomizer()
        {
            Random random = new Random();
            int day = random.Next(1, 7);
            switch (day)
            {
                case 1:
                    return Day.Monday;
                case 2:
                    return Day.Tuesday;
                case 3:
                    return Day.Wednesday;
                case 4:
                    return Day.Thursday;
                case 5:
                    return Day.Friday;
                case 6:
                    return Day.Saturday;
                case 7:
                    return Day.Sunday;
                default:
                    return Day.Monday;
            }
        }
        public void addUser(string id, string name, string loc)
        {
           Location location = new Location(idGenerator(), findLoc(loc), dayRandomizer());
           User user = new User(id, name, location);
            users.Add(user);
        }

        public void removeUser(User user)
        {
            users.Remove(user);
        }

        public void AddWeather(string loc, int temp, int humidity , int wind )
        {

            Condition condition;
            Location location = new Location(idGenerator(), loc, dayRandomizer());
            if(temp > 30 || humidity < 50 || wind < 50)
            {
                   condition = Condition.Sunny;
            }
            else if(temp < 30 || humidity > 50 || wind > 50)
            {
                condition = Condition.Rainy;
            }
            else if(temp < 30 || humidity < 50 || wind > 50)
            {
                condition = Condition.Windy;
            }
            else if(temp > 30 || humidity > 50 || wind < 50)
            {
                condition = Condition.Cloudy;
            }
            else
            {
                condition = Condition.Stormy;
            }

            Weather weather = new Weather(location ,temp, humidity, wind,condition);
            
            
            forecast.Add(weather);
        }

        public void RemoveWeather(Weather weather)
        {
            forecast.Remove(weather);
        }

        public User findUser(string id)
        {
            foreach(User user in users)
            {
                if(user.id == id)
                {
                    return user;
                }
            }
            return null;
        }
        public void userWeatherLocation(string id)
        {
            User user = findUser(id);
            foreach(Weather weather in forecast)
            {
                if (weather.isEqual(user))
                {
                    Console.WriteLine(weather.ToString());
                }
                
            }
        }
    }
}
