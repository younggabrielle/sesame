namespace ggak_final_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedtofloat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WayPoints", "Lat", c => c.Single(nullable: true));
            AlterColumn("dbo.WayPoints", "Lng", c => c.Single(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WayPoints", "Lng", c => c.Geometry());
            AlterColumn("dbo.WayPoints", "Lat", c => c.Geometry());
        }
    }
}
