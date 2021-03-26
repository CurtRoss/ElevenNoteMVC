using ElevenNote.Models;
using ElevenNote.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.WebMVC.Controllers
{
    public class NoteController : Controller
    {
        // GET: Note
        [Authorize]
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NoteService(userId);
            var model = service.GetNotes();
            return View(model);
        }


        // Get: Create Note
        // Note/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // Post: Create Note
        // Note/Create
        [HttpPost]
        public ActionResult Create(NoteCreate model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NoteService(userId);

            service.CreateNote(model);
            return RedirectToAction("Index");
        }
    }
}