namespace DataAccessProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makigDateTypeNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "BirthDate", c => c.DateTime());
            AlterColumn("dbo.Visits", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Visits", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Patients", "BirthDate", c => c.DateTime(nullable: false));
        }
    }
}
