using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmployeePortfolio.DataContext;
using EmployeePortfolio.Models;

namespace EmployeePortfolio.Controllers
{
    public class DetailController : Controller
    {
        private empDBContext db = new empDBContext();

        // GET: Detail
        public ActionResult Index()
        {
            return View(db.empObject.ToList());
        }

        // GET: Detail/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            empInfo empInfo = db.empObject.Find(id);
            if (empInfo == null)
            {
                return HttpNotFound();
            }
            return View(empInfo);
        }

        // GET: Detail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Detail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "empno,empname,projname,skills,alloc,exper,rmap")] empInfo empInfo)
        {
            if (ModelState.IsValid)
            {
                db.empObject.Add(empInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empInfo);
        }

        // GET: Detail/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            empInfo empInfo = db.empObject.Find(id);
            if (empInfo == null)
            {
                return HttpNotFound();
            }
            return View(empInfo);
        }

        // POST: Detail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "empno,empname,projname,skills,alloc,exper,rmap")] empInfo empInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empInfo);
        }

        // GET: Detail/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            empInfo empInfo = db.empObject.Find(id);
            if (empInfo == null)
            {
                return HttpNotFound();
            }
            return View(empInfo);
        }

        // POST: Detail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            empInfo empInfo = db.empObject.Find(id);
            db.empObject.Remove(empInfo);
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
