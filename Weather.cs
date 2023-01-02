namespace BlazorApp2
{
    public class WeatherForecast
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        //public string[]? hourly{ get; set; }
        // public string[]? daily { get; set; }

        public CurrentWeatherForecast? current_weather { get; set; }

        public double temperature { get => current_weather.temperature; }
        public double windspeed { get => current_weather.windspeed; }
        public double winddirection { get => current_weather.winddirection; }

        public DateTime Date = DateTime.Now;

        public HourlyForecast hourly {get;set;}
        public List<DateTime> time { get => hourly.time; }

        public List<double> temperature_2m { get => hourly.temperature_2m; }
        
        public Dictionary<DateTime,double> hourlyTemperatures()
        {
            var dic = new Dictionary<DateTime,double>();    
            for(int i=0;i<time.Count;i++)
            {
                dic.Add(time[i], temperature_2m[i]);
            }
            return dic;
        }
        public int Summary { get => current_weather.weathercode; }

        public int TemperatureF => 32 + (int)(temperature / 0.5556);
    }
    public class CurrentWeatherForecast
    {
        public double temperature { get; set; }
        public double windspeed { get; set; }
        public double winddirection { get; set; }
        public int weathercode { get; set; }
        public DateTime time { get; set; }
    }
    public class HourlyForecast
    {

        public List<DateTime>? time { get; set; }
        public List<double>? temperature_2m { get; set; }

        
    }
}
