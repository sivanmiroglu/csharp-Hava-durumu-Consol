using System;
using System.Linq;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace weather_fore
{
    public class Program
    {
        static void Main(string[] args)
        {
            string api = "0a033d04e0bfb4e50f80f6fed5b278de";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument weather = XDocument.Load(connection);
            var temp = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var weatherstate = weather.Descendants("weather").ElementAt(0).Attribute("value").Value;
            Console.Write("İstanbul için sıcaklık : " + temp + " --- Hava Durumu :" + weatherstate);
            Console.ReadLine();
        }
    }
}
