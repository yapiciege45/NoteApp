using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NoteApp.Data;
using NoteApp.Data.Abstract;
using NoteApp.Data.Concrete.EfCore;
using NoteApp.Entity;
using NoteApp.WebUI.Data;

namespace NoteApp.Controllers
{
    public class NoteController : Controller
    {
        public IActionResult Index(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            EfCoreNoteRepository noterepository = new EfCoreNoteRepository();
            if (noterepository.GetById(id).UserId == userId)
            {
                return View(noterepository.GetById(id));
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Index(Note model)
        {
            EfCoreNoteRepository noterepository = new EfCoreNoteRepository();

            Note currentNote = noterepository.GetById(model.NoteId);

            Note updatedNote = new Note
            {
                NoteId = currentNote.NoteId,
                Name = model.Name,
                Description = model.Description,
                ImgUrl = model.ImgUrl,
                Published = currentNote.Published,
                Username = currentNote.Username,
                UserId = currentNote.UserId
            };

            noterepository.Update(updatedNote);

            return RedirectToAction("Index", "Home");
        }

    }
}