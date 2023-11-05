using Microsoft.Extensions.Configuration;

namespace BlazorTestingApp.Client.Class

{
    public class AppSettings
    {
        public const string AppSetting = "AppSetting";
        private IConfiguration _configuration;
        public AppSettings(IConfiguration iconfig)
        {
            _configuration = iconfig;
        }
        public string? APIURI { get; set; }
        public string? APIKEY { get; set; }
    }
}
