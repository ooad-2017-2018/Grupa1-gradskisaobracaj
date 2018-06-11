using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PublicTrApphicWebApp.Models;

namespace PublicTrApphicWebApp.Controllers
{
    public class KorisniksController : Controller
    {
        private TrApphicDatabase db = new TrApphicDatabase();

        // GET: Korisniks
        public ActionResult Index()
        {
            return View(db.Korisnik.ToList());
        }

        // GET: Korisniks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Korisnik korisnik = db.Korisnik.Find(id);
            if (korisnik == null)
            {
                return HttpNotFound();
            }
            return View(korisnik);
        }

        // GET: Korisniks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Korisniks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Username,Password")] Korisnik korisnik)
        {
            if (ModelState.IsValid)
            {
                db.Korisnik.Add(korisnik);
                db.SaveChanges();
                ModelState.Clear();
                ViewBag.Message = korisnik.Username + " " + "uspješno registrovan :D";
                return RedirectToAction("Index");
            }

            return View(korisnik);
        }

        // GET: Korisniks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Korisnik korisnik = db.Korisnik.Find(id);
            if (korisnik == null)
            {
                return HttpNotFound();
            }
            return View(korisnik);
        }

        // POST: Korisniks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Username,Password")] Korisnik korisnik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(korisnik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(korisnik);
        }

        // GET: Korisniks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Korisnik korisnik = db.Korisnik.Find(id);
            if (korisnik == null)
            {
                return HttpNotFound();
            }
            return View(korisnik);
        }

        // POST: Korisniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Korisnik korisnik = db.Korisnik.Find(id);
            db.Korisnik.Remove(korisnik);
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

        //LOGIN
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Korisnik korisnik)
        {
            using (TrApphicDatabase db = new TrApphicDatabase())
            {
                var user = db.Korisnik.Single(u => u.Username == korisnik.Username && u.Password == korisnik.Password);
                if (user != null)
                {
                    Session["ID"] = user.Id.ToString();
                    Session["Username"] = user.Username;
                    return RedirectToAction("LoggedIn");
                }
                ModelState.AddModelError("", "Username ili password nisu tačni!");              
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["ID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult LogOut()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
