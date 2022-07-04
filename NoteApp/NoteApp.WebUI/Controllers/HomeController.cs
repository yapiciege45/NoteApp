using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NoteApp.Data.Abstract;
using NoteApp.Data.Concrete;
using NoteApp.Data.Concrete.EfCore;
using NoteApp.Entity;
using NoteApp.WebUI.Data;
using Newtonsoft.Json;

namespace NoteApp.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Note n)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = User.Identity.Name;
            var noterepository = new EfCoreNoteRepository();
            Note newnote = new Note
            {
                NoteId = n.NoteId,
                Name = n.Name,
                Description = n.Description,
                ImgUrl = n.ImgUrl,
                Username = userName,
                UserId = userId
            };
            noterepository.Create(newnote);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int NoteId)
        {
            var noterepository = new EfCoreNoteRepository();
            noterepository.Delete(noterepository.GetById(NoteId));
            return RedirectToAction("Index");
        }

        public IActionResult Publish(int id)
        {
            var noterepository = new EfCoreNoteRepository();
            noterepository.DoPublish(id);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Media()
        {
            var notes = new List<Note>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:4200/api/publishednotes"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    notes = JsonConvert.DeserializeObject<List<Note>>(apiResponse);
                }
            }

            return View(notes);
        }
    }
}