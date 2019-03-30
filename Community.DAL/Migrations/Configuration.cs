using System.Collections.Generic;

namespace Community.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Community.DAL.CommunityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Community.DAL.CommunityContext context)
        {

            Permission.Permission[] permissions = 
            {
                new Permission.Permission
                {
                    PermissionName = "Admin"
                },
                new Permission.Permission
                {
                    PermissionName = "User"
                },
                new Permission.Permission
                {
                    PermissionName = "Moderator"
                },
                new Permission.Permission
                {
                    PermissionName = "Guest"
                }
            };

            User.User[] users =
            {
                new User.User
                {
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    AccName = "jkowalski",
                    PhoneNumber = "1234534",
                    Email = "jk@wp.pl",
                    Permissions = new List<Permission.Permission> {permissions[0], permissions[1]}

                },
                new User.User()
                {
                    FirstName = "Krzysztof",
                    LastName = "Jarzyna",
                    AccName = "kjarzyna",
                    PhoneNumber = "7654534",
                    Email = "kj@gmail.com",
                    Permissions = new List<Permission.Permission> {permissions[1], permissions[2]}
                },
                new User.User()
                {
                    FirstName = "Anna",
                    LastName = "Nowak",
                    AccName = "anowak",
                    PhoneNumber = "6456457",
                    Email = "an@o2.com",
                    Permissions = new List<Permission.Permission> {permissions[1]}
                },
                new User.User()
                {
                    FirstName = "Zyta",
                    LastName = "Wata",
                    AccName = "zwata",
                    PhoneNumber = "66666",
                    Email = "zw@outlook.com",
                    Permissions = new List<Permission.Permission> {permissions[1]}
                }
            };

            context.Permissions.AddOrUpdate(permissions);

            context.Users.AddOrUpdate(users);
        }
    }
}
