﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SalesProject.Entity;
using SalesProject.Model;

namespace SalesProject.Web.Controllers
{
    public class SalesmenController : Controller
    {
        private SalesProjectDataContext db = new SalesProjectDataContext();

        // GET: Salesmen
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult Loaddata()
        {
            var value = db.Salesmen.ToList();
            return Json(new { data = value }, JsonRequestBehavior.AllowGet);
        }

        // GET: Salesmen/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salesman salesman = db.Salesmen.Find(id);
            if (salesman == null)
            {
                return HttpNotFound();
            }
            return View(salesman);
        }

        // GET: Salesmen/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Salesmen/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Salesman salesman)
        {
            if (ModelState.IsValid)
            {
                db.Salesmen.Add(salesman);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(salesman);
        }

        // GET: Salesmen/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salesman salesman = db.Salesmen.Find(id);
            if (salesman == null)
            {
                return HttpNotFound();
            }
            return View(salesman);
        }

        // POST: Salesmen/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Salesman salesman)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salesman).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(salesman);
        }

        // GET: Salesmen/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salesman salesman = db.Salesmen.Find(id);
            if (salesman == null)
            {
                return HttpNotFound();
            }
            return View(salesman);
        }

        // POST: Salesmen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Salesman salesman = db.Salesmen.Find(id);
            db.Salesmen.Remove(salesman);
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
