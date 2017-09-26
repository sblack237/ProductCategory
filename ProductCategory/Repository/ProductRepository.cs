using System;
using System.Linq;
using ProductCategory.Interfaces;
using ProductCategory.Models;
using System.Data.Entity;
using System.Collections;

namespace ProductCategory.Repository
{

    public class ProductRepository : IProductRepository
    {

        ProductContext context = new ProductContext();

        public ProductRepository()
        {
           
        }
        
        public void Add(Product p)
        {
            context.Products.Add(p);
            context.SaveChanges();
        }
        public void Edit(Product p)
        {
            context.Entry(p).State = System.Data.Entity.EntityState.Modified;
        }

        public Product FindById(int Id)
        {

            var result = (from r in context.Products
                          where r.Id == Id
                          select r).FirstOrDefault();
            return result;
            //return null;
        }

        public IEnumerable GetProducts() { return context.Products; }
        public void Remove(int Id)
        {
            Product p = context.Products.Find(Id);
            context.Products.Remove(p);
            context.SaveChanges();

        }

    }
}
