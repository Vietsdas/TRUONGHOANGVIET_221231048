using Microsoft.AspNetCore.Mvc;

namespace ThvLesson03.Controllers
{
    /// <summary>
    /// Name: ThvAbout
    /// Author: Việt Trương
    /// </summary>
    public class ThvAboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "Trương Hoàng Việt";
            ViewData["class"]="K65CNTT2-LTW";
            TempData["module"] = "Lập trình web 1 - 1";
            return View();
        }
    }
}
