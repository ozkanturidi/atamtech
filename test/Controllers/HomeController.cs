using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using test.Models;
using System.Globalization;
using System.Threading;

namespace test.Controllers
{
    

    public class HomeController : Controller
    {
        string lang;
        public ActionResult ChangeLanguage(string selectedlanguage)
        {


            if(selectedlanguage != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(selectedlanguage);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(selectedlanguage);
                var cookie = new HttpCookie("Language");
                cookie.Value = selectedlanguage;
                Response.Cookies.Add(cookie);
                lang = selectedlanguage;
            }
            return RedirectToAction("Index", "Home");

        }





        TableList lng = new TableList();

        Context c = new Context();

        ProductandNew pn = new ProductandNew();
        [Route("Home")]
        [Route("")]
        public ActionResult Index()

        {

            
           pn.NewSlidTr = c.News.Where(x=> x.language == true).OrderByDescending(x => x.id).Take(4).ToList();
           pn.NewSlidEn = c.News.Where(x=> x.language == false).OrderByDescending(x => x.id).Take(4).ToList();
           pn.PrdcardTr = c.Products.Where(x=>x.language==true).ToList();
           pn.PrdcardEn = c.Products.Where(x => x.language == false).ToList();
           pn.serviceTr = c.Services.Where(x => x.language == true).ToList();
           pn.serviceEn = c.Services.Where(x => x.language == false).ToList();
            


                 
            return View(pn);
        }
        [Route("About")]
        [Route("Home/About")]
        public ActionResult About()
        {

            lng.aboutTr = c.AboutUss.Where(x => x.language == true);
            lng.aboutEn = c.AboutUss.Where(x => x.language == false);
            lng.productTr = c.Products.Where(x => x.language == true).ToList();
            lng.productEn= c.Products.Where(x => x.language == false).ToList();
            lng.serviceTr = c.Services.Where(x => x.language == true).ToList();
            lng.serviceEn = c.Services.Where(x => x.language == false).ToList();
            //var about = c.AboutUss.ToList();

            return View(lng);
        }
        [HttpGet]
        [Route("Contact")]
        public ActionResult Contact()
        {
            

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(Contact cont)
        {
            c.Contacts.Add(cont);
            c.SaveChanges();
            lng.productTr = c.Products.Where(x => x.language == true).ToList();
            lng.productEn = c.Products.Where(x => x.language == false).ToList();
            lng.serviceTr = c.Services.Where(x => x.language == true).ToList();
            lng.serviceEn = c.Services.Where(x => x.language == false).ToList();
            /*var name = Request["mail"];
            Email(name);*/


            return View(lng);
        }


      /*  public static void Email(string htmlString)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("FromMailAddress");
                message.To.Add(new MailAddress("ToMailAddress"));
                message.Subject = "Test";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("FromMailAddress", "password");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception) { }
        }

    */
    }
}