using IBM_27Nov2024_ASPNETMVC_Intro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IBM_27Nov2024_ASPNETMVC_Intro.Controllers
{
    public class ProductController : Controller
    {


        Models.IBM08Nov2024DbEntities _db = new Models.IBM08Nov2024DbEntities();

        // GET: Product
        public ActionResult Index()
        {
            return View(_db.Products.ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product product )
        {
            try
            {
               _db.Products.Add( product );
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(product);
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_db.Products.Find(id));
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product product )
        {
            try
            {
                // TODO: Add update logic here

                // Method One
                //Product PrdOld = _db.Products.Find(id);
                //PrdOld.ProductName=product.ProductName;
                //PrdOld.Qty =product.Qty;
                //PrdOld.Rate = product.Rate;

                // Method Two
                _db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                


                _db.SaveChanges();




                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_db.Products.Find(id));
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                _db.Products.Remove(_db.Products.Find(id));
                _db.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
