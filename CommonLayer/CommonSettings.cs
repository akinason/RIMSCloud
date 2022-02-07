using System.Configuration;


namespace CommonLayer
{
    public class CommonSettings
    {
        public static string BaseUrl = ConfigurationManager.AppSettings.Get("baseURL");
    }
}
