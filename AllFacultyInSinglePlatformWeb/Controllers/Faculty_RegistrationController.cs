using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AllFacultyInSinglePlatformWeb.Models;

namespace FacultyGroup.Controllers
{
    public class Faculty_RegistrationController : Controller
    {
        private FacultygropEntities db = new FacultygropEntities();

        // GET: Faculty_Registration
        public ActionResult Index()
        {
            return View(db.Faculty_Registration.ToList());
        }

        // GET: Faculty_Registration/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faculty_Registration faculty_Registration = db.Faculty_Registration.Find(id);
            if (faculty_Registration == null)
            {
                return HttpNotFound();
            }
            return View(faculty_Registration);
        }

        // GET: Faculty_Registration/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Faculty_Registration/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,EmailId,Mobile_Number,Course,Qulification,Total_Experience,CreateBy,CreateDate,ModifiedBy,ModifiedDate,Active")] Faculty_Registration faculty_Registration)
        {
            if (ModelState.IsValid)
            {
                db.Faculty_Registration.Add(faculty_Registration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(faculty_Registration);
        }

        // GET: Faculty_Registration/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faculty_Registration faculty_Registration = db.Faculty_Registration.Find(id);
            if (faculty_Registration == null)
            {
                return HttpNotFound();
            }
            return View(faculty_Registration);
        }

        // POST: Faculty_Registration/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,EmailId,Mobile_Number,Course,Qulification,Total_Experience,CreateBy,CreateDate,ModifiedBy,ModifiedDate,Active")] Faculty_Registration faculty_Registration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(faculty_Registration).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(faculty_Registration);
        }

        // GET: Faculty_Registration/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faculty_Registration faculty_Registration = db.Faculty_Registration.Find(id);
            if (faculty_Registration == null)
            {
                return HttpNotFound();
            }
            return View(faculty_Registration);
        }

        // POST: Faculty_Registration/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Faculty_Registration faculty_Registration = db.Faculty_Registration.Find(id);
            db.Faculty_Registration.Remove(faculty_Registration);
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
