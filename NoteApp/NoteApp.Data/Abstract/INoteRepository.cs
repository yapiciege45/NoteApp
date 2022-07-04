using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteApp.Entity;

namespace NoteApp.Data.Abstract
{
    public interface INoteRepository : IRepository<Note>
    {
        List<Note> GetByUserId(string id);
        Task<List<Note>> GetPublishedNotes();
        void DoPublish(int NoteId);
    }
}