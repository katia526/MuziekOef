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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnBewaar_Click(object sender, EventArgs e)
        {
            using (MuziekContext ctx = new MuziekContext())
            {
                LoadList();
                var result = ctx.Artists.FirstOrDefault(c => c.Name == txtArtiest.Text);
                if (result != null)
                {
                    MessageBox.Show("artiest bestaat reeds");
                    txtArtiest.Text = " ";
                }
                else
                {
                    //var date1;
                    // DateTime dateOnly = DateTime.Now;
                    //var currentDateTime = DateTime.Now;
                    // var date = dateOnly.ToString("dd/MM/yyyy");
                    var date = DateTime.Now;
                    ctx.Artists.Add(new Artist()
                    {
                        Name = txtArtiest.Text,
                        CreatedAt = date.Date
                    }); 


                    ctx.SaveChanges();
                    txtArtiest.Text = " ";
                }
              
                LoadList();
            }
        }
        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            using (MuziekContext ctx = new MuziekContext())
            {
                ctx.Artists.Remove(ctx.Artists.FirstOrDefault(c => c.Name == txtArtiest.Text));
                LoadList();
            }
        }
        private void LoadList()
        {
            using (MuziekContext ctx = new MuziekContext())
            {

               
              var collection = ctx.Artists.Select(c => new { Id = c.ArtistId, Name = c.Name }).ToList();
                lstArtiest.DataSource = collection;
                lstArtiest.DisplayMember = "Name";
                lstArtiest.ValueMember = "Id";
               
            }
               
        }

        private void txtArtiest_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
