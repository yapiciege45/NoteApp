using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteApp.Entity
{
    public class Note
    {
        public int NoteId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public bool Published { get; set; }
        public string Username { get; set; }
        public string UserId { get; set; }
    }
}