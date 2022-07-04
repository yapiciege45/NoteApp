using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteApp.WebAPI.DTO
{
    public class NoteDTO
    {
        public int NoteId { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string Username { get; set; }
        public string UserId { get; set; }
    }
}