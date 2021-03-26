using ElevenNote.Models;
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
            var model = new NoteListItem[0];
            return View(model);
        }


        // Get: Create Note
        // Note/Create
        public ActionResult Create()
        {
            return View();
        }

        // Post: Create Note
        // Note/Create

        public ActionResult Create(NoteCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}