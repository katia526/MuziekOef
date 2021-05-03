using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MuziekOef.Program;

namespace MuziekOef
{
    public partial class Form2 : Form
    {
        public Form2(string klant, int klantID)
        {
            InitializeComponent();
            txtWelkom.Text = klant;
            txtKlantId.Text = klantID.ToString();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
          //  setTextboxText();
            using (MuziekContext ctx = new MuziekContext())
            {
                //var dag = ctx.Users.Select(c => c.Email == Form1.txtUserNaam.Text);
              //  txtWelkom.Text = ctx.Users.FirstOrDefault(c => c.FirstName);
                    }
        }

       public void txtWelkom_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void btnSongs_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(txtWelkom.Text, txtKlantId.Text);
            form5.Show();
        }
        //static void setTextboxText(string klant)
        //{
        //    txtWelkom.Text = klant;
        //}
    }
}
