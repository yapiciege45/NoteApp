using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteApp.Business.Abstract;
using NoteApp.Data.Abstract;
using NoteApp.Data.Concrete.EfCore;
using NoteApp.Entity;

namespace NoteApp.Business.Concrete
{
    public class NoteManager : INoteService
    {
        private INoteRepository _noteRepository;
        public NoteManager(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public void Create(Note entity)
        {
            _noteRepository.Create(entity);
        }

        public void Delete(Note entity)
        {
            _noteRepository.Delete(entity);
        }

        public List<Note> GetAll()
        {
            return _noteRepository.GetAll();
        }

        public Note GetById(int id)
        {
            return _noteRepository.GetById(id);
        }

        public List<Note> GetByUserId(string id)
        {
            return _noteRepository.GetByUserId(id);
        }

        public Task<List<Note>> GetPublishedNotes()
        {
            return _noteRepository.GetPublishedNotes();
        }

        public void Update(Note entity)
        {
            _noteRepository.Update(entity);
        }
    }
}