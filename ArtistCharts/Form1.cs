using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/*
    Funzionalità:
    - Ordina per ascoltatori
    - Filtra per paese di provenienza
    - Filtra per genere di appartenenza
    - Confronta due artisti
*/

namespace ArtistCharts
{
    public partial class Form1 : Form
    {
        private List<Artists> artistsCharts;
        private string fileName = "./ArtistsCharts.csv";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            artistsCharts = new List<Artists>();
            FillList();
        }

        private void btn_nameFilter_Click(object sender, EventArgs e)
        {
            string artistName = Interaction.InputBox("Inserisci il nome dell'artista da cercare:", "Filtra per artista", "");

            foreach (var artist in artistsCharts)
            {
                if (artistName == artist.Artist)
                {
                    list_artistsCharts.Clear();

                    //list_artistsCharts
                }
            }
        }

        private void btn_genreFilter_Click(object sender, EventArgs e)
        {

        }

        private void btn_increasingSort_Click(object sender, EventArgs e)
        {

        }

        private void btn_decreasingSort_Click(object sender, EventArgs e)
        {

        }

        private void btn_compareArtists_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void FillList()
        {
            StreamReader sr = new StreamReader(fileName);
            string line = sr.ReadLine();

            while (line != null)
            {
                Artists artist = new Artists(line.Split(',')[0], line.Split(',')[1], line.Split(',')[2], line.Split(',')[3], line.Split(',')[4]);
                artistsCharts.Add(artist);
                
                line = sr.ReadLine();
            }
            sr.Close();

            list_artistsCharts.View = View.Details;

            list_artistsCharts.Items.Clear(); // Pulisci gli elementi esistenti
            list_artistsCharts.Columns.Clear(); // Pulisci le colonne esistenti

            // Aggiungi i titoli delle colonne
            list_artistsCharts.Columns.Add("Track Name", 100);
            list_artistsCharts.Columns.Add("Artist", 100);
            list_artistsCharts.Columns.Add("Popularity", 100);
            list_artistsCharts.Columns.Add("Duration in ms", 100);
            list_artistsCharts.Columns.Add("Track ID", 100);

            // Aggiungi i dati dalla lista alla ListView
            foreach (var artist in artistsCharts)
            {
                ListViewItem item = new ListViewItem(artist.Artist);
                item.SubItems.Add(artist.TrackName);
                item.SubItems.Add(artist.Popularity);
                item.SubItems.Add(artist.Duration);
                item.SubItems.Add(artist.ID);

                list_artistsCharts.Items.Add(item);
            }

            foreach (ColumnHeader column in list_artistsCharts.Columns)
            {
                column.Width = -2; // La larghezza è automatica
            }
        }
        class Artists
        {
            private string _artist;
            public string Artist
            {
                get => _artist;
                set => _artist = value;
            }
            private string _trackname;
            public string TrackName
            {
                get => _trackname;
                set => _trackname = value;
            }

            private string _popularity;
            public string Popularity
            {
                get => _popularity;
                set => _popularity = value;
            }

            private string _duration;
            public string Duration
            {
                get => _duration;
                set => _duration = value;
            }

            private string _id;
            public string ID
            {
                get => _id;
                set => _id = value;
            }
            public Artists(string artist, string trackName,string popularity, string duration, string id)
            {
                Artist = artist;
                TrackName = trackName;
                Popularity = popularity;
                Duration = duration;
                ID = id;
            }
        }
    }
}
