namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateofBirthToCustomerTable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "membershipTypeID" });
            AddColumn("dbo.Customers", "DateofBirth", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Customers", "MembershipTypeID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "MembershipTypeID" });
            DropColumn("dbo.Customers", "DateofBirth");
            CreateIndex("dbo.Customers", "membershipTypeID");
        }
    }
}
