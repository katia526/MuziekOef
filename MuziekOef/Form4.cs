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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            LoadList();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using (MuziekContext ctx = new MuziekContext())
            {
                var collection = ctx.Artists.Select(c => new { Id = c.ArtistId, Name = c.Name }).ToList();
                cbArtiest.DataSource = collection;
                cbArtiest.DisplayMember = "Name";
                cbArtiest.ValueMember = "Id";
            }
        }

        private void btnBewaar_Click(object sender, EventArgs e)
        {
            using (MuziekContext ctx = new MuziekContext())
            {

                var result = ctx.Albums.FirstOrDefault(c => c.Name == txtAlbum.Text);


                if (txtAlbum.Text == " ")
                {
                    MessageBox.Show("Geef het album in ");

                }
                else if (result != null)
                {
                    MessageBox.Show("Album bestaat reeds ");
                    txtAlbum.Text = " ";
                }
                else
                {
                   // cbArtiest
                    //int sel = cbArtiest.Get(cbArtiest.SelectedValue);
                    ctx.Albums.Add(new Album()
                    {
                       
                        A_ArtistId = Convert.ToInt32(cbArtiest.SelectedValue),
                        Name = txtAlbum.Text,

                    }); 
                    ctx.SaveChanges();
                    LoadList();
                }
            }
        }
        private void LoadList()
        {
            using (MuziekContext ctx = new MuziekContext())
            {

                var collection = ctx.Albums.Select(c => new { Id = c.AlbumId, Name = c.Name }).ToList();
                lstAlbum.DataSource = collection;
                lstAlbum.DisplayMember = "Name";
                lstAlbum.ValueMember = "Id";

            }

        }
    }
}
