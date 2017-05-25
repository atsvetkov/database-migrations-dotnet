using FluentMigrator;

namespace DatabaseMigrationsTest.FluentMigrator.Migrations
{
    [Migration(1)]
    public class Script001_CreatePersonTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Person")
                .WithColumn("PersonId").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("FirstName").AsString(255).NotNullable()
                .WithColumn("LastName").AsString(255).NotNullable()
                .WithColumn("DateOfBirth").AsDate().NotNullable();
        }
    }
}