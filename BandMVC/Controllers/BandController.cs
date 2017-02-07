using BandMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BandMVC.Controllers
{
    public class BandController : Controller
    {
        BandContext db = new BandContext();

        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Create(Band band)
        {
            if (Request.HttpMethod == "POST")
            {
                db.Bands.Add(band);
                db.SaveChanges();
                return View();
            }
            else
            {
                return View();
            } 
        }

    }
}