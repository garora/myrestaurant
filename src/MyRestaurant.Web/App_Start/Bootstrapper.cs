using System.Web.Http;

namespace MyRestaurant.Web.App_Start
{
    public class Bootstrapper
    {
        public static void Run()
        {
            // Configure Autofac
            AutofacWebapiConfig.Initialize(GlobalConfiguration.Configuration);
            //Configure AutoMapper
            //AutoMapperConfiguration.Configure();
        }
    }
}