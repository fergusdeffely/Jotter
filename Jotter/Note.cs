using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotter
{
    class Note
    {
        string title;
        string notetext;

        public Note(string title, string notetext)
        {
            this.title = title;
            this.notetext = notetext;
        }

        public string Title { get => title; set => title = value; }
        public string NoteText { get => notetext; set => notetext = value; }

        public override string ToString()
        {
            return this.title;
        }
    }
}
