namespace DatabaseMigrationsTest.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncreasePersonFirstNameLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "FirstName", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "FirstName", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
