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
            this.btn_nameFilter = new System.Windows.Forms.Button();
            this.btn_popularitySort = new System.Windows.Forms.Button();
            this.btn_durationSort = new System.Windows.Forms.Button();
            this.btn_decreasingSort = new System.Windows.Forms.Button();
            this.list_artistsCharts = new System.Windows.Forms.ListView();
            this.btn_listenToSong = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nameFilter
            // 
            this.btn_nameFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(80)))));
            this.btn_nameFilter.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nameFilter.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_nameFilter.Location = new System.Drawing.Point(18, 18);
            this.btn_nameFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_nameFilter.Name = "btn_nameFilter";
            this.btn_nameFilter.Size = new System.Drawing.Size(477, 108);
            this.btn_nameFilter.TabIndex = 0;
            this.btn_nameFilter.Text = "Filtra per artista";
            this.btn_nameFilter.UseVisualStyleBackColor = false;
            this.btn_nameFilter.Click += new System.EventHandler(this.btn_nameFilter_Click);
            // 
            // btn_popularitySort
            // 
            this.btn_popularitySort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(80)))));
            this.btn_popularitySort.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_popularitySort.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_popularitySort.Location = new System.Drawing.Point(18, 135);
            this.btn_popularitySort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_popularitySort.Name = "btn_popularitySort";
            this.btn_popularitySort.Size = new System.Drawing.Size(477, 108);
            this.btn_popularitySort.TabIndex = 1;
            this.btn_popularitySort.Text = "Ordina per popolarità";
            this.btn_popularitySort.UseVisualStyleBackColor = false;
            this.btn_popularitySort.Click += new System.EventHandler(this.btn_popularitySort_Click);
            // 
            // btn_durationSort
            // 
            this.btn_durationSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(80)))));
            this.btn_durationSort.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_durationSort.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_durationSort.Location = new System.Drawing.Point(18, 252);
            this.btn_durationSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_durationSort.Name = "btn_durationSort";
            this.btn_durationSort.Size = new System.Drawing.Size(477, 108);
            this.btn_durationSort.TabIndex = 2;
            this.btn_durationSort.Text = "Ordina per durata";
            this.btn_durationSort.UseVisualStyleBackColor = false;
            this.btn_durationSort.Click += new System.EventHandler(this.btn_durationSort_Click);
            // 
            // btn_decreasingSort
            // 
            this.btn_decreasingSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(80)))));
            this.btn_decreasingSort.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_decreasingSort.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_decreasingSort.Location = new System.Drawing.Point(18, 369);
            this.btn_decreasingSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_decreasingSort.Name = "btn_decreasingSort";
            this.btn_decreasingSort.Size = new System.Drawing.Size(477, 108);
            this.btn_decreasingSort.TabIndex = 3;
            this.btn_decreasingSort.Text = "Confronta due artisti";
            this.btn_decreasingSort.UseVisualStyleBackColor = false;
            this.btn_decreasingSort.Click += new System.EventHandler(this.btn_decreasingSort_Click);
            // 
            // list_artistsCharts
            // 
            this.list_artistsCharts.HideSelection = false;
            this.list_artistsCharts.Location = new System.Drawing.Point(504, 18);
            this.list_artistsCharts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list_artistsCharts.Name = "list_artistsCharts";
            this.list_artistsCharts.Size = new System.Drawing.Size(1340, 573);
            this.list_artistsCharts.TabIndex = 5;
            this.list_artistsCharts.UseCompatibleStateImageBehavior = false;
            this.list_artistsCharts.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btn_listenToSong
            // 
            this.btn_listenToSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(80)))));
            this.btn_listenToSong.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_listenToSong.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_listenToSong.Location = new System.Drawing.Point(18, 486);
            this.btn_listenToSong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_listenToSong.Name = "btn_listenToSong";
            this.btn_listenToSong.Size = new System.Drawing.Size(477, 108);
            this.btn_listenToSong.TabIndex = 6;
            this.btn_listenToSong.Text = "Riproduci la traccia selezionata";
            this.btn_listenToSong.UseVisualStyleBackColor = false;
            this.btn_listenToSong.Click += new System.EventHandler(this.btn_listenToSong_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(80)))));
            this.btn_refresh.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_refresh.Location = new System.Drawing.Point(18, 604);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(1826, 108);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Ripristina lista";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1864, 737);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_listenToSong);
            this.Controls.Add(this.list_artistsCharts);
            this.Controls.Add(this.btn_decreasingSort);
            this.Controls.Add(this.btn_durationSort);
            this.Controls.Add(this.btn_popularitySort);
            this.Controls.Add(this.btn_nameFilter);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_nameFilter;
        private System.Windows.Forms.Button btn_popularitySort;
        private System.Windows.Forms.Button btn_durationSort;
        private System.Windows.Forms.Button btn_decreasingSort;
        private System.Windows.Forms.ListView list_artistsCharts;
        private System.Windows.Forms.Button btn_listenToSong;
        private System.Windows.Forms.Button btn_refresh;
    }
}

