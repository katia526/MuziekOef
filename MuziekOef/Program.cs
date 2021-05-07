using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuziekOef
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
    [STAThread]

            static void Main()
            {
                //using (MuziekContext ctx = new MuziekContext())
                //{
                //    ctx.Users.Add(new User()
                //    {
                //        FirstName = "Jef",
                //        LastName = "verachtert",
                //        Email = "katia@hotmail.com",
                //        Password = "12ab34CD"
                //    });

                //    ctx.Interactions.Add(new Interaction()
                //    {
                //        I_UserId = 1,
                //        I_SongId = 1,
                //        Liked = 1,
                //        PlayCount = 1,
                //        CreatedAt = new DateTime(year: 2021, month: 5, day: 03),
                //        UpdatedAt = new DateTime(year: 2021, month: 5, day: 03)
                //    });

                //    ctx.Playlists.Add(new Playlist()
                //    {
                //        P_UserId = 1,
                //        Name = "Eerste",
                //        CreatedAt = new DateTime(year: 2021, month: 5, day: 03),
                //        UpdatedAt = new DateTime(year: 2021, month: 5, day: 03)
                //    });

                //    ctx.Songs.Add(new Song()
                //    {
                //        S_AlbumId = 1,
                //        S_ArtistId = 1,
                //        Title = "Reckless",
                //        Length = 3.02,
                //        CreatedAt = new DateTime(year: 2021, month: 5, day: 03),
                //        UpdatedAt = new DateTime(year: 2021, month: 5, day: 03)
                //    });
                //    ctx.Albums.Add(new Album()
                //    {
                //        A_ArtistId = 1,
                //        Name = "Eerste Album",
                //        CreatedAt = new DateTime(year: 2021, month: 5, day: 03),
                //        UpdatedAt = new DateTime(year: 2021, month: 5, day: 03)
                //    });
                //    //ctx.PlaylistSongs.Add(new PlaylistSong()
                //    //{
                //    //    Pl_PlaylistId = 1,
                //    //    Pl_SongId = 1
                //    //});
                //    ctx.Artists.Add(new Artist()
                //    {

                //        Name = "Bryan Adams",
                //        CreatedAt = new DateTime(year: 2021, month: 5, day: 03),
                //        UpdatedAt = new DateTime(year: 2021, month: 5, day: 03)
                //    });
                //    ctx.SaveChanges();

                //}
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());

            }
        
        public class User
        {
            [Key]
            public int UserId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }

        }
        public class Playlist
        {
            [Key]
            public int PlaylistId { get; set; }
            public int P_UserId { get; set; }
            public string Name { get; set; }
            [DataType(DataType.Date)]
            public DateTime CreatedAt { get; set; } = DateTime.Now;
            [DataType(DataType.Date)]
            public DateTime UpdatedAt { get; set; } = DateTime.Now;

            public User User { get; set; }
         

        }

        public class Interaction
        {
            [Key]
            public int InteractionId { get; set; }
            public int I_UserId { get; set; }
            public int I_SongId { get; set; }
            public int Liked { get; set; }
            public int PlayCount { get; set; }
            [DataType(DataType.Date)]
            public DateTime CreatedAt { get; set; } 
            [DataType(DataType.Date)]
            public DateTime UpdatedAt { get; set; } = DateTime.Now;

            public User user { get; set; }

            public Song Song { get; set; }
        }
        public class Song
        {
            [Key]
            public int SongId { get; set; }
            public int S_AlbumId { get; set; }
            public int S_ArtistId { get; set; }
            public string Title { get; set; }
            public double Length { get; set; }
            [DataType(DataType.Date)]
            public DateTime CreatedAt { get; set; } = DateTime.Now;
            [DataType(DataType.Date)]
            public DateTime UpdatedAt { get; set; } = DateTime.Now;

            public Album Album { get; set; }

            public Artist Artist { get; set; }
        }
        public class Album
        {
            [Key]
            public int AlbumId { get; set; }
            public int A_ArtistId { get; set; }
            public string Name { get; set; }
           [DataType(DataType.Date)]
            public DateTime CreatedAt { get; set; } = DateTime.Now;
            [DataType(DataType.Date)]
            public DateTime UpdatedAt { get; set; } = DateTime.Now;
       

            public Artist Artist { get; set; }
        }
        public class PlaylistSong
        {
            [Key]
            [Column(Order = 1)]
            public int Pl_PlaylistId { get; set; }
            [Key]
            [Column(Order = 2)]
            public int Pl_SongId { get; set; }

            public Song Song { get; set; }

            public Playlist Playlist { get; set; }
        }
        public class Artist
        {
            [Key]
            public int ArtistId { get; set; }
            public string Name { get; set; }
            [DataType(DataType.Date)]
            public DateTime CreatedAt { get; set; } = DateTime.Now;
            [DataType(DataType.Date)]
            public DateTime UpdatedAt { get; set; } = DateTime.Now;

          
        }
        public class MuziekContext : DbContext
        {
            public MuziekContext() : base("name=MuziekDBConnectString")
            {
                // Database.SetInitializer(new CreateDatabaseIfNotExists<MuziekContext>());
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MuziekContext>());
                //Database.SetInitializer(new DropCreateDatabaseAlways<MuziekContext>());
            }

            public DbSet<User> Users { get; set; }
            public DbSet<Interaction> Interactions { get; set; }
            public DbSet<Playlist> Playlists { get; set; }
            public DbSet<Song> Songs { get; set; }
            public DbSet<Album> Albums { get; set; }
            public DbSet<PlaylistSong> PlaylistSongs { get; set; }
            public DbSet<Artist> Artists { get; set; }
        }
    }
}
