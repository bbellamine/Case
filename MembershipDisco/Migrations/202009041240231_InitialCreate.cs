namespace MembershipDisco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IdentityCards",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        NISS = c.String(),
                        ValidityDate = c.DateTime(nullable: false),
                        ExpirationDate = c.DateTime(nullable: false),
                        CardNumber = c.Long(nullable: false),
                        Expired = c.Boolean(nullable: false),
                        Renewed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.CardNumber, unique: true);
            
            CreateTable(
                "dbo.MembershipCards",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CardNumber = c.Long(nullable: false),
                        Lost = c.Boolean(nullable: false),
                        MemberId = c.Long(nullable: false),
                        UnblacklistDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Memberships", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.Memberships",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Mail = c.String(),
                        PhoneNumber = c.String(),
                        IdentityCardId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IdentityCards", t => t.IdentityCardId, cascadeDelete: true)
                .Index(t => t.IdentityCardId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MembershipCards", "MemberId", "dbo.Memberships");
            DropForeignKey("dbo.Memberships", "IdentityCardId", "dbo.IdentityCards");
            DropIndex("dbo.Memberships", new[] { "IdentityCardId" });
            DropIndex("dbo.MembershipCards", new[] { "MemberId" });
            DropIndex("dbo.IdentityCards", new[] { "CardNumber" });
            DropTable("dbo.Memberships");
            DropTable("dbo.MembershipCards");
            DropTable("dbo.IdentityCards");
        }
    }
}
