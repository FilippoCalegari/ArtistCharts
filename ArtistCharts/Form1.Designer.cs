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
            this.btn_countryFilter = new System.Windows.Forms.Button();
            this.btn_genreFilter = new System.Windows.Forms.Button();
            this.btn_increasingSort = new System.Windows.Forms.Button();
            this.btn_decreasingSort = new System.Windows.Forms.Button();
            this.list_artistsCharts = new System.Windows.Forms.ListView();
            this.btn_compareArtists = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_countryFilter
            // 
            this.btn_countryFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(80)))));
            this.btn_countryFilter.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_countryFilter.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_countryFilter.Location = new System.Drawing.Point(12, 12);
            this.btn_countryFilter.Name = "btn_countryFilter";
            this.btn_countryFilter.Size = new System.Drawing.Size(318, 54);
            this.btn_countryFilter.TabIndex = 0;
            this.btn_countryFilter.Text = "Filtra per paese di provenienza";
            this.btn_countryFilter.UseVisualStyleBackColor = false;
            this.btn_countryFilter.Click += new System.EventHandler(this.btn_countryFilter_Click);
            // 
            // btn_genreFilter
            // 
            this.btn_genreFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(80)))));
            this.btn_genreFilter.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_genreFilter.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_genreFilter.Location = new System.Drawing.Point(12, 72);
            this.btn_genreFilter.Name = "btn_genreFilter";
            this.btn_genreFilter.Size = new System.Drawing.Size(318, 54);
            this.btn_genreFilter.TabIndex = 1;
            this.btn_genreFilter.Text = "Filtra per genere di appartenenza";
            this.btn_genreFilter.UseVisualStyleBackColor = false;
            this.btn_genreFilter.Click += new System.EventHandler(this.btn_genreFilter_Click);
            // 
            // btn_increasingSort
            // 
            this.btn_increasingSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(80)))));
            this.btn_increasingSort.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_increasingSort.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_increasingSort.Location = new System.Drawing.Point(12, 132);
            this.btn_increasingSort.Name = "btn_increasingSort";
            this.btn_increasingSort.Size = new System.Drawing.Size(318, 54);
            this.btn_increasingSort.TabIndex = 2;
            this.btn_increasingSort.Text = "Ordina in modo crescente";
            this.btn_increasingSort.UseVisualStyleBackColor = false;
            this.btn_increasingSort.Click += new System.EventHandler(this.btn_increasingSort_Click);
            // 
            // btn_decreasingSort
            // 
            this.btn_decreasingSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(80)))));
            this.btn_decreasingSort.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_decreasingSort.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_decreasingSort.Location = new System.Drawing.Point(12, 192);
            this.btn_decreasingSort.Name = "btn_decreasingSort";
            this.btn_decreasingSort.Size = new System.Drawing.Size(318, 54);
            this.btn_decreasingSort.TabIndex = 3;
            this.btn_decreasingSort.Text = "Ordina in modo decrescente";
            this.btn_decreasingSort.UseVisualStyleBackColor = false;
            this.btn_decreasingSort.Click += new System.EventHandler(this.btn_decreasingSort_Click);
            // 
            // list_artistsCharts
            // 
            this.list_artistsCharts.HideSelection = false;
            this.list_artistsCharts.Location = new System.Drawing.Point(336, 12);
            this.list_artistsCharts.Name = "list_artistsCharts";
            this.list_artistsCharts.Size = new System.Drawing.Size(294, 294);
            this.list_artistsCharts.TabIndex = 5;
            this.list_artistsCharts.UseCompatibleStateImageBehavior = false;
            this.list_artistsCharts.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btn_compareArtists
            // 
            this.btn_compareArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(80)))));
            this.btn_compareArtists.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_compareArtists.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_compareArtists.Location = new System.Drawing.Point(12, 252);
            this.btn_compareArtists.Name = "btn_compareArtists";
            this.btn_compareArtists.Size = new System.Drawing.Size(318, 54);
            this.btn_compareArtists.TabIndex = 6;
            this.btn_compareArtists.Text = "Compara due artisti";
            this.btn_compareArtists.UseVisualStyleBackColor = false;
            this.btn_compareArtists.Click += new System.EventHandler(this.btn_compareArtists_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(647, 323);
            this.Controls.Add(this.btn_compareArtists);
            this.Controls.Add(this.list_artistsCharts);
            this.Controls.Add(this.btn_decreasingSort);
            this.Controls.Add(this.btn_increasingSort);
            this.Controls.Add(this.btn_genreFilter);
            this.Controls.Add(this.btn_countryFilter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_countryFilter;
        private System.Windows.Forms.Button btn_genreFilter;
        private System.Windows.Forms.Button btn_increasingSort;
        private System.Windows.Forms.Button btn_decreasingSort;
        private System.Windows.Forms.ListView list_artistsCharts;
        private System.Windows.Forms.Button btn_compareArtists;
    }
}

