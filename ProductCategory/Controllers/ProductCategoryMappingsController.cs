using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ProductCategory.Models;

namespace ProductCategory.Controllers
{
    public class ProductCategoryMappingsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/ProductCategoryMappings
        public IQueryable<ProductCategoryMapping> GetProductCategoryMappings()
        {
            return db.ProductCategoryMappings;
        }

        // GET: api/ProductCategoryMappings/5
        [ResponseType(typeof(ProductCategoryMapping))]
        public IHttpActionResult GetProductCategoryMapping(int id)
        {
            ProductCategoryMapping productCategoryMapping = db.ProductCategoryMappings.Find(id);
            if (productCategoryMapping == null)
            {
                return NotFound();
            }

            return Ok(productCategoryMapping);
        }

        // PUT: api/ProductCategoryMappings/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProductCategoryMapping(int id, ProductCategoryMapping productCategoryMapping)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != productCategoryMapping.Id)
            {
                return BadRequest();
            }

            db.Entry(productCategoryMapping).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductCategoryMappingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ProductCategoryMappings
        [ResponseType(typeof(ProductCategoryMapping))]
        public IHttpActionResult PostProductCategoryMapping(ProductCategoryMapping productCategoryMapping)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProductCategoryMappings.Add(productCategoryMapping);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = productCategoryMapping.Id }, productCategoryMapping);
        }

        // DELETE: api/ProductCategoryMappings/5
        [ResponseType(typeof(ProductCategoryMapping))]
        public IHttpActionResult DeleteProductCategoryMapping(int id)
        {
            ProductCategoryMapping productCategoryMapping = db.ProductCategoryMappings.Find(id);
            if (productCategoryMapping == null)
            {
                return NotFound();
            }

            db.ProductCategoryMappings.Remove(productCategoryMapping);
            db.SaveChanges();

            return Ok(productCategoryMapping);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductCategoryMappingExists(int id)
        {
            return db.ProductCategoryMappings.Count(e => e.Id == id) > 0;
        }
    }
}