using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EnrollmentApplication2.Models;

namespace EnrollmentApplication2.Controllers
{
    public class Enrollment2Controller : Controller
    {
        private Enrollment2DB db = new Enrollment2DB();

		// Start Lab 9
		// Student Search
		public ActionResult StudentSearch(string q)
		{
			var students = GetStudents(q);
			return PartialView("_StudentSearch", students);
		}

		private List<Student> GetStudents(string searchString)
		{
			return db.Students
				.Where(a => a.FirstName.Contains(searchString))
				.Where(b => b.LastName.Contains(searchString))
				.ToList();
		}

		// Course Search
		public ActionResult CourseSearch(string q)
		{
			var courses = GetCourses(q);
			return PartialView("_CourseSearch", courses);
		}

		private List<Course> GetCourses(string searchString)
		{
			return db.Courses
				.Where(a => a.Title.Contains(searchString))
				.Where(b => b.Description.Contains(searchString))
				.ToList();
		}
		// End Lab 9

		// GET: Enrollment2
		public ActionResult Index()
        {
            var enrollments = db.Enrollments.Include(e => e.StudentObject);
			return View(enrollments.ToList());
			//after (enrollments) -> .ToList()
		}

		// GET: Enrollment2/Details/5
		public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrollment enrollment = db.Enrollments.Find(id);
            if (enrollment == null)
            {
                return HttpNotFound();
            }
            return View(enrollment);
        }

        // GET: Enrollment2/Create
        public ActionResult Create()
        {
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "LastName");
            return View();
        }

        // POST: Enrollment2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EnrollmentId,StudentId,CourseId,Grade,CourseObject,IsActive," +
			"AssignedCampus,EnrollmentSemester,EnrollmentYear")] Enrollment enrollment)
        {
            if (ModelState.IsValid)
            {
                db.Enrollments.Add(enrollment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "LastName", enrollment.StudentId);
            return View(enrollment);
        }

        // GET: Enrollment2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrollment enrollment = db.Enrollments.Find(id);
            if (enrollment == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "LastName", enrollment.StudentId);
            return View(enrollment);
        }

        // POST: Enrollment2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EnrollmentId,StudentId,CourseId,Grade,CourseObject,IsActive," +
			"AssignedCampus,EnrollmentSemester,EnrollmentYear")] Enrollment enrollment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enrollment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "LastName", enrollment.StudentId);
            return View(enrollment);
        }

        // GET: Enrollment2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrollment enrollment = db.Enrollments.Find(id);
            if (enrollment == null)
            {
                return HttpNotFound();
            }
            return View(enrollment);
        }

        // POST: Enrollment2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Enrollment enrollment = db.Enrollments.Find(id);
            db.Enrollments.Remove(enrollment);
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
