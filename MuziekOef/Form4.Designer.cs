
namespace MuziekOef
{
    partial class Form4
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
            this.btnBewaar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.cbArtiest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstAlbum = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBewaar
            // 
            this.btnBewaar.Location = new System.Drawing.Point(194, 262);
            this.btnBewaar.Name = "btnBewaar";
            this.btnBewaar.Size = new System.Drawing.Size(75, 23);
            this.btnBewaar.TabIndex = 0;
            this.btnBewaar.Text = "Bewaar";
            this.btnBewaar.UseVisualStyleBackColor = true;
            this.btnBewaar.Click += new System.EventHandler(this.btnBewaar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kies de artiest";
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(194, 126);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(121, 20);
            this.txtAlbum.TabIndex = 2;
            // 
            // cbArtiest
            // 
            this.cbArtiest.FormattingEnabled = true;
            this.cbArtiest.Location = new System.Drawing.Point(194, 53);
            this.cbArtiest.Name = "cbArtiest";
            this.cbArtiest.Size = new System.Drawing.Size(121, 21);
            this.cbArtiest.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naam Album";
            // 
            // lstAlbum
            // 
            this.lstAlbum.FormattingEnabled = true;
            this.lstAlbum.Location = new System.Drawing.Point(493, 42);
            this.lstAlbum.Name = "lstAlbum";
            this.lstAlbum.Size = new System.Drawing.Size(175, 186);
            this.lstAlbum.TabIndex = 5;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstAlbum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbArtiest);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBewaar);
            this.Name = "Form4";
            this.Text = "Voeg een album toe";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBewaar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.ComboBox cbArtiest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstAlbum;
    }
}