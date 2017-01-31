namespace pasteBin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageBinary : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "ImageBinary", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "ImageBinary");
        }
    }
}
