using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PredictiveOrdering.Models;

namespace PredictiveOrdering.Controllers
{
    public class Cust_AuthenicationController : Controller
    {
        private PredictiveDBEntities db = new PredictiveDBEntities();

        // GET: Cust_Authenication
        public ActionResult Index()
        {
            return View(db.Cust_Authenication.ToList());
        }

        // GET: Cust_Authenication/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cust_Authenication cust_Authenication = db.Cust_Authenication.Find(id);
            if (cust_Authenication == null)
            {
                return HttpNotFound();
            }
            return View(cust_Authenication);
        }

        // GET: Cust_Authenication/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cust_Authenication/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Cust_Id,Cust_Password")] Cust_Authenication cust_Authenication)
        {
            if (ModelState.IsValid)
            {
                db.Cust_Authenication.Add(cust_Authenication);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cust_Authenication);
        }

        // GET: Cust_Authenication/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cust_Authenication cust_Authenication = db.Cust_Authenication.Find(id);
            if (cust_Authenication == null)
            {
                return HttpNotFound();
            }
            return View(cust_Authenication);
        }

        // POST: Cust_Authenication/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Cust_Id,Cust_Password")] Cust_Authenication cust_Authenication)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cust_Authenication).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cust_Authenication);
        }

        // GET: Cust_Authenication/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cust_Authenication cust_Authenication = db.Cust_Authenication.Find(id);
            if (cust_Authenication == null)
            {
                return HttpNotFound();
            }
            return View(cust_Authenication);
        }

        // POST: Cust_Authenication/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Cust_Authenication cust_Authenication = db.Cust_Authenication.Find(id);
            db.Cust_Authenication.Remove(cust_Authenication);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
