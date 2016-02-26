namespace FindShop.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLocationTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Address = c.String(),
                        Country = c.String(),
                        PostalCode = c.String(),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                        Timestamp = c.DateTimeOffset(nullable: false, precision: 7),
                        Shop_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shops", t => t.Shop_Id)
                .Index(t => t.Shop_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locations", "Shop_Id", "dbo.Shops");
            DropIndex("dbo.Locations", new[] { "Shop_Id" });
            DropTable("dbo.Locations");
        }
    }
}
