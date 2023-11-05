using BlazorTestingApp.Client.Class;
using Microsoft.Extensions.Configuration;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;

namespace BlazorTestingApp.Client.Methods
{
    public class MakeAPICall
    {
        public MakeAPICall()
        {
            
        }
        //call and return with string from API
        public static async Task<WeatherData> APICallAsync(string location,string country)
        {
            //IConfiguration config = new ConfigurationBuilder()
            //         .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false).Build();
            //string test = config.GetSection("AppSettings")["APIURI"];

            string uri = "https://api.weatherbit.io/v2.0/current";
            string aPIKey = "8ee17bdeb77545f5afb126d5cbe92c01";
            string aPIResult = "";
            string content = string.Format("?key={0}&city={1}&country={2}", aPIKey, location, country);

            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                HttpClient httpClient = new HttpClient(handler);
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, uri + content);
                HttpResponseMessage response = await httpClient.SendAsync(request);

                var responseTask = await response.Content.ReadAsStringAsync();

                WeatherData weatherResponse = JsonConvert.DeserializeObject(responseTask, typeof(WeatherData)) as WeatherData;

                return weatherResponse;
            }
            catch (Exception ex)
            {
                aPIResult = "Unable to find location. Please check spelling and try again. If error continues to pursist please contact support.";
                //Error to user
                throw new Exception(aPIResult);
            }
        }
    }
}
