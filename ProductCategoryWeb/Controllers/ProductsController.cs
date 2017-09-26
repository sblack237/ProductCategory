using System;
using System.Web.Mvc;
using ProductCategory.Models;
using ProductCategory.Repository;

namespace ProductCategoryWeb.Controllers
{
    public class ProductsController : Controller
    {
        //Use of API repository pattern
        private ProductRepository db = new ProductRepository();
        // GET: Products
        public ActionResult Index()
        {
            return View(db.GetProducts());
            
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            Product product = db.FindById(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,ProductTemplateId,ShowOnHomePage,Published,Deleted,CreatedOnUtc,UpdatedOnUtc")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Add(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            
            Product product = db.FindById(id);
            
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,ProductTemplateId,ShowOnHomePage,Published,Deleted,CreatedOnUtc,UpdatedOnUtc")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Edit(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {

            Product product = db.FindById(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.FindById(id);
            db.Remove(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }
    }
}
