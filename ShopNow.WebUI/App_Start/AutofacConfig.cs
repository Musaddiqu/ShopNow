using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace ShopNow.WebUI.App_Start
{
    public class AutofacConfig
    {
        public static void Register() 
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModule<AutofacWebTypesModule>();
            //builder.RegisterType<ProductRepository>().As<IProductRepository>();
           
            Assembly assembly = Assembly.Load("ShopNow.Repository");

            builder.RegisterAssemblyTypes(assembly)
            .Where(t => t.IsClass && t.Name.EndsWith("Repository",StringComparison.OrdinalIgnoreCase))
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}