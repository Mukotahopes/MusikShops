namespace BLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class temp : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblMusic", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblMusic", "Name", c => c.Int(nullable: false));
        }
    }
}
