
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
            // 
            // txtKlantId
            // 
            this.txtKlantId.Location = new System.Drawing.Point(270, 139);
            this.txtKlantId.Name = "txtKlantId";
            this.txtKlantId.Size = new System.Drawing.Size(100, 20);
            this.txtKlantId.TabIndex = 4;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKlantId);
            this.Controls.Add(this.btn1Nieuw);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Naam);
            this.Controls.Add(this.txtNaam);
            this.Name = "Form6";
            this.Text = "Maak een playlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label Naam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn1Nieuw;
        private System.Windows.Forms.TextBox txtKlantId;
    }
}