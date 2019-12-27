namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerDataDateofBirth : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET DateofBirth = '05/04/1996' Where Name = 'Samantha Thompson'");
        }
        
        public override void Down()
        {
        }
    }
}
