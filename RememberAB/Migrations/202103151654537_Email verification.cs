namespace RememberAB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Emailverification : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContactsModels", "ConfirmEmail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContactsModels", "ConfirmEmail");
        }
    }
}
