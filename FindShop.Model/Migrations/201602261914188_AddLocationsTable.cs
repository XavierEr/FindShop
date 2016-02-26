namespace FindShop.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLocationsTable : DbMigration
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
                        ShopId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shops", t => t.ShopId, cascadeDelete: true)
                .Index(t => t.ShopId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locations", "ShopId", "dbo.Shops");
            DropIndex("dbo.Locations", new[] { "ShopId" });
            DropTable("dbo.Locations");
        }
    }
}
