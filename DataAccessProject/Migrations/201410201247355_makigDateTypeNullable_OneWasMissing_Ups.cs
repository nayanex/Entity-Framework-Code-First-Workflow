namespace DataAccessProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makigDateTypeNullable_OneWasMissing_Ups : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "FirstVisit", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "FirstVisit", c => c.DateTime(nullable: false));
        }
    }
}
