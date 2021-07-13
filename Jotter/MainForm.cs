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

            UpdateControls(true);
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            Note note = new Note(this.textBoxTitle.Text, this.textBoxNote.Text);
            this.notesList.Add(note);

            UpdateControls(true);

            MessageBox.Show($"Added note : {note.Title}", "Note added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Note selectedNote = (Note)this.listBoxNotes.SelectedItem;
        }

        private void UpdateControls(bool editing)
        {
            if(editing)
            {
                this.buttonNew.Visible = true;
                this.buttonAddSaveNote.Text = "Save";
            }
            else
            {
                this.buttonNew.Visible = false;
                this.buttonAddSaveNote.Text = "Add";
            }

            this.labelYouHavenNotes.Text = $"You have {this.notesList.Count} notes"; 
        }
    }
}
