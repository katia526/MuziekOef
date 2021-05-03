
namespace MuziekOef
{
    partial class Form5
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
            this.cbArtiest = new System.Windows.Forms.ComboBox();
            this.cbAlbum = new System.Windows.Forms.ComboBox();
            this.Artiest = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Song = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnBewaar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLengte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbArtiest
            // 
            this.cbArtiest.FormattingEnabled = true;
            this.cbArtiest.Location = new System.Drawing.Point(62, 52);
            this.cbArtiest.Name = "cbArtiest";
            this.cbArtiest.Size = new System.Drawing.Size(121, 21);
            this.cbArtiest.TabIndex = 0;
            this.cbArtiest.SelectedIndexChanged += new System.EventHandler(this.cbArtiest_SelectedIndexChanged);
            // 
            // cbAlbum
            // 
            this.cbAlbum.FormattingEnabled = true;
            this.cbAlbum.Location = new System.Drawing.Point(279, 52);
            this.cbAlbum.Name = "cbAlbum";
            this.cbAlbum.Size = new System.Drawing.Size(121, 21);
            this.cbAlbum.TabIndex = 1;
            // 
            // Artiest
            // 
            this.Artiest.AutoSize = true;
            this.Artiest.Location = new System.Drawing.Point(62, 33);
            this.Artiest.Name = "Artiest";
            this.Artiest.Size = new System.Drawing.Size(36, 13);
            this.Artiest.TabIndex = 2;
            this.Artiest.Text = "Artiest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Album";
            // 
            // Song
            // 
            this.Song.AutoSize = true;
            this.Song.Location = new System.Drawing.Point(65, 201);
            this.Song.Name = "Song";
            this.Song.Size = new System.Drawing.Size(32, 13);
            this.Song.TabIndex = 4;
            this.Song.Text = "Song";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(141, 198);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // btnBewaar
            // 
            this.btnBewaar.Location = new System.Drawing.Point(68, 280);
            this.btnBewaar.Name = "btnBewaar";
            this.btnBewaar.Size = new System.Drawing.Size(75, 23);
            this.btnBewaar.TabIndex = 6;
            this.btnBewaar.Text = "Bewaar";
            this.btnBewaar.UseVisualStyleBackColor = true;
            this.btnBewaar.Click += new System.EventHandler(this.btnBewaar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lengte";
            // 
            // txtLengte
            // 
            this.txtLengte.Location = new System.Drawing.Point(141, 235);
            this.txtLengte.Name = "txtLengte";
            this.txtLengte.Size = new System.Drawing.Size(100, 20);
            this.txtLengte.TabIndex = 8;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLengte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBewaar);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.Song);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Artiest);
            this.Controls.Add(this.cbAlbum);
            this.Controls.Add(this.cbArtiest);
            this.Name = "Form5";
            this.Text = "Voeg Songs toe";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbArtiest;
        private System.Windows.Forms.ComboBox cbAlbum;
        private System.Windows.Forms.Label Artiest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Song;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnBewaar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLengte;
    }
}