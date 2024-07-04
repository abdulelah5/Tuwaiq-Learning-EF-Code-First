namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        Price = c.String(),
                        Desc = c.String(),
                        Type_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Categories", t => t.Type_id)
                .Index(t => t.Type_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Type_id", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Type_id" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
