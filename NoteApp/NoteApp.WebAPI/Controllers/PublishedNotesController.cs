using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NoteApp.Business.Abstract;
using NoteApp.Data.Abstract;
using NoteApp.WebAPI.DTO;

namespace NoteApp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublishedNotesController : ControllerBase
    {
        private INoteRepository _noteRepository;
        public PublishedNotesController(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetNotes()
        {
            var notes = await _noteRepository.GetPublishedNotes();

            var notesDTO = new List<NoteDTO>();

            foreach (var n in notes)
            {
                notesDTO.Add(new NoteDTO
                {
                    NoteId = n.NoteId,
                    Name = n.Name,
                    ImgUrl = n.ImgUrl,
                    Username = n.Username,
                    UserId = n.UserId
                });
            }

            return Ok(notesDTO);
        }
    }
}