namespace ProductCategory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyProductCategoryMapping : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductCategoryMappings", "Category_CategoryId", c => c.Int());
            CreateIndex("dbo.ProductCategoryMappings", "Category_CategoryId");
            AddForeignKey("dbo.ProductCategoryMappings", "Category_CategoryId", "dbo.Categories", "CategoryId");
            DropColumn("dbo.ProductCategoryMappings", "CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductCategoryMappings", "CategoryId", c => c.Int(nullable: false));
            DropForeignKey("dbo.ProductCategoryMappings", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.ProductCategoryMappings", new[] { "Category_CategoryId" });
            DropColumn("dbo.ProductCategoryMappings", "Category_CategoryId");
        }
    }
}
