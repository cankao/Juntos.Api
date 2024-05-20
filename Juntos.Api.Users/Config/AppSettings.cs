namespace Juntos.Api.Users.App.Config
{
    public class AppSettings
    {
        public static IConfiguration GetConfiguration()
        {
            var configSettings = GetAppSettings();

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)!.FullName)
                .AddJsonFile(configSettings, false, true);


            return builder.Build();
        }

        public static string GetAppSettings()
        {
            return string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("APP_ENVIRONMENT")) ?
                $"AppSettings/appsettings.json" :
                $"AppSettings/appsettings.{Environment.GetEnvironmentVariable("APP_ENVIRONMENT")}.json";
        }
    }
}
