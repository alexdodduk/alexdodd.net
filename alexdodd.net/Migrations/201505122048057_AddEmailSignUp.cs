namespace alexdodd.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailSignUp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmailSignUps",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmailSignUps");
        }
    }
}
