
namespace Jotter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonAddSaveNote = new System.Windows.Forms.Button();
            this.labelNote = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.labelYouHavenNotes = new System.Windows.Forms.Label();
            this.labelYourNotes = new System.Windows.Forms.Label();
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 63);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(35, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title :";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(53, 60);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(195, 23);
            this.textBoxTitle.TabIndex = 1;
            // 
            // buttonAddSaveNote
            // 
            this.buttonAddSaveNote.Location = new System.Drawing.Point(53, 305);
            this.buttonAddSaveNote.Name = "buttonAddSaveNote";
            this.buttonAddSaveNote.Size = new System.Drawing.Size(102, 31);
            this.buttonAddSaveNote.TabIndex = 3;
            this.buttonAddSaveNote.Text = "Add Note";
            this.buttonAddSaveNote.UseVisualStyleBackColor = true;
            this.buttonAddSaveNote.Click += new System.EventHandler(this.buttonAddNote_Click);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(8, 105);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(39, 15);
            this.labelNote.TabIndex = 4;
            this.labelNote.Text = "Note :";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(53, 102);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(297, 197);
            this.textBoxNote.TabIndex = 2;
            // 
            // labelYouHavenNotes
            // 
            this.labelYouHavenNotes.AutoSize = true;
            this.labelYouHavenNotes.Location = new System.Drawing.Point(53, 23);
            this.labelYouHavenNotes.Name = "labelYouHavenNotes";
            this.labelYouHavenNotes.Size = new System.Drawing.Size(96, 15);
            this.labelYouHavenNotes.TabIndex = 6;
            this.labelYouHavenNotes.Text = "You have 0 notes";
            // 
            // labelYourNotes
            // 
            this.labelYourNotes.AutoSize = true;
            this.labelYourNotes.Location = new System.Drawing.Point(395, 23);
            this.labelYourNotes.Name = "labelYourNotes";
            this.labelYourNotes.Size = new System.Drawing.Size(71, 15);
            this.labelYourNotes.TabIndex = 7;
            this.labelYourNotes.Text = "Your Notes :";
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.ItemHeight = 15;
            this.listBoxNotes.Items.AddRange(new object[] {
            "Note 1",
            "Note 2",
            "Note 3",
            "Note 4"});
            this.listBoxNotes.Location = new System.Drawing.Point(395, 57);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(344, 244);
            this.listBoxNotes.TabIndex = 4;
            this.listBoxNotes.SelectedIndexChanged += new System.EventHandler(this.listBoxNotes_SelectedIndexChanged);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(174, 305);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(102, 31);
            this.buttonNew.TabIndex = 8;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.listBoxNotes);
            this.Controls.Add(this.labelYourNotes);
            this.Controls.Add(this.labelYouHavenNotes);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.buttonAddSaveNote);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "MainForm";
            this.Text = "Jotter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonAddSaveNote;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Label labelYouHavenNotes;
        private System.Windows.Forms.Label labelYourNotes;
        private System.Windows.Forms.ListBox listBoxNotes;
        private System.Windows.Forms.Button buttonNew;
    }
}

