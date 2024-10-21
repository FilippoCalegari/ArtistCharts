namespace ArtistCharts
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_nameFilter = new System.Windows.Forms.Button();
            this.btn_popularitySort = new System.Windows.Forms.Button();
            this.btn_durationSort = new System.Windows.Forms.Button();
            this.btn_compareArtists = new System.Windows.Forms.Button();
            this.list_artistsCharts = new System.Windows.Forms.ListView();
            this.btn_listenToSong = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lb_firstArtistPop = new System.Windows.Forms.Label();
            this.lb_secondArtistPop = new System.Windows.Forms.Label();
            this.lb_secondArtistDur = new System.Windows.Forms.Label();
            this.lb_firstArtistDur = new System.Windows.Forms.Label();
            this.lb_firstArtistCharts = new System.Windows.Forms.Label();
            this.lb_secondArtistCharts = new System.Windows.Forms.Label();
            this.chart_compareArtists = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_compareArtists)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nameFilter
            // 
            this.btn_nameFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(80)))));
            this.btn_nameFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_nameFilter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_nameFilter.FlatAppearance.BorderSize = 3;
            this.btn_nameFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nameFilter.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nameFilter.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_nameFilter.Location = new System.Drawing.Point(12, 12);
            this.btn_nameFilter.Name = "btn_nameFilter";
            this.btn_nameFilter.Size = new System.Drawing.Size(318, 70);
            this.btn_nameFilter.TabIndex = 0;
            this.btn_nameFilter.Text = "Filtra per artista";
            this.btn_nameFilter.UseVisualStyleBackColor = false;
            this.btn_nameFilter.Click += new System.EventHandler(this.btn_nameFilter_Click);
            // 
            // btn_popularitySort
            // 
            this.btn_popularitySort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(80)))));
            this.btn_popularitySort.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_popularitySort.FlatAppearance.BorderSize = 3;
            this.btn_popularitySort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_popularitySort.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_popularitySort.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_popularitySort.Location = new System.Drawing.Point(12, 88);
            this.btn_popularitySort.Name = "btn_popularitySort";
            this.btn_popularitySort.Size = new System.Drawing.Size(318, 70);
            this.btn_popularitySort.TabIndex = 1;
            this.btn_popularitySort.Text = "Ordina per popolarità";
            this.btn_popularitySort.UseVisualStyleBackColor = false;
            this.btn_popularitySort.Click += new System.EventHandler(this.btn_popularitySort_Click);
            // 
            // btn_durationSort
            // 
            this.btn_durationSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(80)))));
            this.btn_durationSort.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_durationSort.FlatAppearance.BorderSize = 3;
            this.btn_durationSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_durationSort.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_durationSort.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_durationSort.Location = new System.Drawing.Point(12, 164);
            this.btn_durationSort.Name = "btn_durationSort";
            this.btn_durationSort.Size = new System.Drawing.Size(318, 70);
            this.btn_durationSort.TabIndex = 2;
            this.btn_durationSort.Text = "Ordina per durata";
            this.btn_durationSort.UseVisualStyleBackColor = false;
            this.btn_durationSort.Click += new System.EventHandler(this.btn_durationSort_Click);
            // 
            // btn_compareArtists
            // 
            this.btn_compareArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(80)))));
            this.btn_compareArtists.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_compareArtists.FlatAppearance.BorderSize = 3;
            this.btn_compareArtists.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_compareArtists.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_compareArtists.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_compareArtists.Location = new System.Drawing.Point(12, 240);
            this.btn_compareArtists.Name = "btn_compareArtists";
            this.btn_compareArtists.Size = new System.Drawing.Size(318, 70);
            this.btn_compareArtists.TabIndex = 3;
            this.btn_compareArtists.Text = "Confronta due artisti";
            this.btn_compareArtists.UseVisualStyleBackColor = false;
            this.btn_compareArtists.Click += new System.EventHandler(this.btn_compareArtists_Click);
            // 
            // list_artistsCharts
            // 
            this.list_artistsCharts.HideSelection = false;
            this.list_artistsCharts.Location = new System.Drawing.Point(334, 12);
            this.list_artistsCharts.Name = "list_artistsCharts";
            this.list_artistsCharts.Size = new System.Drawing.Size(895, 374);
            this.list_artistsCharts.TabIndex = 5;
            this.list_artistsCharts.UseCompatibleStateImageBehavior = false;
            this.list_artistsCharts.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btn_listenToSong
            // 
            this.btn_listenToSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(80)))));
            this.btn_listenToSong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_listenToSong.FlatAppearance.BorderSize = 3;
            this.btn_listenToSong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_listenToSong.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_listenToSong.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_listenToSong.Location = new System.Drawing.Point(12, 316);
            this.btn_listenToSong.Name = "btn_listenToSong";
            this.btn_listenToSong.Size = new System.Drawing.Size(318, 70);
            this.btn_listenToSong.TabIndex = 6;
            this.btn_listenToSong.Text = "Riproduci la traccia selezionata";
            this.btn_listenToSong.UseVisualStyleBackColor = false;
            this.btn_listenToSong.Click += new System.EventHandler(this.btn_listenToSong_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(80)))));
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_refresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_refresh.FlatAppearance.BorderSize = 3;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_refresh.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_refresh.Location = new System.Drawing.Point(12, 393);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(1217, 70);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Ripristina lista";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lb_firstArtistPop
            // 
            this.lb_firstArtistPop.AutoSize = true;
            this.lb_firstArtistPop.BackColor = System.Drawing.Color.Transparent;
            this.lb_firstArtistPop.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.lb_firstArtistPop.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_firstArtistPop.Location = new System.Drawing.Point(336, 12);
            this.lb_firstArtistPop.Name = "lb_firstArtistPop";
            this.lb_firstArtistPop.Size = new System.Drawing.Size(51, 21);
            this.lb_firstArtistPop.TabIndex = 8;
            this.lb_firstArtistPop.Text = "label1";
            this.lb_firstArtistPop.Visible = false;
            // 
            // lb_secondArtistPop
            // 
            this.lb_secondArtistPop.AutoSize = true;
            this.lb_secondArtistPop.BackColor = System.Drawing.Color.Transparent;
            this.lb_secondArtistPop.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.lb_secondArtistPop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_secondArtistPop.Location = new System.Drawing.Point(336, 61);
            this.lb_secondArtistPop.Name = "lb_secondArtistPop";
            this.lb_secondArtistPop.Size = new System.Drawing.Size(51, 21);
            this.lb_secondArtistPop.TabIndex = 9;
            this.lb_secondArtistPop.Text = "label1";
            this.lb_secondArtistPop.Visible = false;
            // 
            // lb_secondArtistDur
            // 
            this.lb_secondArtistDur.AutoSize = true;
            this.lb_secondArtistDur.BackColor = System.Drawing.Color.Transparent;
            this.lb_secondArtistDur.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.lb_secondArtistDur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_secondArtistDur.Location = new System.Drawing.Point(336, 213);
            this.lb_secondArtistDur.Name = "lb_secondArtistDur";
            this.lb_secondArtistDur.Size = new System.Drawing.Size(51, 21);
            this.lb_secondArtistDur.TabIndex = 11;
            this.lb_secondArtistDur.Text = "label1";
            this.lb_secondArtistDur.Visible = false;
            // 
            // lb_firstArtistDur
            // 
            this.lb_firstArtistDur.AutoSize = true;
            this.lb_firstArtistDur.BackColor = System.Drawing.Color.Transparent;
            this.lb_firstArtistDur.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.lb_firstArtistDur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_firstArtistDur.Location = new System.Drawing.Point(336, 164);
            this.lb_firstArtistDur.Name = "lb_firstArtistDur";
            this.lb_firstArtistDur.Size = new System.Drawing.Size(51, 21);
            this.lb_firstArtistDur.TabIndex = 10;
            this.lb_firstArtistDur.Text = "label1";
            this.lb_firstArtistDur.Visible = false;
            // 
            // lb_firstArtistCharts
            // 
            this.lb_firstArtistCharts.AutoSize = true;
            this.lb_firstArtistCharts.BackColor = System.Drawing.Color.Transparent;
            this.lb_firstArtistCharts.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.lb_firstArtistCharts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_firstArtistCharts.Location = new System.Drawing.Point(336, 316);
            this.lb_firstArtistCharts.Name = "lb_firstArtistCharts";
            this.lb_firstArtistCharts.Size = new System.Drawing.Size(51, 21);
            this.lb_firstArtistCharts.TabIndex = 12;
            this.lb_firstArtistCharts.Text = "label1";
            this.lb_firstArtistCharts.Visible = false;
            // 
            // lb_secondArtistCharts
            // 
            this.lb_secondArtistCharts.AutoSize = true;
            this.lb_secondArtistCharts.BackColor = System.Drawing.Color.Transparent;
            this.lb_secondArtistCharts.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.lb_secondArtistCharts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_secondArtistCharts.Location = new System.Drawing.Point(336, 365);
            this.lb_secondArtistCharts.Name = "lb_secondArtistCharts";
            this.lb_secondArtistCharts.Size = new System.Drawing.Size(51, 21);
            this.lb_secondArtistCharts.TabIndex = 13;
            this.lb_secondArtistCharts.Text = "label1";
            this.lb_secondArtistCharts.Visible = false;
            // 
            // chart_compareArtists
            // 
            this.chart_compareArtists.BackColor = System.Drawing.Color.Transparent;
            this.chart_compareArtists.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart_compareArtists.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_compareArtists.Legends.Add(legend1);
            this.chart_compareArtists.Location = new System.Drawing.Point(911, 12);
            this.chart_compareArtists.Name = "chart_compareArtists";
            this.chart_compareArtists.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_compareArtists.Series.Add(series1);
            this.chart_compareArtists.Size = new System.Drawing.Size(318, 374);
            this.chart_compareArtists.TabIndex = 14;
            this.chart_compareArtists.Text = "chart1";
            this.chart_compareArtists.Visible = false;
            this.chart_compareArtists.Click += new System.EventHandler(this.chart_compareArtists_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1243, 478);
            this.Controls.Add(this.chart_compareArtists);
            this.Controls.Add(this.lb_secondArtistCharts);
            this.Controls.Add(this.lb_firstArtistCharts);
            this.Controls.Add(this.lb_secondArtistDur);
            this.Controls.Add(this.lb_firstArtistDur);
            this.Controls.Add(this.lb_secondArtistPop);
            this.Controls.Add(this.lb_firstArtistPop);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_listenToSong);
            this.Controls.Add(this.list_artistsCharts);
            this.Controls.Add(this.btn_compareArtists);
            this.Controls.Add(this.btn_durationSort);
            this.Controls.Add(this.btn_popularitySort);
            this.Controls.Add(this.btn_nameFilter);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_compareArtists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nameFilter;
        private System.Windows.Forms.Button btn_popularitySort;
        private System.Windows.Forms.Button btn_durationSort;
        private System.Windows.Forms.Button btn_compareArtists;
        private System.Windows.Forms.ListView list_artistsCharts;
        private System.Windows.Forms.Button btn_listenToSong;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lb_firstArtistPop;
        private System.Windows.Forms.Label lb_secondArtistPop;
        private System.Windows.Forms.Label lb_secondArtistDur;
        private System.Windows.Forms.Label lb_firstArtistDur;
        private System.Windows.Forms.Label lb_firstArtistCharts;
        private System.Windows.Forms.Label lb_secondArtistCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_compareArtists;
    }
}

