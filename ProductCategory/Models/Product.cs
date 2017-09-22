using System;
using System.ComponentModel.DataAnnotations;

namespace ProductCategory.Models
{
    public class Product
    {

        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int ProductTemplateId { get; set; }

        public bool ShowOnHomePage { get; set; }

        public bool Published { get; set; }

        public bool Deleted { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }

        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="productTemplateId">Initial value of the ProductTemplateId property.</param>
        /// <param name="showOnHomePage">Initial value of the ShowOnHomePage property.</param>
        /// <param name="published">Initial value of the Published property.</param>
        /// <param name="deleted">Initial value of the Deleted property.</param>
        /// <param name="createdOnUtc">Initial value of the CreatedOnUtc property.</param>
        /// <param name="updatedOnUtc">Initial value of the UpdatedOnUtc property.</param>
        public static Product CreateProduct(global::System.Int32 id, global::System.String name, global::System.Int32 productTemplateId, global::System.Boolean showOnHomePage, global::System.Boolean allowCustomerReviews, global::System.Int32 approvedRatingSum, global::System.Int32 notApprovedRatingSum, global::System.Int32 approvedTotalReviews, global::System.Int32 notApprovedTotalReviews, global::System.Boolean published, global::System.Boolean deleted, global::System.DateTime createdOnUtc, global::System.DateTime updatedOnUtc)
        {
            Product product = new Product();
            product.Id = id;
            product.Name = name;
            product.ProductTemplateId = productTemplateId;
            product.ShowOnHomePage = showOnHomePage;
            product.Published = published;
            product.Deleted = deleted;
            product.CreatedOnUtc = createdOnUtc;
            product.UpdatedOnUtc = updatedOnUtc;
            return product;
        }


    }
}
