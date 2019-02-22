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
    public class Student_RegistrationFormController : Controller
    {
        private FacultygropEntities db = new FacultygropEntities();

        // GET: Student_RegistrationForm
        public ActionResult Index()
        {
            return View(db.Student_RegistrationForm.ToList());
        }

        // GET: Student_RegistrationForm/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_RegistrationForm student_RegistrationForm = db.Student_RegistrationForm.Find(id);
            if (student_RegistrationForm == null)
            {
                return HttpNotFound();
            }
            return View(student_RegistrationForm);
        }

        // GET: Student_RegistrationForm/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student_RegistrationForm/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Std_Name,Std_EmailId,Std_MobileNo,Std_City,Std_State,Std_Country,Course,Std_DateOfBirth,Gender,CreateBy,CreateDate,ModifiedBy,ModifiedDate,Active")] Student_RegistrationForm student_RegistrationForm)
        {
            if (ModelState.IsValid)
            {
                db.Student_RegistrationForm.Add(student_RegistrationForm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student_RegistrationForm);
        }

        // GET: Student_RegistrationForm/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_RegistrationForm student_RegistrationForm = db.Student_RegistrationForm.Find(id);
            if (student_RegistrationForm == null)
            {
                return HttpNotFound();
            }
            return View(student_RegistrationForm);
        }

        // POST: Student_RegistrationForm/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Std_Name,Std_EmailId,Std_MobileNo,Std_City,Std_State,Std_Country,Course,Std_DateOfBirth,Gender,CreateBy,CreateDate,ModifiedBy,ModifiedDate,Active")] Student_RegistrationForm student_RegistrationForm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student_RegistrationForm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student_RegistrationForm);
        }

        // GET: Student_RegistrationForm/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_RegistrationForm student_RegistrationForm = db.Student_RegistrationForm.Find(id);
            if (student_RegistrationForm == null)
            {
                return HttpNotFound();
            }
            return View(student_RegistrationForm);
        }

        // POST: Student_RegistrationForm/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student_RegistrationForm student_RegistrationForm = db.Student_RegistrationForm.Find(id);
            db.Student_RegistrationForm.Remove(student_RegistrationForm);
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
