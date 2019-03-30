namespace Community.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false, maxLength: 255),
                        PublishDate = c.DateTime(nullable: false),
                        Post_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posts", t => t.Post_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Post_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Content = c.Binary(nullable: false),
                        Format = c.String(nullable: false, maxLength: 1000),
                        Comment_Id = c.Int(),
                        Post_Id = c.Int(),
                        Message_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comments", t => t.Comment_Id)
                .ForeignKey("dbo.Posts", t => t.Post_Id)
                .ForeignKey("dbo.Messages", t => t.Message_Id)
                .Index(t => t.Comment_Id)
                .Index(t => t.Post_Id)
                .Index(t => t.Message_Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false, maxLength: 1000),
                        PublishDate = c.DateTime(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        PhoneNumber = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false, maxLength: 255),
                        SentTime = c.DateTime(nullable: false),
                        Receiver_Id = c.Int(),
                        Sender_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Receiver_Id)
                .ForeignKey("dbo.Users", t => t.Sender_Id)
                .Index(t => t.Receiver_Id)
                .Index(t => t.Sender_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "Sender_Id", "dbo.Users");
            DropForeignKey("dbo.Messages", "Receiver_Id", "dbo.Users");
            DropForeignKey("dbo.Documents", "Message_Id", "dbo.Messages");
            DropForeignKey("dbo.Comments", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Posts", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Documents", "Post_Id", "dbo.Posts");
            DropForeignKey("dbo.Comments", "Post_Id", "dbo.Posts");
            DropForeignKey("dbo.Documents", "Comment_Id", "dbo.Comments");
            DropIndex("dbo.Messages", new[] { "Sender_Id" });
            DropIndex("dbo.Messages", new[] { "Receiver_Id" });
            DropIndex("dbo.Posts", new[] { "User_Id" });
            DropIndex("dbo.Documents", new[] { "Message_Id" });
            DropIndex("dbo.Documents", new[] { "Post_Id" });
            DropIndex("dbo.Documents", new[] { "Comment_Id" });
            DropIndex("dbo.Comments", new[] { "User_Id" });
            DropIndex("dbo.Comments", new[] { "Post_Id" });
            DropTable("dbo.Messages");
            DropTable("dbo.Users");
            DropTable("dbo.Posts");
            DropTable("dbo.Documents");
            DropTable("dbo.Comments");
        }
    }
}
