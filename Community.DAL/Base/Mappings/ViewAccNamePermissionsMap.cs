using System.Data.Entity.ModelConfiguration;

namespace Community.DAL.Base.Mappings
{
    public class ViewAccNamePermissionsMap:EntityTypeConfiguration<DAL.User.Views.ViewAccNamePermissions>
    {
        public ViewAccNamePermissionsMap()
        {
            this.ToTable("AccNamesPermissions");
            this.HasKey(t => t.Id);
        }
    }
}
