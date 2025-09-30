using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Restaurant.Core.DTO;

namespace Restaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {

        [HttpGet]
        [Route("GetWeatherByCity/{cityName}")]
        public async Task<Weather> GetWeatherByCity(string cityName)// https://localhost:7031/api/weather/GetWeatherByCity/Amman
        {
            var client = new HttpClient();
            var response =await client.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid=511ba00e6b1fdebcf7456541e7a16390&units=metric");
            var result =await response.Content.ReadAsStringAsync();
           var weatherResult = JsonConvert.DeserializeObject<Weather>(result);
            return weatherResult;
        }
    }
}
