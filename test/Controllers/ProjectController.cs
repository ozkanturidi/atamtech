using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;


namespace test.Controllers
{
    public class ProjectController : Controller
    {
        TableList lng = new TableList();
        Context c = new Context();
        [Route("ProjectList")]
        public ActionResult ProjectList()
        {
            //var projects = c.Projects.ToList();
            lng.projectTr = c.Projects.Where(x => x.language == true);
            lng.projectEn = c.Projects.Where(x => x.language == false);
            lng.serviceTr = c.Services.Where(x => x.language == true).ToList();
            lng.serviceEn = c.Services.Where(x => x.language == false).ToList();
            lng.productTr = c.Products.Where(x => x.language == true).ToList();
            lng.productEn = c.Products.Where(x => x.language == false).ToList();


            return View(lng);
        }

        public ActionResult ProjectDetails(int id)
        {

            var projects = c.Projects.Where(x => x.id == id).ToList();
            return View(projects);


        }


    }
}