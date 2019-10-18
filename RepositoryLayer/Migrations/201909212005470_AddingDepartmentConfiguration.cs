namespace RepositoryLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDepartmentConfiguration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DepartmentModels", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.DepartmentModels", "Url", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.DepartmentModels", "PhoneNumber", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.DepartmentModels", "Email", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.DepartmentModels", "CityLocation", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.DepartmentModels", "StateLocation", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DepartmentModels", "StateLocation", c => c.String());
            AlterColumn("dbo.DepartmentModels", "CityLocation", c => c.String());
            AlterColumn("dbo.DepartmentModels", "Email", c => c.String());
            AlterColumn("dbo.DepartmentModels", "PhoneNumber", c => c.String());
            AlterColumn("dbo.DepartmentModels", "Url", c => c.String());
            AlterColumn("dbo.DepartmentModels", "Name", c => c.String());
        }
    }
}
