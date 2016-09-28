using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PerJson.PerService;
using System.Web.Script.Serialization;


namespace PerJson.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            JavaScriptSerializer jser = new JavaScriptSerializer();
            System.String str;
            Person pp;
            PersonServiceClient ps = new PersonServiceClient();
            LookupParameters lookup = new LookupParameters();
            lookup.NIN = "01090097365";
            ps.ClientCredentials.UserName.UserName = "test";
            ps.ClientCredentials.UserName.Password = "BF32511";
            pp = ps.GetPerson(lookup);

            str = jser.Serialize(pp);
            
            return View();
        }

        public ActionResult About()
        {

            ViewBag.Message = "Din beskr her.";
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}