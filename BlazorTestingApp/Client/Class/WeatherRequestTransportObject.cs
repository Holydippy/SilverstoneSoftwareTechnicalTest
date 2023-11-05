namespace BlazorTestingApp.Client.Class
{
    public class WeatherRequestTransportObject
    {
        public WeatherRequestTransportObject() { }

        public string api_key { get; set; }

        public string type { get; set; }
        public string query { get; set; }
        public string language { get; set; }
        public string unit { get; set; }

    }
}
