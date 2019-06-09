namespace AppointIn.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.address",
                c => new
                    {
                        addressId = c.Int(nullable: false, identity: true),
                        address = c.String(nullable: false, maxLength: 50),
                        address2 = c.String(maxLength: 50),
                        postalCode = c.String(nullable: false, maxLength: 10),
                        phone = c.String(nullable: false, maxLength: 20),
                        createDate = c.DateTime(nullable: false),
                        createBy = c.String(nullable: false, maxLength: 40),
                        lastUpdate = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        lastUpdateBy = c.String(nullable: false, maxLength: 40),
                        City_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.addressId)
                .ForeignKey("dbo.city", t => t.City_Id, cascadeDelete: true)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.city",
                c => new
                    {
                        cityId = c.Int(nullable: false, identity: true),
                        city = c.String(nullable: false, maxLength: 50),
                        createDate = c.DateTime(nullable: false),
                        createdBy = c.String(nullable: false, maxLength: 40),
                        lastUpdate = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        lastUpdateBy = c.String(nullable: false, maxLength: 40),
                        Country_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cityId)
                .ForeignKey("dbo.country", t => t.Country_Id, cascadeDelete: true)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.country",
                c => new
                    {
                        countryId = c.Int(nullable: false, identity: true),
                        country = c.String(nullable: false, maxLength: 50),
                        createDate = c.DateTime(nullable: false),
                        createBy = c.String(nullable: false, maxLength: 40),
                        lastUpdate = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        lastUpdateBy = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.countryId);
            
            CreateTable(
                "dbo.appointment",
                c => new
                    {
                        appointmentId = c.Int(nullable: false, identity: true),
                        title = c.String(nullable: false, maxLength: 255),
                        description = c.String(unicode: false, storeType: "text"),
                        location = c.String(unicode: false, storeType: "text"),
                        contact = c.String(nullable: false, unicode: false, storeType: "text"),
                        type = c.String(unicode: false, storeType: "text"),
                        url = c.String(maxLength: 255),
                        start = c.DateTime(nullable: false),
                        end = c.DateTime(nullable: false),
                        createDate = c.DateTime(nullable: false),
                        createdBy = c.String(nullable: false, maxLength: 40),
                        lastUpdate = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        lastUpdateBy = c.String(nullable: false, maxLength: 40),
                        Customer_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.appointmentId)
                .ForeignKey("dbo.customer", t => t.Customer_Id, cascadeDelete: true)
                .ForeignKey("dbo.user", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.customer",
                c => new
                    {
                        customerId = c.Int(nullable: false, identity: true),
                        customerName = c.String(nullable: false, maxLength: 45),
                        active = c.Boolean(nullable: false),
                        createDate = c.DateTime(nullable: false),
                        createdBy = c.String(nullable: false, maxLength: 40),
                        lastUpdate = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        lastUpdateBy = c.String(nullable: false, maxLength: 40),
                        Address_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.customerId)
                .ForeignKey("dbo.address", t => t.Address_Id, cascadeDelete: true)
                .Index(t => t.Address_Id);
            
            CreateTable(
                "dbo.user",
                c => new
                    {
                        userId = c.Int(nullable: false, identity: true),
                        userName = c.String(nullable: false, maxLength: 50),
                        password = c.String(nullable: false, maxLength: 50),
                        active = c.Boolean(nullable: false),
                        createDate = c.DateTime(nullable: false),
                        createdBy = c.String(nullable: false, maxLength: 40),
                        lastUpdate = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        lastUpdateBy = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.userId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.appointment", "User_Id", "dbo.user");
            DropForeignKey("dbo.appointment", "Customer_Id", "dbo.customer");
            DropForeignKey("dbo.customer", "Address_Id", "dbo.address");
            DropForeignKey("dbo.address", "City_Id", "dbo.city");
            DropForeignKey("dbo.city", "Country_Id", "dbo.country");
            DropIndex("dbo.customer", new[] { "Address_Id" });
            DropIndex("dbo.appointment", new[] { "User_Id" });
            DropIndex("dbo.appointment", new[] { "Customer_Id" });
            DropIndex("dbo.city", new[] { "Country_Id" });
            DropIndex("dbo.address", new[] { "City_Id" });
            DropTable("dbo.user");
            DropTable("dbo.customer");
            DropTable("dbo.appointment");
            DropTable("dbo.country");
            DropTable("dbo.city");
            DropTable("dbo.address");
        }
    }
}
