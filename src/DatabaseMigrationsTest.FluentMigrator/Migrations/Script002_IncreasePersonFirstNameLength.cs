using FluentMigrator;

namespace DatabaseMigrationsTest.FluentMigrator.Migrations
{
    [Migration(2)]
    public class Script002_IncreasePersonFirstNameLength : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Person")
                .AlterColumn("FirstName").AsString(500);
        }
    }
}