
namespace MuziekOef
{
    partial class Form2
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
            this.btnMaakLijst = new System.Windows.Forms.Button();
            this.txtWelkom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSongs = new System.Windows.Forms.Button();
            this.txtKlantId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMaakLijst
            // 
            this.btnMaakLijst.Location = new System.Drawing.Point(81, 277);
            this.btnMaakLijst.Name = "btnMaakLijst";
            this.btnMaakLijst.Size = new System.Drawing.Size(216, 23);
            this.btnMaakLijst.TabIndex = 0;
            this.btnMaakLijst.Text = "Maak PlayList";
            this.btnMaakLijst.UseVisualStyleBackColor = true;
            // 
            // txtWelkom
            // 
            this.txtWelkom.Location = new System.Drawing.Point(102, 37);
            this.txtWelkom.Name = "txtWelkom";
            this.txtWelkom.Size = new System.Drawing.Size(195, 20);
            this.txtWelkom.TabIndex = 1;
            this.txtWelkom.TextChanged += new System.EventHandler(this.txtWelkom_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Voeg artiest toe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(81, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Voeg Album toe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSongs
            // 
            this.btnSongs.Location = new System.Drawing.Point(81, 192);
            this.btnSongs.Name = "btnSongs";
            this.btnSongs.Size = new System.Drawing.Size(216, 23);
            this.btnSongs.TabIndex = 4;
            this.btnSongs.Text = "Voeg Songs toe";
            this.btnSongs.UseVisualStyleBackColor = true;
            this.btnSongs.Click += new System.EventHandler(this.btnSongs_Click);
            // 
            // txtKlantId
            // 
            this.txtKlantId.Location = new System.Drawing.Point(338, 37);
            this.txtKlantId.Name = "txtKlantId";
            this.txtKlantId.Size = new System.Drawing.Size(195, 20);
            this.txtKlantId.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKlantId);
            this.Controls.Add(this.btnSongs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtWelkom);
            this.Controls.Add(this.btnMaakLijst);
            this.Name = "Form2";
            this.Text = "Muziek App";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaakLijst;
        private System.Windows.Forms.TextBox txtWelkom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSongs;
        private System.Windows.Forms.TextBox txtKlantId;
    }
}