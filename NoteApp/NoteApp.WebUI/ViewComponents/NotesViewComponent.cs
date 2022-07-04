using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NoteApp.Business.Abstract;
using NoteApp.Data;
using NoteApp.Data.Abstract;
using NoteApp.Entity;
using NoteApp.WebUI.Models;

namespace NoteApp.ViewComponents
{
    public class NotesViewComponent : ViewComponent
    {
        private INoteService _noteService;

        public NotesViewComponent(INoteService noteService)
        {
            this._noteService = noteService;
        }
        public IViewComponentResult Invoke()
        {
            var userId = UserClaimsPrincipal.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(_noteService.GetByUserId(userId));
        }
    }
}