using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {

        public ActionResult ChangeLanguage(string selectedlanguage)
        {


            if (selectedlanguage != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(selectedlanguage);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(selectedlanguage);
                var cookie = new HttpCookie("Language");
                cookie.Value = selectedlanguage;
                Response.Cookies.Add(cookie);
            }
            return RedirectToAction("Index", "Admin");
        }

        TableList lng = new TableList();
        Context c = new Context();

        // GET: Admin



        //News Admin Page



        public ActionResult Index()
        {

            lng.newsTr = c.News.Where(x => x.language == true);
           lng.newsEn = c.News.Where(x => x.language == false);
            //var values = c.News.ToList();
            return View(lng);
        }




        //Product Admin Page

        public ActionResult Product()
        {
            lng.productTr = c.Products.Where(x => x.language == true);
            lng.productEn = c.Products.Where(x => x.language == false);
            //var values = c.Products.ToList();
            return View(lng);
        }


        
        //Service Admin Page

        public ActionResult Service()
        {
            lng.serviceTr = c.Services.Where(x => x.language == true);
            lng.serviceEn = c.Services.Where(x => x.language == false);
            //var values = c.Services.ToList();
            return View(lng);
        }
        


        //Collaboration Admin Page

        public ActionResult Collaboration()
        {
           lng.collTr = c.Collaborations.Where(x => x.language == true);
           lng.collEn = c.Collaborations.Where(x => x.language == true);
            //var values = c.Collaborations.ToList();
            return View(lng);
        }



         //Project Admin Page

        public ActionResult Project()
        {
           lng.projectTr = c.Projects.Where(x => x.language == true);
           lng.projectEn = c.Projects.Where(x => x.language == false);
            //var values = c.Projects.ToList();
            return View(lng);
        }

        public ActionResult Contact()
        {
            
            var values = c.Contacts.ToList();
            return View(values);
        }


        public ActionResult About()
        {
            lng.aboutTr = c.AboutUss.Where(x => x.language == true);
            lng.aboutEn = c.AboutUss.Where(x => x.language == false);
            //var values = c.AboutUss.ToList();
            return View(lng);
        }

        //News Admin HTTP
        //*************************************************************
        [HttpGet]
        public ActionResult CreateNew()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateNew(New n)
        {
            c.News.Add(n);
            c.SaveChanges();

            return RedirectToAction("Index");
        }
        

        public ActionResult DeleteNew(int id)
        {
            var n = c.News.Find(id);
            c.News.Remove(n);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult bringNew(int id)
        {
          var n=  c.News.Find(id);

            return View("bringNew",n);
        }

        public ActionResult UpdateNew(New ne)
        {
            var n = c.News.Find(ne.id);
            n.title = ne.title;
            n.date = ne.date;
            n.content = ne.content;
            n.fotoUrl = ne.fotoUrl;
            c.SaveChanges();


            return RedirectToAction("Index");
        }



        //************************************************************


        //Product Admin HTTP


        [HttpGet]
        public ActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(Product p)
        {
            c.Products.Add(p);
            c.SaveChanges();

            return RedirectToAction("Product");
        }
        public ActionResult DeleteProduct(int id)
        {
            var p = c.Products.Find(id);
            c.Products.Remove(p);
            c.SaveChanges();

            return RedirectToAction("Product");
        }

        public ActionResult bringProduct(int id)
        {
            var p = c.Products.Find(id);

            return View("bringProduct", p);
        }

        public ActionResult UpdateProduct(Product prd)
        {
            var p = c.Products.Find(prd.id);

            
            

            //main content
            p.name = prd.name;
            p.title = prd.title;
            p.content = prd.content;
            p.photoUrl = prd.photoUrl;
            p.shortdef = prd.shortdef;

            //Operations

            p.Deploymenttime = prd.Deploymenttime;
            p.autonomousflight = prd.autonomousflight;
            p.landingmethod = prd.landingmethod;
            p.cruisespeed = prd.cruisespeed;
            p.tolerablewindspeed = prd.tolerablewindspeed;
            p.flighttime = prd.flighttime;
            p.flightdistance = prd.flightdistance;
            p.flightspeed = prd.flightspeed;
            p.flightaltitude = prd.flightaltitude;
            p.operatingtemp = prd.operatingtemp;
            p.weathercond = prd.weathercond;
            p.gcps = prd.gcps;

            // Hardware
            p.aircrafttype = prd.aircrafttype;
            p.wingspan = prd.wingspan;
            p.rotorsNum = prd.rotorsNum;
            p.takeoffweight = prd.takeoffweight;
            p.payloadweight = prd.payloadweight;
            p.telemetryrange = prd.telemetryrange;

            //Software
            p.controlmethod = prd.controlmethod;
            p.operatingsystem = prd.operatingsystem;
            p.photogrammetrysoftware = prd.photogrammetrysoftware;
            p.inputfiles = prd.inputfiles;
            p.updates = prd.updates;

            //Features
            p.dataloggingsystem = prd.dataloggingsystem;
            p.optionalmodules = prd.optionalmodules;
            p.variouspayloads = prd.variouspayloads;
            p.transportCase = prd.transportCase;




            c.SaveChanges();
            return RedirectToAction("Product");
        }

        //*************************************************************



  //Service Admin HTTP

        [HttpGet]
        public ActionResult CreateService()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateService(Service s)
        {
            c.Services.Add(s);
            c.SaveChanges();

            return RedirectToAction("Service");
        }


        public ActionResult DeleteService(int id)
        {
            var s = c.Services.Find(id);
            c.Services.Remove(s);
            c.SaveChanges();

            return RedirectToAction("Service");
        }

        

        public ActionResult bringService(int id)
        {
            var s = c.Services.Find(id);

            return View("bringService", s);
        }

        public ActionResult UpdateService(Service serv)
        {
            var s = c.Services.Find(serv.id);
            s.title = serv.title;      
            s.content = serv.content;
            s.photoUrl = serv.photoUrl;
            c.SaveChanges();


            return RedirectToAction("Service");
        }
        //*************************************************************
 //Coll Admin HTTP

        [HttpGet]
        public ActionResult CreateColl()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateColl(Collaboration col)
        {
            c.Collaborations.Add(col);
            c.SaveChanges();

            return RedirectToAction("Collaboration");
        }


        public ActionResult DeleteColl(int id)
        {
            var col = c.Collaborations.Find(id);
            c.Collaborations.Remove(col);
            c.SaveChanges();

            return RedirectToAction("Collaboration");
        }

        public ActionResult bringColl(int id)
        {
            var col = c.Collaborations.Find(id);

            return View("bringColl", col);
        }

        public ActionResult UpdateColl(Collaboration colla)
        {
            var col = c.Collaborations.Find(colla.id);
            col.title = colla.title;
            col.content = colla.content;
            col.photoUrl = colla.photoUrl;
            c.SaveChanges();


            return RedirectToAction("Collaboration");
        }
        //*************************************************************
 //Project Admin HTTP

        [HttpGet]
        public ActionResult CreateProject()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateProject(Project p)
        {
            c.Projects.Add(p);
            c.SaveChanges();

            return RedirectToAction("Project");
        }


        public ActionResult DeleteProject(int id)
        {
            var p = c.Projects.Find(id);
            c.Projects.Remove(p);
            c.SaveChanges();

            return RedirectToAction("Project");
        }

        public ActionResult bringProject(int id)
        {
            var p = c.Projects.Find(id);

            return View("bringProject", p);
        }

        public ActionResult UpdateProject(Project pro)
        {
            var p = c.Projects.Find(pro.id);
            p.title = pro.title;
            p.content = pro.content;
            p.photoUrl = pro.photoUrl;
            c.SaveChanges();


            return RedirectToAction("Project");
        }
        //*************************************************************

        public ActionResult bringAbout(int id)
        {
            var p = c.AboutUss.Find(id);

            return View("bringAbout", p);
        }
        public ActionResult UpdateAbout(AboutUs about)
        {
            var p = c.AboutUss.Find(about.id);
            p.aboutUs = about.aboutUs;
            c.SaveChanges();


            return RedirectToAction("Project");
        }


    }
}