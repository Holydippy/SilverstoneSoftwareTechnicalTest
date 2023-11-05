using BlazorTestingApp.Client.Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;


namespace BlazorTestingApp.Client.Methods
{
    public class AppSettingsCreator : PageModel
    {
        private IConfiguration Configuration;

        public AppSettingsCreator(IConfiguration iconfig)
        {
            Configuration = iconfig;
        }
    }
}
