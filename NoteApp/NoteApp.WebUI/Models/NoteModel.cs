using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteApp.WebUI.Models
{
    public class NoteModel
    {
        public int NoteId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public string UserId { get; set; }
    }
}