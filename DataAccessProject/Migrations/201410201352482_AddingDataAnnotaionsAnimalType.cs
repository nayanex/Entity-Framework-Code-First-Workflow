namespace DataAccessProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDataAnnotaionsAnimalType : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AnimalTypes", newName: "Species");
            AlterColumn("dbo.Species", "TypeName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Species", "TypeName", c => c.String());
            RenameTable(name: "dbo.Species", newName: "AnimalTypes");
        }
    }
}
