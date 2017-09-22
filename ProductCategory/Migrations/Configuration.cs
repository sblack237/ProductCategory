namespace ProductCategory.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductCategory.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProductCategory.Models.ApplicationDbContext context)
        {
            context.Products.AddOrUpdate(new Product[] {
            new Product() { Id = 1, Name = "Product1",ProductTemplateId =1, ShowOnHomePage =true, Published=true, Deleted =false, CreatedOnUtc = DateTimeOffset.Parse("2017-10-22T04:50:12.0000000").UtcDateTime, UpdatedOnUtc = DateTimeOffset.Parse("2017-10-22T04:50:12.0000000").UtcDateTime },
            new Product() { Id = 2, Name = "Product2",ProductTemplateId =2, ShowOnHomePage =true, Published=true, Deleted =false, CreatedOnUtc = DateTimeOffset.Parse("2017-10-22T04:50:12.0000000").UtcDateTime, UpdatedOnUtc = DateTimeOffset.Parse("2017-10-22T04:50:12.0000000").UtcDateTime },
            new Product() { Id = 3, Name = "Product3",ProductTemplateId =3, ShowOnHomePage =true, Published=true, Deleted =false, CreatedOnUtc = DateTimeOffset.Parse("2017-10-22T04:50:12.0000000").UtcDateTime, UpdatedOnUtc = DateTimeOffset.Parse("2017-10-22T04:50:12.0000000").UtcDateTime },
            new Product() { Id = 4, Name = "Product4",ProductTemplateId =4, ShowOnHomePage =true, Published=true, Deleted =false, CreatedOnUtc = DateTimeOffset.Parse("2017-10-22T04:50:12.0000000").UtcDateTime, UpdatedOnUtc = DateTimeOffset.Parse("2017-10-22T04:50:12.0000000").UtcDateTime },
            new Product() { Id = 5, Name = "Product5",ProductTemplateId =5, ShowOnHomePage =true, Published=true, Deleted =false, CreatedOnUtc = DateTimeOffset.Parse("2017-10-22T04:50:12.0000000").UtcDateTime, UpdatedOnUtc = DateTimeOffset.Parse("2017-10-22T04:50:12.0000000").UtcDateTime },

         });

            context.Categories.AddOrUpdate(new Category[] {
            new Category() { CategoryId = 1, CategoryName = "Science", CreatedOnUtc = DateTimeOffset.Parse("2017-10-22T04:50:12.0000000").UtcDateTime },
            new Category() { CategoryId = 2, CategoryName = "Business", CreatedOnUtc = DateTimeOffset.Parse("2017-10-22T04:50:12.0000000").UtcDateTime },
            
           
         });


            var p1 = context.Products.Find(1);
            var c1 = context.Categories.Find(1);

            var p2 = context.Products.Find(2);
            var c2 = context.Categories.Find(2);

            context.ProductCategoryMappings.AddOrUpdate(new ProductCategoryMapping[] {
            new ProductCategoryMapping() {
                Id = 1,
                Product = p1 ,
                Category = c1 ,
            },
            new ProductCategoryMapping() {
                Id = 2,
                Product = p2 ,
                Category = c2 ,
            }

         });


        }
    }
}
