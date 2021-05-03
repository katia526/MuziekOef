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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MuziekContext ctx = new MuziekContext())
            {
                var result = ctx.Users.FirstOrDefault(c => c.Email == txtUserNaam.Text && c.Password == txtPass.Text);
               
                if (result != null)
                {
                    // var klant = ctx.Users.
                    var klant = result.FirstName + " " + result.LastName;
                    var klantID = result.UserId;
                    Form2 form2 = new Form2(klant, klantID);
                  //  Form2.SetTextboxText(klant);
                    form2.Show();
                }
                else
                {
                    CreateUser();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

           this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateUser();
        }
        public void CreateUser()
        {
            using(MuziekContext ctx = new MuziekContext())
            {
                txtNaam.Enabled = true;
                txtVoornaam.Enabled = true;
                ctx.Users.Add(new User()
                {
                    Email = txtUserNaam.Text,
                    Password = txtPass.Text,
                    FirstName = txtVoornaam.Text,
                    LastName = txtNaam.Text
                });
                ctx.SaveChanges();
                txtNaam.Text = " ";
                txtPass.Text = " ";
                txtUserNaam.Text = " ";
                txtVoornaam.Text = " ";
            }
        }
    }
    
}
