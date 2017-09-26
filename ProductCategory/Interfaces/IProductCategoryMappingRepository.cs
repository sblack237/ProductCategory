using ProductCategory.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Interfaces
{
    interface IProductCategoryMappingRepository
    {
        void Add(ProductCategoryMapping p);
        void Edit(ProductCategoryMapping p);
        void Remove(int Id);
        IEnumerable GetCategories();
        ProductCategoryMapping FindById(int Id);
    }
}
