
namespace MuziekOef
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.Naam = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn1Nieuw = new System.Windows.Forms.Button();
            this.txtKlantId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaylist = new System.Windows.Forms.TextBox();
            this.lstPlaylist = new System.Windows.Forms.ListBox();
            this.cbPlaylist = new System.Windows.Forms.ComboBox();
            this.btnSongToevoegen = new System.Windows.Forms.Button();
            this.lvwSongs = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(131, 140);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 20);
            this.txtNaam.TabIndex = 0;
            // 
            // Naam
            // 
            this.Naam.AutoSize = true;
            this.Naam.Location = new System.Drawing.Point(38, 146);
            this.Naam.Name = "Naam";
            this.Naam.Size = new System.Drawing.Size(35, 13);
            this.Naam.TabIndex = 1;
            this.Naam.Text = "Naam";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bestaande playlist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn1Nieuw
            // 
            this.btn1Nieuw.Location = new System.Drawing.Point(254, 247);
            this.btn1Nieuw.Name = "btn1Nieuw";
            this.btn1Nieuw.Size = new System.Drawing.Size(174, 23);
            this.btn1Nieuw.TabIndex = 3;
            this.btn1Nieuw.Text = "Nieuwe playlist";
            this.btn1Nieuw.UseVisualStyleBackColor = true;
            this.btn1Nieuw.Click += new System.EventHandler(this.btn1Nieuw_Click);
            // 
            // txtKlantId
            // 
            this.txtKlantId.Location = new System.Drawing.Point(270, 139);
            this.txtKlantId.Name = "txtKlantId";
            this.txtKlantId.Size = new System.Drawing.Size(100, 20);
            this.txtKlantId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Playlist naam";
            // 
            // txtPlaylist
            // 
            this.txtPlaylist.Location = new System.Drawing.Point(131, 192);
            this.txtPlaylist.Name = "txtPlaylist";
            this.txtPlaylist.Size = new System.Drawing.Size(100, 20);
            this.txtPlaylist.TabIndex = 6;
            // 
            // lstPlaylist
            // 
            this.lstPlaylist.FormattingEnabled = true;
            this.lstPlaylist.Location = new System.Drawing.Point(568, 116);
            this.lstPlaylist.Name = "lstPlaylist";
            this.lstPlaylist.Size = new System.Drawing.Size(120, 160);
            this.lstPlaylist.TabIndex = 7;
            this.lstPlaylist.SelectedIndexChanged += new System.EventHandler(this.lstPlaylist_SelectedIndexChanged);
            // 
            // cbPlaylist
            // 
            this.cbPlaylist.FormattingEnabled = true;
            this.cbPlaylist.Location = new System.Drawing.Point(402, 56);
            this.cbPlaylist.Name = "cbPlaylist";
            this.cbPlaylist.Size = new System.Drawing.Size(121, 21);
            this.cbPlaylist.TabIndex = 8;
            this.cbPlaylist.SelectedIndexChanged += new System.EventHandler(this.cbPlaylist_SelectedIndexChanged);
            // 
            // btnSongToevoegen
            // 
            this.btnSongToevoegen.Location = new System.Drawing.Point(60, 332);
            this.btnSongToevoegen.Name = "btnSongToevoegen";
            this.btnSongToevoegen.Size = new System.Drawing.Size(294, 23);
            this.btnSongToevoegen.TabIndex = 9;
            this.btnSongToevoegen.Text = "Song toevoegen aan playlist";
            this.btnSongToevoegen.UseVisualStyleBackColor = true;
            this.btnSongToevoegen.Click += new System.EventHandler(this.button2_Click);
            // 
            // lvwSongs
            // 
            this.lvwSongs.HideSelection = false;
            this.lvwSongs.Location = new System.Drawing.Point(453, 315);
            this.lvwSongs.Name = "lvwSongs";
            this.lvwSongs.Size = new System.Drawing.Size(121, 97);
            this.lvwSongs.TabIndex = 10;
            this.lvwSongs.UseCompatibleStateImageBehavior = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvwSongs);
            this.Controls.Add(this.btnSongToevoegen);
            this.Controls.Add(this.cbPlaylist);
            this.Controls.Add(this.lstPlaylist);
            this.Controls.Add(this.txtPlaylist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKlantId);
            this.Controls.Add(this.btn1Nieuw);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Naam);
            this.Controls.Add(this.txtNaam);
            this.Name = "Form6";
            this.Text = "Maak een playlist";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label Naam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn1Nieuw;
        private System.Windows.Forms.TextBox txtKlantId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaylist;
        private System.Windows.Forms.ListBox lstPlaylist;
        private System.Windows.Forms.ComboBox cbPlaylist;
        private System.Windows.Forms.Button btnSongToevoegen;
        private System.Windows.Forms.ListView lvwSongs;
    }
}