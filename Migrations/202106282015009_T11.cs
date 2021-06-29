namespace FlightMode.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class T11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "FName", c => c.String(maxLength: 250, storeType: "nvarchar"));
            AlterColumn("dbo.User", "LName", c => c.String(maxLength: 250, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "LName", c => c.String(unicode: false));
            AlterColumn("dbo.User", "FName", c => c.String(unicode: false));
        }
    }
}
