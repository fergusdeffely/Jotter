using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jotter
{
    public partial class MainForm : Form
    {
        List<Note> notesList = null;

        public MainForm()
        {
            this.notesList = new List<Note>();

            InitializeComponent();
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            // Create a new note
            Note note = new Note(this.textBoxTitle.Text, this.textBoxNote.Text);

            // Add the note to the existing list of notes
            this.notesList.Add(note);

            // Tell the user 
            MessageBox.Show($"Added note : {note.Title}", "Note added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Update the UI:

            // Label
            this.labelYouHavenNotes.Text = $"You have {this.notesList.Count} notes.";
            
            // ListBox
            this.listBoxNotes.Items.Add(note);
        }
    }
}
