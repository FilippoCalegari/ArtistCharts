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
        private string fileName = "./ArtistsChart.csv";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            artistsCharts = new List<Artists>();
            FillList();
        }

        private void btn_countryFilter_Click(object sender, EventArgs e)
        {

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
            public Artists(string artist, string trackName,string popularity, string duration)
            {
                Artist = artist;
                TrackName = trackName;
                Popularity = popularity;
                Duration = duration;
            }
        }
    }
}
