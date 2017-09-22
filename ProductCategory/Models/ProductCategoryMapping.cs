using System.ComponentModel.DataAnnotations;

namespace ProductCategory.Models
{
    public class ProductCategoryMapping
    {


        [Required]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }


        [Required]
        public int CategoryId { get; set; }

        /// <summary>
        /// Create a new ProductCategoryMapping object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="productId">Initial value of the ProductId property.</param>
        /// <param name="categoryId">Initial value of the CategoryId property.</param>
        public static ProductCategoryMapping CreateProductCategoryMapping(global::System.Int32 id, global::System.Int32 productId, global::System.Int32 categoryId, global::System.Boolean isFeaturedProduct, global::System.Int32 displayOrder)
        {
            ProductCategoryMapping productCategoryMapping = new ProductCategoryMapping();
            productCategoryMapping.Id = id;
            productCategoryMapping.ProductId = productId;
            productCategoryMapping.CategoryId = categoryId;
           return productCategoryMapping;
        }


    }
}