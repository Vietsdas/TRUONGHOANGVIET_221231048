using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThvLesson07Annotation.Models;

namespace ThvLesson07Annotation.Controllers
{
    public class ThvMembersController : Controller
    {
        private static List<ThvMember> thvMembers = new List<ThvMember>();

        // GET: ThvMembersController
        public ActionResult Index()
        {
            return View(thvMembers);
        }

        // GET: ThvMembersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ThvMembersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThvMembersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ThvMember thvMember)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(thvMember);
                }
                thvMembers.Add(thvMember);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ThvMembersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ThvMembersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ThvMembersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ThvMembersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
