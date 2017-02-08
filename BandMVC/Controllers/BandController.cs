using BandMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;

namespace BandMVC.Controllers
{
    public class BandController : Controller
    {
        BandContext db = new BandContext();

        public ActionResult Index(string bandsearch)
        {
            var bands = db.Bands.Include(a => a.Albums);
            ViewBag.AllBands = db.Bands.OrderBy(b => b.BandName).ToList();

            if (!String.IsNullOrEmpty(bandsearch))
            {
                ViewBag.AllBands = db.Bands.Where(s => s.BandName.Contains(bandsearch));
            }

            return View();
        }



        public ActionResult Create(Band band)
        {
            if (Request.HttpMethod == "POST")
            {
                db.Bands.Add(band);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            } 
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Band band = db.Bands.Find(id);
            if (band == null)
            {
                return HttpNotFound();
            }
            return View(band);
        }

        // POST: Band/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Band band = db.Bands.Find(id);
            db.Bands.Remove(band);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            Band band = db.Bands.Find(id);
            ViewBag.AllAlbums = band.Albums.ToList();
            return View(band);
        }

    }
}