using ProductCategory.Models;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProductCategory.Interfaces
{
    public interface IProductRepository
    {


        void Add(Product p);
        void Edit(Product p);
        void Remove(int Id);
        IEnumerable GetProducts();
        Product FindById(int Id);


    }
}
