namespace RememberAB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatedrequured : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ContactsModels", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ContactsModels", "Email", c => c.String());
        }
    }
}
