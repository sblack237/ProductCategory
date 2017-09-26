using ProductCategory.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Interfaces
{
    interface ICategoryRepository
    {

        void Add(Category p);
        void Edit(Category p);
        void Remove(int Id);
        IEnumerable GetCategories();
        Category FindById(int Id);

    }
}
