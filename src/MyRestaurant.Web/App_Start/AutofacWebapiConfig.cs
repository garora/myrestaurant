using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;

namespace MyRestaurant.Web.App_Start
{
    public class AutofacWebapiConfig
    {
        public static IContainer Container;
        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            
            //ToDo - uncomment when other functionality get implemented
            
            // EF MyRestaurantContext - Data Project
            //builder.RegisterType<MyRestaurantContext>()
            //       .As<DbContext>()
            //       .InstancePerRequest();



            // Services -- For Membership service
            //builder.RegisterType<EncryptionService>()
            //    .As<IEncryptionService>()
            //    .InstancePerRequest();

            //builder.RegisterType<MembershipService>()
            //    .As<IMembershipService>()
            //    .InstancePerRequest();

            // Generic Data Repository Factory
            //builder.RegisterType<DataRepositoryFactory>()
            //    .As<IDataRepositoryFactory>().InstancePerRequest();

            Container = builder.Build();

            return Container;
        }
    }
}