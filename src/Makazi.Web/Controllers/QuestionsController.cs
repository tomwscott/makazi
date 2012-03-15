using System.Web.Mvc;

namespace Makazi.Web.Controllers
{
    public class QuestionsController : Controller
    {
        public ActionResult PersonalDetails()
        {
            return View();
        }

        public ActionResult Preferences()
        {
            return View();
        }

        public ActionResult Answers()
        {
            return Redirect("preferences");
        }
    }
}