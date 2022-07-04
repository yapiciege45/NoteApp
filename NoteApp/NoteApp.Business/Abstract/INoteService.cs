using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteApp.Entity;

namespace NoteApp.Business.Abstract
{
    public interface INoteService
    {
        Note GetById(int id);

        List<Note> GetAll();

        List<Note> GetByUserId(string id);

        Task<List<Note>> GetPublishedNotes();

        void Create(Note entity);

        void Update(Note entity);

        void Delete(Note entity);
    }
}