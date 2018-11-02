namespace PhoneShop.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderTime = c.DateTime(nullable: false),
                        Customer_ID = c.Int(nullable: false),
                        Item_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.Customer_ID, cascadeDelete: true)
                .ForeignKey("dbo.Phones", t => t.Item_ID, cascadeDelete: true)
                .Index(t => t.Customer_ID)
                .Index(t => t.Item_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Model = c.String(nullable: false),
                        Producer = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Item_ID", "dbo.Phones");
            DropForeignKey("dbo.Orders", "Customer_ID", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "Item_ID" });
            DropIndex("dbo.Orders", new[] { "Customer_ID" });
            DropTable("dbo.Phones");
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
        }
    }
}
