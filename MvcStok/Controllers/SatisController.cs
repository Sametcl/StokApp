using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Controllers;
using MvcStok.Models.Entity;
namespace MvcStok.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis
        MvcDbstokEntities1 db = new MvcDbstokEntities1();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult YeniSatis()
        {

            return View();
        }
        [HttpPost]
        public ActionResult YeniSatis(TBLSATISLAR p)
        {
            db.TBLSATISLAR.Add(p);
            db.SaveChanges();
            return View("Index");
        }
    }
}