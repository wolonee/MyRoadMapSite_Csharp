﻿using itProgerWebSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace itProgerWebSite.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }

            return View("Index");
        }

    }
}
