using alexdodd.net.Models;
using alexdodd.net.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace alexdodd.net.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            var uniqueEmail = TempData["UniqueEmail"];

            // if the email is unique, return an empty view (no sign up form)
            if (uniqueEmail != null)
            {
                return View();
            }

            return View("SignUp", new EmailSignUp());
        }

        public ActionResult SignUpNotification()
        {
            var signUpNotification = new SignUpNotification();
            var nonUniqueEmail = TempData["NonUniqueEmail"];
            var uniqueEmail = TempData["UniqueEmail"];

            if (nonUniqueEmail != null)
            {
                signUpNotification.NonUniqueEmail = nonUniqueEmail.ToString();
            }

            if (uniqueEmail != null)
            {
                signUpNotification.UniqueEmail = uniqueEmail.ToString();
            }

            return View("SignUpNotification", signUpNotification);
        }

        // POST: EmailSignUps/SignUp
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp([Bind(Include = "ID,Email")] EmailSignUp emailSignUp)
        {
            if (ModelState.IsValid)
            {
                var email = emailSignUp.Email;
                var isNotUnique = db.EmailSignUps.Any(esu => esu.Email == email);

                if (isNotUnique)
                {
                    TempData["NonUniqueEmail"] = email;

                    return RedirectToAction("Index");
                }

                db.EmailSignUps.Add(emailSignUp);
                db.SaveChanges();

                TempData["UniqueEmail"] = email;

                return RedirectToAction("Index");
            }

            return View(emailSignUp);
        }

        //public ActionResult List()
        //{
        //    var emailSignUps = db.EmailSignUps;

        //    return View(emailSignUps);
        //}
    }
}