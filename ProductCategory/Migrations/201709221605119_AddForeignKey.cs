namespace ProductCategory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductCategoryMappings", "Product_Id", c => c.Int());
            CreateIndex("dbo.ProductCategoryMappings", "Product_Id");
            AddForeignKey("dbo.ProductCategoryMappings", "Product_Id", "dbo.Products", "Id");
            DropColumn("dbo.ProductCategoryMappings", "ProductId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductCategoryMappings", "ProductId", c => c.Int(nullable: false));
            DropForeignKey("dbo.ProductCategoryMappings", "Product_Id", "dbo.Products");
            DropIndex("dbo.ProductCategoryMappings", new[] { "Product_Id" });
            DropColumn("dbo.ProductCategoryMappings", "Product_Id");
        }
    }
}
