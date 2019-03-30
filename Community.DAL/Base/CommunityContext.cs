using System.Data.Entity;
using Community.DAL.Base.Mappings;
using Community.DAL.User.Views;

namespace Community.DAL
{
    public class CommunityContext:DbContext
    {
        public CommunityContext() : base("name=Community")
        {
            
        }

        public DbSet<Comment.Comment> Comments { get; set; }
        public DbSet<Post.Post> Posts { get; set; }
        public DbSet<Document.Document> Documents { get; set; }
        public DbSet<Message.Message> Messages { get; set; }
        public DbSet<User.User> Users { get; set; }
        public DbSet<Permission.Permission> Permissions { get; set; }

        public DbSet<ViewAccNamePermissions> AccNamesPermissions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ViewAccNamePermissionsMap());
        }
    }
}
