using System.Reflection;
using Autofac;

namespace Community.BLL.Modules
{

    public class ManagerModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load(Assembly.GetExecutingAssembly().GetName().Name))
                      .Where(t => t.Name.EndsWith("Manager"))
                      .AsImplementedInterfaces()
                      .InstancePerLifetimeScope();
        }
    }
}