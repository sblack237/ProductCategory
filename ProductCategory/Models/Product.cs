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

  
    }
}
