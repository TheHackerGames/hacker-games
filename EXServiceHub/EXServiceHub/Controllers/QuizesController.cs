using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EXServiceHub.Controllers
{
    public class QuizesController : Controller
    {
        // GET: Quizes
        public ActionResult Index()
        {
            return View();
        }
    }
}