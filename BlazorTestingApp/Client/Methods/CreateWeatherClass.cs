using BlazorTestingApp.Client.Class;

namespace BlazorTestingApp.Client.Methods
{
    public class CreateWeatherClass
    {
        public CreateWeatherClass()
        {
                
        }

        //create the new weather object with data provided from the API.
        public WeatherDataModel CreateObject(WeatherDataModel weather, WeatherData response = null)
        {
            if (response != null)
            {
                weather.Location = response.data[0].city_name;
                weather.Humidity = response.data[0].rh;
                weather.CurrentTemp = response.data[0].temp;
                weather.Sunset = response.data[0].sunset;
                weather.Sunrise = response.data[0].sunrise;
            }
            return weather;
        }
    }
}
