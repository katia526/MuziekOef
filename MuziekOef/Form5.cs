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
    public partial class Form5 : Form
    {
        public Form5(string Klant, int klantId)
        {
            InitializeComponent();
            txtKlant.Text = Klant;
        }

        private void Form5_Load(object sender, EventArgs e)
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

              
                var result = ctx.Songs.FirstOrDefault(c => c.Title == txtTitle.Text);

                if (txtTitle.Text == " ")
                {
                    MessageBox.Show("Geef een song in ");

                }
                else if (result != null)
                {
                    MessageBox.Show("Song bestaat reeds ");
                    txtTitle.Text = " ";
                }
                else
                {
                    // cbArtiest
                    //int sel = cbArtiest.Get(cbArtiest.SelectedValue);
                    ctx.Songs.Add(new Song()
                    {

                        S_ArtistId = Convert.ToInt32(cbArtiest.SelectedValue),
                        S_AlbumId = Convert.ToInt32(cbAlbum.SelectedValue),
                       Title = txtTitle.Text,
                       Length = Convert.ToDouble(txtLengte.Text)
                    });
                    ctx.SaveChanges();
                   // LoadList();
                }
            }
        }

        private void cbArtiest_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (MuziekContext ctx = new MuziekContext())
            {
                //var test = ctx.Albums.Where(a => a.A_ArtistId == cbArtiest.SelectedIndex);

                //foreach (var item in test)
                //{
                //    cbAlbum.DisplayMember = item.Name;
                //    cbAlbum.SelectedValue = item.AlbumId;
                //}
                //var art = Convert.ToInt32(cbArtiest.SelectedValue);

                //var collect = ctx.Albums.Where(s => s.A_ArtistId = cbArtiest.SelectedIndex)
                //.Select(c => new { Id = c.AlbumId, IdA = c.A_ArtistId, Name = c.Name }).ToList();

                var collect = ctx.Albums.Select(c => new { Id = c.AlbumId, IdA = c.A_ArtistId, Name = c.Name }).ToList();




                cbAlbum.DataSource = collect;
                cbAlbum.DisplayMember = "Name";
                cbAlbum.ValueMember = "Id";
                cbAlbum.ValueMember = "IdA";
            }
        }
    }
}
