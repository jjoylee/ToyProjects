using PackAnUmbrella.Model;
using System;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace PackAnUmbrella
{
    public class WeatherGetter
    {
        public string Get()
        {
            var url = GetApiUrl();
            return GetWeather(url);
        }

        private string GetApiUrl()
        {
            var appid = "4d3414faf83a3ad6169e9e93db052e3a";
            return $"http://api.openweathermap.org/data/2.5/weather?q=Seoul&appid={appid}";
        }

        private string GetWeather(string url)
        {
            var weatherInfo = new WeatherInfo();
            using (var client = new WebClient())
            {
                var response = client.DownloadString(url);
                weatherInfo = (new JavaScriptSerializer()).Deserialize<WeatherInfo>(response);
            }
            return weatherInfo.Weather[0].Main;
        }
    }
}