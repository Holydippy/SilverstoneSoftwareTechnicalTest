namespace BlazorTestingApp.Client.Class
{
    public class WeatherDataModel
    {
        public WeatherDataModel()
        {
            
        }

        public string Location { get; set; }
        public decimal CurrentTemp { get; set; }
        public decimal MinTemp { get; set; }
        public decimal MaxTemp { get; set; }
        public decimal Humidity { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
    }
}
