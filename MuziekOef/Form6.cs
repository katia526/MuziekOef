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
    public partial class Form6 : Form
    {
        public Form6(string klant, int klId)
        {
            InitializeComponent();
            txtNaam.Text = klant;
            txtKlantId.Text = klId.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int listId = Convert.ToInt32(cbPlaylist.SelectedIndex);
            var list = cbPlaylist.SelectedItem.ToString();
            if (list == null)
            {
                MessageBox.Show("Kies een playlist of maak een nieuwe aan");
            }
            else
            {
                using (MuziekContext ctx = new MuziekContext())
                {
                    var coll = ctx.PlaylistSongs.Select(c => c.Pl_PlaylistId == listId);
                    foreach (var item in coll)
                    {
                        lvwSongs.Items.Add(Name);
                    }
                }
                    
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            using (MuziekContext ctx = new MuziekContext())
            {
                var kltId = Convert.ToInt32(txtKlantId.Text);
  
                var userPlaylists = ctx.Playlists.Where(p => p.P_UserId == kltId);
                foreach (Playlist playlist in userPlaylists)
                {
                    ComboboxItem newItem = new ComboboxItem(playlist.PlaylistId, playlist.Name);
                    cbPlaylist.Items.Add(newItem);
                }

                var collection = ctx.Playlists.Select(c => new { Id = c.PlaylistId, Name = c.Name }).ToList();
                lstPlaylist.DataSource = collection;
                lstPlaylist.DisplayMember = "Name";
                lstPlaylist.ValueMember = "Id";

            }
        }

        private void btn1Nieuw_Click(object sender, EventArgs e)
        {
            using (MuziekContext ctx = new MuziekContext())
            {
                var kltId = Convert.ToInt32(txtKlantId.Text);
                var result = ctx.Playlists.Select(c => c.P_UserId == kltId);
                ctx.Playlists.Add(new Playlist()
                {
                    P_UserId = kltId,
                    Name = txtPlaylist.Text

                });
                ctx.SaveChanges();

            }
        }
        public class ComboboxItem
        {
            public object Value { get; set; }
            public string Text { get; set; }
            public ComboboxItem(object value, string text)
            {
                Value = value;
                Text = text;
            }
            public override string ToString()
            {
                return Text;
            }
        }

        private void cbPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MuziekContext ctx = new MuziekContext())
            {
                
               
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lstkeuze = Convert.ToInt32(lstPlaylist.SelectedIndex);
            Form7 form7 = new Form7(txtPlaylist.Text, lstkeuze);
            form7.Show();
        }

        private void lstPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
         int lstkeuze = Convert.ToInt32(lstPlaylist.SelectedIndex);
            Form7 form7 = new Form7(txtNaam.Text, lstkeuze);
            form7.Show();
        }
    }
}
