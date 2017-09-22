using System.ComponentModel.DataAnnotations;

namespace ProductCategory.Models
{
    public class ProductCategoryMapping
    {


        [Required]
        public int Id { get; set; }

        public virtual Product Product { get; set; }


        public virtual Category Category { get; set; }
      
        /// <summary>
        /// Create a new ProductCategoryMapping object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="productId">Initial value of the ProductId property.</param>
        /// <param name="categoryId">Initial value of the CategoryId property.</param>
        public static ProductCategoryMapping CreateProductCategoryMapping(global::System.Int32 id, Product product, Category category, global::System.Boolean isFeaturedProduct, global::System.Int32 displayOrder)
        {
            ProductCategoryMapping productCategoryMapping = new ProductCategoryMapping();
            productCategoryMapping.Id = id;
            productCategoryMapping.Product = product;
            productCategoryMapping.Category = category;
           return productCategoryMapping;
        }


    }
}