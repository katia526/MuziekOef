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
    public partial class Form7 : Form
    {
        public Form7(string Naam, int Pl_Id)
        {
            InitializeComponent();
            txtId.Text = Pl_Id.ToString();
            txtNaam.Text = Naam;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            using (MuziekContext ctx = new MuziekContext())
            {
                var collection = ctx.Artists.Select(c => new { Id = c.ArtistId, Name = c.Name }).ToList();
                cbArtiest.DataSource = collection;
                cbArtiest.DisplayMember = "Name";
                cbArtiest.ValueMember = "Id";

                var col = ctx.Songs.Select(c => new { Id2 = c.SongId, Name2 = c.Title }).ToList();
                cbSong.DataSource = col;
                cbSong.DisplayMember = "Name2";
                cbSong.ValueMember = "Id2";


                
            }
        }

        private void cbArtiest_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MuziekContext ctx = new MuziekContext())
            {


               //int index = Convert.ToInt32(cbArtiest.SelectedValue.ToString());
                // int ind = Convert.ToInt32(index);
                // var col = ctx.Albums.Select(c => new { Id = c.AlbumId, Name = c.Name, Aid = c.A_ArtistId }).Where(c => c.Aid == index).ToList();
              var col = ctx.Albums.Select(c => new { Id = c.AlbumId, Name = c.Name}).ToList();
               // var col = ctx.Albums.Select(c => c.A_ArtistId == (Convert.ToInt32(cbArtiest.SelectedItem))
              //     .Where(c => new { Id = c.AlbumId, Name = c.Name, Aid = c.A_ArtistId }).ToList();
                //   var col = ctx.Albums.Select(c => c.A_ArtistId == index);

                cbAlbum.DataSource = col;
                cbAlbum.DisplayMember = "Name";
                cbAlbum.ValueMember = "Id";


                //foreach (var item in col)
                //{
                //    cbAlbum.Items.Add(new Album()
                //    {
                //        Name = item.Name,
                //        AlbumId = item.Id

                //    });
                //}
            }
        }

        private void cbSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (MuziekContext ctx = new MuziekContext())
            //{
            //    var col = ctx.Songs.Select(c => new { Id = c.SongId, Name = c.Title }).ToList();
            //    cbSong.DataSource = col;
            //    cbSong.DisplayMember = "Name";
            //    cbSong.ValueMember = "Id";
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MuziekContext ctx = new MuziekContext())
            {
                ctx.PlaylistSongs.Add(new PlaylistSong()
                {
                    Pl_SongId = Convert.ToInt32(cbSong.SelectedValue),
                   Pl_PlaylistId = Convert.ToInt32(txtId.Text)
                });
                ctx.SaveChanges();
            }
        }

        private void lstSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MuziekContext ctx = new MuziekContext())
            {

            }
        }
    }
}
