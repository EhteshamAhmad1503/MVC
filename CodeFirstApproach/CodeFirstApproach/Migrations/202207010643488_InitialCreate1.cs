namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Name", c => c.String());
            AlterColumn("dbo.Students", "Gender", c => c.String());
            AlterColumn("dbo.Students", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Email", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "Gender", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "Name", c => c.Int(nullable: false));
        }
    }
}
