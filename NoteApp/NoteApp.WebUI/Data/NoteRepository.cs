using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteApp.Entity;

namespace NoteApp.WebUI.Data
{
    public class NoteRepository
    {
        private static List<Note> _notes = null;

        static NoteRepository()
        {
            _notes = new List<Note>
            {

            };
        }

        public static List<Note> Notes
        {
            get
            {
                return _notes;
            }
        }
        public static void AddNote(Note note)
        {
            _notes.Add(note);
        }

        public static Note GetNoteById(int id)
        {
            return _notes.FirstOrDefault(n => n.NoteId == id);
        }

        public static void DeleteNote(int id)
        {
            var note = GetNoteById(id);
            if (note != null)
            {
                _notes.Remove(note);
            }
        }
    }
}