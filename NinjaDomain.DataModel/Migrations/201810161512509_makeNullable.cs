namespace NinjaDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makeNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ninjas", "DateOfBirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ninjas", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
