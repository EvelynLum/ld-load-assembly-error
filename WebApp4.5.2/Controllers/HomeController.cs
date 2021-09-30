using System.Web.Mvc;
using WebApp4._5._2.App_Start;

namespace WebApp4._5._2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var test = LDClient.Instance.BoolVariation("p-killswitch", LaunchDarkly.Sdk.User.Builder($"P-User-1")
                        .Name($"Prototype User 1")
                        .Email($"p-user1@gmail.com")
                        .Custom("State", "Kuala Lumpur")
                        .Build());

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}