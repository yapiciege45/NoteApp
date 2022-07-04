using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NoteApp.Data.Abstract;
using NoteApp.Entity;

namespace NoteApp.Data.Concrete.EfCore
{
    public class EfCoreNoteRepository : EfCoreGenericRepository<Note, NoteContext>, INoteRepository
    {
        public void DoPublish(int NoteId)
        {
            EfCoreNoteRepository noterepository = new EfCoreNoteRepository();

            Note currentNote = noterepository.GetById(NoteId);

            Note updatedNote = new Note
            {
                NoteId = currentNote.NoteId,
                Name = currentNote.Name,
                Description = currentNote.Description,
                ImgUrl = currentNote.ImgUrl,
                Published = !currentNote.Published,
                Username = currentNote.Username,
                UserId = currentNote.UserId
            };

            noterepository.Update(updatedNote);
        }

        public List<Note> GetByUserId(string id)
        {
            using (var context = new NoteContext())
            {
                return context.Set<Note>().Where(n => n.UserId == id).ToList();
            }
        }

        public async Task<List<Note>> GetPublishedNotes()
        {
            using (var context = new NoteContext())
            {
                return await context.Set<Note>().Where(n => n.Published).ToListAsync();
            }
        }
    }
}