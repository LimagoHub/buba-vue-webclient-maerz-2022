using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebClientDemo
{
    public class WeatherForecast
    {
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
        [JsonPropertyName("temperatureC")]
        public int TemperatureC { get; set; }
        [JsonPropertyName("temperatureF")]
        public int TemperatureF { get; set; }
        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        public override string ToString()
        {
            return $"{nameof(Date)}: {Date}, {nameof(TemperatureC)}: {TemperatureC}, {nameof(TemperatureF)}: {TemperatureF}, {nameof(Summary)}: {Summary}";
        }
    }
}
