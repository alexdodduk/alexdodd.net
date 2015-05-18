namespace alexdodd.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUniquenessFromEmail : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.EmailSignUps", new[] { "Email" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.EmailSignUps", "Email", unique: true);
        }
    }
}
