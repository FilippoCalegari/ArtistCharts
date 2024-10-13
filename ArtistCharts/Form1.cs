using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
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
            // Prompt l'utente per inserire il nome dell'artista
            string artistName = Interaction.InputBox("Inserisci il nome dell'artista da cercare:", "Filtra per artista", "");

            // Se l'utente non inserisce nulla, usciamo dalla funzione
            if (string.IsNullOrWhiteSpace(artistName))
            {
                MessageBox.Show("Inserisci il nome dell'artista.");
                return;
            }

            // Puliamo la ListView prima di mostrare i risultati
            list_artistsCharts.Items.Clear();

            bool artistFound = false;

            // Iteriamo su tutti gli artisti nella collezione artistsCharts
            foreach (var artist in artistsCharts)
            {
                // Controlliamo se il nome dell'artista corrisponde a quello inserito dall'utente (con confronto case-insensitive)
                if (artist.Artist.Equals(artistName, StringComparison.OrdinalIgnoreCase))
                {
                    ListViewItem item = new ListViewItem(artist.Artist);
                    item.SubItems.Add(artist.TrackName);
                    item.SubItems.Add(artist.Popularity);
                    item.SubItems.Add(artist.Duration);
                    item.SubItems.Add(artist.ID);

                    list_artistsCharts.Items.Add(item);
                    
                    artistFound = true; // Artista trovato
                }
            }

            // Se l'artista non è stato trovato, mostriamo un messaggio
            if (!artistFound)
            {
                MessageBox.Show("Artista non trovato.");
            }
        }

        private void btn_popularitySort_Click(object sender, EventArgs e)
        {
            // Ordinamento con "OrderByDescending" e conversione in int dei valori "Popularity"
            artistsCharts = artistsCharts.OrderByDescending(artist => int.Parse(artist.Popularity)).ToList();

            // Pulisci gli elementi esistenti
            list_artistsCharts.Items.Clear();

            // Aggiungi i dati ordinati alla ListView
            foreach (var artist in artistsCharts)
            {
                ListViewItem item = new ListViewItem(artist.Artist);
                item.SubItems.Add(artist.TrackName);
                item.SubItems.Add(artist.Popularity);
                item.SubItems.Add(artist.Duration);
                item.SubItems.Add(artist.ID);

                list_artistsCharts.Items.Add(item);
            }

            // Ridimensiona le colonne 
            foreach (ColumnHeader column in list_artistsCharts.Columns)
            {
                column.Width = -2; // La larghezza è automatica
            }
        }
        private void btn_durationSort_Click(object sender, EventArgs e)
        {
            // Ordinamento con "OrderByDescending" e conversione in int dei valori "Popularity"
            artistsCharts = artistsCharts.OrderByDescending(artist => int.Parse(artist.Duration)).ToList();

            // Pulisci gli elementi esistenti
            list_artistsCharts.Items.Clear();

            // Aggiungi i dati ordinati alla ListView
            foreach (var artist in artistsCharts)
            {
                ListViewItem item = new ListViewItem(artist.Artist);
                item.SubItems.Add(artist.TrackName);
                item.SubItems.Add(artist.Popularity);
                item.SubItems.Add(artist.Duration);
                item.SubItems.Add(artist.ID);

                list_artistsCharts.Items.Add(item);
            }

            // Ridimensiona le colonne 
            foreach (ColumnHeader column in list_artistsCharts.Columns)
            {
                column.Width = -2; // La larghezza è automatica
            }
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
            artistsCharts.Clear(); // Svuoto la lista
            list_artistsCharts.Items.Clear(); // Pulisci gli elementi esistenti
            list_artistsCharts.Columns.Clear(); // Pulisci le colonne esistenti

            StreamReader sr = new StreamReader(fileName);
            string line = sr.ReadLine();

            while (line != null)
            {
                Artists artist = new Artists(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], line.Split(';')[3], line.Split(';')[4]);
                artistsCharts.Add(artist);
                
                line = sr.ReadLine();
            }
            sr.Close();

            list_artistsCharts.View = View.Details;

            list_artistsCharts.Items.Clear(); // Pulisci gli elementi esistenti
            list_artistsCharts.Columns.Clear(); // Pulisci le colonne esistenti

            // Aggiungi i titoli delle colonne
            list_artistsCharts.Columns.Add("Artist", 100);
            list_artistsCharts.Columns.Add("Track Name", 100);
            list_artistsCharts.Columns.Add("Popularity", 100);
            list_artistsCharts.Columns.Add("Duration in minutes", 100);
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
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            FillList();
        }

        private void btn_listenToSong_Click(object sender, EventArgs e)
        {
            string trackID = null;
            // Selezioniamo la canzone 
            if (list_artistsCharts.SelectedItems.Count > 0)
            {
                // Ottieni l'elemento selezionato
                ListViewItem selectedItem = list_artistsCharts.SelectedItems[0];

                // Assegniamo ad una variabile l'ID della traccia
                trackID = selectedItem.SubItems[4].Text;
            }
            else
            {
                MessageBox.Show("Selezionare una traccia.");
                return;
            }

            // Costruzione della URL per la traccia su Spotify
            var url = $"https://open.spotify.com/track/{trackID}";

            // Avvio del processo per aprire il browser in .NET Core o Framework
            var process = new ProcessStartInfo(url)
            {
                UseShellExecute = true  // Necessario per l'apertura nel browser predefinito
            };

            try
            {
                Process.Start(process);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nell'aprire la canzone: {ex.Message}");
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
            public Artists(string artist, string trackName, string popularity, string duration, string id)
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
