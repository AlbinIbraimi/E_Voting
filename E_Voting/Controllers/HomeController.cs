using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Voting.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Da se izlistaat site Kandidati od baza 
            // Da se kreira kontorller za dodoavanje na kandidati vo baza.
            return View();
        }
    }
}