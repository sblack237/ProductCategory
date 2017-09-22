using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductCategory.Models
{
    public class Category
    {

        [Required]
        public int CategoryId { get; set; }
        public String CategoryName { get; set; }

        public DateTime CreatedOnUtc { get; set; }

    }
}