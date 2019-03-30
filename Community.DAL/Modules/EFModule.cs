using System.Data.Entity;
using Autofac;

namespace Community.DAL.Modules
{

    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());

            builder.RegisterType(typeof(CommunityContext)).As(typeof(DbContext)).InstancePerLifetimeScope();

        }

    }
}