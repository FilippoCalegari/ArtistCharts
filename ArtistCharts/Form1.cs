using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/*
    Funzionalità:
    - Ordina per ascoltatori
    - Filtra per paese di provenienza
    - Filtra per genere di appartenenza
    - Confronta due artisti

    Confronto tra due artisti:
    - Media di popolarità
    - Media durata traccia
    - Artista con più canzoni in top charts
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
            list_artistsCharts.Show();

            // Input box per inserire il nome dell'artista
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
            list_artistsCharts.Show();

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
            list_artistsCharts.Show();

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
        private void btn_compareArtists_Click(object sender, EventArgs e)
        {
            // Contatori
            int firstNumberRecords = 0;
            int secondNumberRecords = 0;

            // Variabili popolarità
            int firstArtistPop = 0;
            int secondArtistPop = 0;

            // Variabili durata
            double firstArtistDur = 0;
            double secondArtistDur = 0;

            // Variabili media popolarità
            int firstPopMedia;
            int secondPopMedia;

            // Variabili media durata
            double firstDurMedia;
            double secondDurMedia;

            // Variabili nome artisti
            string firstArtist;
            string secondArtist;
            bool artistFound = false;

            do
            {
                // Input box per inserire il nome degli artisti
                firstArtist = Interaction.InputBox("Inserisci il nome del primo artista:", "Confronto tra due artisti", "");

                // Se l'utente non inserisce nulla, usciamo dalla funzione
                if (string.IsNullOrWhiteSpace(firstArtist))
                {
                    MessageBox.Show("Inserisci il nome dell'artista.");
                    return;
                }

                // Iteriamo su tutti gli artisti nella collezione artistsCharts
                foreach (var artist in artistsCharts)
                {
                    // Controlliamo se il nome dell'artista corrisponde a quello inserito dall'utente (con confronto case-insensitive)
                    if (artist.Artist.Equals(firstArtist, StringComparison.OrdinalIgnoreCase))
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

            } while (!artistFound);

            artistFound = false;

            do
            {
                // Input box per inserire il nome degli artisti
                secondArtist = Interaction.InputBox("Inserisci il nome del primo artista:", "Confronto tra due artisti", "");

                // Se l'utente non inserisce nulla, usciamo dalla funzione
                if (string.IsNullOrWhiteSpace(secondArtist))
                {
                    MessageBox.Show("Inserisci il nome dell'artista.");
                    return;
                }

                // Iteriamo su tutti gli artisti nella collezione artistsCharts
                foreach (var artist in artistsCharts)
                {
                    // Controlliamo se il nome dell'artista corrisponde a quello inserito dall'utente (con confronto case-insensitive)
                    if (artist.Artist.Equals(secondArtist, StringComparison.OrdinalIgnoreCase))
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

            } while (!artistFound);

            list_artistsCharts.Hide();
            lb_choice.Show();

            foreach (var artist in artistsCharts)
            {
                if (artist.Artist == firstArtist)
                {
                    firstArtistPop += Convert.ToInt32(artist.Popularity);
                    firstArtistDur += Convert.ToDouble(artist.Duration);
                    firstNumberRecords++;
                }

                if (artist.Artist == secondArtist)
                {
                    secondArtistPop += Convert.ToInt32(artist.Popularity);
                    secondArtistDur += Convert.ToDouble(artist.Duration);
                    secondNumberRecords++;
                }
            }

            // Calcolo medie
            firstPopMedia = firstArtistPop / firstNumberRecords;
            secondPopMedia = secondArtistPop / secondNumberRecords;

            firstDurMedia = firstArtistDur / firstNumberRecords;
            secondDurMedia = secondArtistDur / secondNumberRecords;

            // Grafico confronto popolarità
            chart_popularity.Series.Clear();
            Series popoularity = new Series()
            {
                ChartType = SeriesChartType.Column,
                IsVisibleInLegend = false
            };

            // Modifiche stile scritte
            chart_popularity.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10);
            chart_popularity.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White; // Colore colonne asse X
            chart_popularity.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White; // Colore numeri asse Y

            // Modifiche grafico
            chart_popularity.ChartAreas[0].BackColor = Color.Transparent; // Colore sfondo
            chart_popularity.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart_popularity.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;

            chart_popularity.ChartAreas[0].AxisX.MinorGrid.LineColor = Color.White;
            chart_popularity.ChartAreas[0].AxisY.MinorGrid.LineColor = Color.White;

            chart_popularity.ChartAreas[0].AxisX.LineColor = Color.White;
            chart_popularity.ChartAreas[0].AxisY.LineColor = Color.White;

            //chart_popularity.ChartAreas[0].AxisY. = Color.White;

            chart_popularity.ChartAreas[0].AxisX.Interval = 1;

            chart_popularity.Series.Add(popoularity);

            popoularity.Points.AddXY(firstArtist, firstPopMedia);
            popoularity.Points.AddXY(secondArtist, secondPopMedia);

            // Grafico confronto durata
            chart_duration.Series.Clear();
            Series duration = new Series()
            {
                ChartType = SeriesChartType.Column,
                IsVisibleInLegend = false
            };

            // Modifiche stile scritte
            chart_duration.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10);
            chart_duration.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White; // Colore colonne asse X
            chart_duration.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White; // Colore numeri asse Y

            // Modifiche grafico
            chart_duration.ChartAreas[0].BackColor = Color.Transparent; // Colore sfondo
            chart_duration.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart_duration.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;

            chart_duration.ChartAreas[0].AxisX.MinorGrid.LineColor = Color.White;
            chart_duration.ChartAreas[0].AxisY.MinorGrid.LineColor = Color.White;

            chart_duration.ChartAreas[0].AxisX.LineColor = Color.White;
            chart_duration.ChartAreas[0].AxisY.LineColor = Color.White;

            chart_duration.ChartAreas[0].AxisX.Interval = 1;

            chart_duration.Series.Add(duration);

            duration.Points.AddXY(firstArtist, firstDurMedia);
            duration.Points.AddXY(secondArtist, secondDurMedia);

            // Grafico confronto numero brani in top chart
            chart_numHits.Series.Clear();
            Series number = new Series()
            {
                ChartType = SeriesChartType.Column,
                IsVisibleInLegend = false
            };

            // Modifiche stile scritte
            chart_numHits.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10);
            chart_numHits.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White; // Colore colonne asse X
            chart_numHits.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White; // Colore numeri asse Y

            // Modifiche grafico
            chart_numHits.ChartAreas[0].BackColor = Color.Transparent; // Colore sfondo
            chart_numHits.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart_numHits.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;

            chart_numHits.ChartAreas[0].AxisX.MinorGrid.LineColor = Color.White;
            chart_numHits.ChartAreas[0].AxisY.MinorGrid.LineColor = Color.White;

            chart_numHits.ChartAreas[0].AxisX.LineColor = Color.White;
            chart_numHits.ChartAreas[0].AxisY.LineColor = Color.White;

            chart_numHits.ChartAreas[0].AxisX.Interval = 1;

            chart_numHits.Series.Add(number);

            number.Points.AddXY(firstArtist, firstNumberRecords);
            number.Points.AddXY(secondArtist, secondNumberRecords);

            //lb_choice.Text = $"Gli artisti comparati sono {firstArtist} e {secondArtist}.";

            lb_firstArtistPop.Show();
            lb_secondArtistPop.Show();
            chart_popularity.Show();

            // Stampo media popolarità
            lb_firstArtistPop.Text = $"- {firstArtist} ha una media di popolarità di {firstPopMedia}.";
            lb_secondArtistPop.Text = $"- {secondArtist} ha una media di popolarità di {secondPopMedia}.";
       
            lb_firstArtistDur.Show();
            lb_secondArtistDur.Show();
            chart_duration.Show();

            // Stampo media durata
            lb_firstArtistDur.Text = $"> {firstArtist} ha una media di durata delle tracce di {Math.Round(firstDurMedia)} minuti.";
            lb_secondArtistDur.Text = $"> {secondArtist} ha una media di durata delle tracce di {Math.Round(secondDurMedia)} minuti.";
     
            lb_firstArtistCharts.Show();
            lb_secondArtistCharts.Show();
            chart_numHits.Show();

            // Stampo numero di record di quell'artista
            lb_firstArtistCharts.Text = $"+ {firstArtist} ha {firstNumberRecords} tracce in top chart di spotify.";
            lb_secondArtistCharts.Text = $"+ {secondArtist} ha {secondNumberRecords} tracce in top chart di spotify.";
        
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void FillList()
        {
            list_artistsCharts.Show();
            chart_popularity.Hide();
            chart_duration.Hide();
            chart_numHits.Hide();
            lb_firstArtistPop.Hide();
            lb_secondArtistPop.Hide();
            lb_firstArtistDur.Hide();
            lb_secondArtistDur.Hide();
            lb_firstArtistCharts.Hide();
            lb_secondArtistCharts.Hide();
            lb_choice.Hide();

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
            list_artistsCharts.Show();

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

        private void chart_compareArtists_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser_spotify_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        private void cb_choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}