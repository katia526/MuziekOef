
namespace MuziekOef
{
    partial class Form3
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
            this.txtArtiest = new System.Windows.Forms.TextBox();
            this.btnBewaar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstArtiest = new System.Windows.Forms.ListBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtArtiest
            // 
            this.txtArtiest.Location = new System.Drawing.Point(187, 133);
            this.txtArtiest.Name = "txtArtiest";
            this.txtArtiest.Size = new System.Drawing.Size(100, 20);
            this.txtArtiest.TabIndex = 0;
            // 
            // btnBewaar
            // 
            this.btnBewaar.Location = new System.Drawing.Point(49, 285);
            this.btnBewaar.Name = "btnBewaar";
            this.btnBewaar.Size = new System.Drawing.Size(75, 23);
            this.btnBewaar.TabIndex = 1;
            this.btnBewaar.Text = "Bewaar";
            this.btnBewaar.UseVisualStyleBackColor = true;
            this.btnBewaar.Click += new System.EventHandler(this.btnBewaar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naam artiest";
            // 
            // lstArtiest
            // 
            this.lstArtiest.FormattingEnabled = true;
            this.lstArtiest.Location = new System.Drawing.Point(480, 56);
            this.lstArtiest.Name = "lstArtiest";
            this.lstArtiest.Size = new System.Drawing.Size(183, 264);
            this.lstArtiest.TabIndex = 3;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(187, 284);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijder.TabIndex = 4;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.lstArtiest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBewaar);
            this.Controls.Add(this.txtArtiest);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArtiest;
        private System.Windows.Forms.Button btnBewaar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstArtiest;
        private System.Windows.Forms.Button btnVerwijder;
    }
}