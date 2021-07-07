namespace EntityFramework_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusSeedToDB : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Status (Name) VALUES ('To Do')");
            Sql("INSERT INTO Status (Name) VALUES ('In Progress')");
            Sql("INSERT INTO Status (Name) VALUES ('Done')");
        }
        
        public override void Down()
        {
            // We really should put some delete statements in here
        }
    }
}
