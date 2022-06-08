namespace entity_prod4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLogsTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        LoginTime = c.String(),
                        LogoutTime = c.String(),
                        TimeSpent = c.Int(nullable: false),
                        IsCrash = c.Boolean(nullable: false),
                        Reason = c.String(),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Logs");
        }
    }
}
