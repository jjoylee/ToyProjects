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
            var weatherInfo = GetWeatherInfo();
            return weatherInfo.Weather[0].Main;
        }

        private WeatherInfo GetWeatherInfo()
        {
            var weatherInfo = new WeatherInfo();
            using (var client = new WebClient())
            {
                var response = client.DownloadString(GetApiUrl());
                weatherInfo = (new JavaScriptSerializer()).Deserialize<WeatherInfo>(response);
            }
            return weatherInfo;
        }

        private string GetApiUrl()
        {
            var appid = "4d3414faf83a3ad6169e9e93db052e3a";
            return $"http://api.openweathermap.org/data/2.5/weather?q=Seoul&appid={appid}";
        }
    }
}