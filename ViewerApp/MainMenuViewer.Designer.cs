namespace ViewerApp
{
    partial class MainMenuViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TVshowListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouriteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TVprogramStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forTodayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forTomorrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forNext7DaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllDatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byChanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.TvshowGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chanelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Favourite = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tVshowBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DateGridView = new System.Windows.Forms.DataGridView();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChanelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FavGridView = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Калан = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TvshowGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tVshowBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FavGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.favouriteToolStripMenuItem1,
            this.TVprogramStripMenuItem,
            this.SortToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TVshowListToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // TVshowListToolStripMenuItem
            // 
            this.TVshowListToolStripMenuItem.Name = "TVshowListToolStripMenuItem";
            this.TVshowListToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.TVshowListToolStripMenuItem.Text = "Всі телешоу";
            this.TVshowListToolStripMenuItem.Click += new System.EventHandler(this.TVshowListToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.saveToolStripMenuItem.Text = "Зберегти";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(206, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.exitToolStripMenuItem.Text = "Вийти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // favouriteToolStripMenuItem1
            // 
            this.favouriteToolStripMenuItem1.Name = "favouriteToolStripMenuItem1";
            this.favouriteToolStripMenuItem1.Size = new System.Drawing.Size(109, 29);
            this.favouriteToolStripMenuItem1.Text = "Улюблене";
            this.favouriteToolStripMenuItem1.Click += new System.EventHandler(this.favouriteToolStripMenuItem1_Click);
            // 
            // TVprogramStripMenuItem
            // 
            this.TVprogramStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forNowToolStripMenuItem,
            this.forTodayToolStripMenuItem,
            this.forTomorrowToolStripMenuItem,
            this.forNext7DaysToolStripMenuItem,
            this.AllDatesToolStripMenuItem});
            this.TVprogramStripMenuItem.Name = "TVprogramStripMenuItem";
            this.TVprogramStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.TVprogramStripMenuItem.Text = "Телепрограма";
            this.TVprogramStripMenuItem.Click += new System.EventHandler(this.TVprogramStripMenuItem_Click);
            // 
            // forNowToolStripMenuItem
            // 
            this.forNowToolStripMenuItem.Name = "forNowToolStripMenuItem";
            this.forNowToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.forNowToolStripMenuItem.Text = "на зараз";
            this.forNowToolStripMenuItem.Click += new System.EventHandler(this.forNowToolStripMenuItem_Click);
            // 
            // forTodayToolStripMenuItem
            // 
            this.forTodayToolStripMenuItem.Name = "forTodayToolStripMenuItem";
            this.forTodayToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.forTodayToolStripMenuItem.Text = "на сьогодні";
            this.forTodayToolStripMenuItem.Click += new System.EventHandler(this.forTodayToolStripMenuItem_Click);
            // 
            // forTomorrowToolStripMenuItem
            // 
            this.forTomorrowToolStripMenuItem.Name = "forTomorrowToolStripMenuItem";
            this.forTomorrowToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.forTomorrowToolStripMenuItem.Text = "на завтра";
            this.forTomorrowToolStripMenuItem.Click += new System.EventHandler(this.forTomorrowToolStripMenuItem_Click);
            // 
            // forNext7DaysToolStripMenuItem
            // 
            this.forNext7DaysToolStripMenuItem.Name = "forNext7DaysToolStripMenuItem";
            this.forNext7DaysToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.forNext7DaysToolStripMenuItem.Text = "на наступні 7 днів";
            this.forNext7DaysToolStripMenuItem.Click += new System.EventHandler(this.forNext7DaysToolStripMenuItem_Click);
            // 
            // AllDatesToolStripMenuItem
            // 
            this.AllDatesToolStripMenuItem.Name = "AllDatesToolStripMenuItem";
            this.AllDatesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.AllDatesToolStripMenuItem.Text = "всі дати";
            this.AllDatesToolStripMenuItem.Click += new System.EventHandler(this.AllDatesToolStripMenuItem_Click);
            // 
            // SortToolStripMenuItem
            // 
            this.SortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byNameToolStripMenuItem,
            this.byGenreToolStripMenuItem,
            this.byChanelToolStripMenuItem,
            this.SearchToolStripMenuItem});
            this.SortToolStripMenuItem.Name = "SortToolStripMenuItem";
            this.SortToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.SortToolStripMenuItem.Text = "Сортувати";
            this.SortToolStripMenuItem.Click += new System.EventHandler(this.SortToolStripMenuItem_Click);
            // 
            // byNameToolStripMenuItem
            // 
            this.byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            this.byNameToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.byNameToolStripMenuItem.Text = "по назві";
            this.byNameToolStripMenuItem.Click += new System.EventHandler(this.byNameToolStripMenuItem_Click);
            // 
            // byGenreToolStripMenuItem
            // 
            this.byGenreToolStripMenuItem.Name = "byGenreToolStripMenuItem";
            this.byGenreToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.byGenreToolStripMenuItem.Text = "по жанру";
            this.byGenreToolStripMenuItem.Click += new System.EventHandler(this.byGenreToolStripMenuItem_Click);
            // 
            // byChanelToolStripMenuItem
            // 
            this.byChanelToolStripMenuItem.Name = "byChanelToolStripMenuItem";
            this.byChanelToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.byChanelToolStripMenuItem.Text = "по каналу";
            this.byChanelToolStripMenuItem.Click += new System.EventHandler(this.byChanelToolStripMenuItem_Click);
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.SearchToolStripMenuItem.Text = "пошук";
            this.SearchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(450, 6);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBox.MaxLength = 1000;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(706, 26);
            this.SearchBox.TabIndex = 3;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            // 
            // TvshowGridView
            // 
            this.TvshowGridView.AllowUserToAddRows = false;
            this.TvshowGridView.AllowUserToDeleteRows = false;
            this.TvshowGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TvshowGridView.AutoGenerateColumns = false;
            this.TvshowGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TvshowGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.chanelNameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.Favourite});
            this.TvshowGridView.DataSource = this.tVshowBindingSource1;
            this.TvshowGridView.Location = new System.Drawing.Point(18, 46);
            this.TvshowGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TvshowGridView.Name = "TvshowGridView";
            this.TvshowGridView.ReadOnly = true;
            this.TvshowGridView.RowHeadersWidth = 62;
            this.TvshowGridView.Size = new System.Drawing.Size(1140, 615);
            this.TvshowGridView.TabIndex = 4;
            this.TvshowGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TvshowGridView_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameDataGridViewTextBoxColumn.Width = 130;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.genreDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.genreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.genreDataGridViewTextBoxColumn.Width = 130;
            // 
            // chanelNameDataGridViewTextBoxColumn
            // 
            this.chanelNameDataGridViewTextBoxColumn.DataPropertyName = "ChanelName";
            this.chanelNameDataGridViewTextBoxColumn.HeaderText = "Канал";
            this.chanelNameDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.chanelNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chanelNameDataGridViewTextBoxColumn.Name = "chanelNameDataGridViewTextBoxColumn";
            this.chanelNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.chanelNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chanelNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // Favourite
            // 
            this.Favourite.HeaderText = "Улюблене";
            this.Favourite.MinimumWidth = 8;
            this.Favourite.Name = "Favourite";
            this.Favourite.ReadOnly = true;
            this.Favourite.Width = 70;
            // 
            // tVshowBindingSource1
            // 
            this.tVshowBindingSource1.DataSource = typeof(ConsoleAppTry.Models.TVshow);
            // 
            // DateGridView
            // 
            this.DateGridView.AllowUserToAddRows = false;
            this.DateGridView.AllowUserToDeleteRows = false;
            this.DateGridView.AutoGenerateColumns = false;
            this.DateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startTimeDataGridViewTextBoxColumn,
            this.NameTV,
            this.ChanelName,
            this.durationDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.DateGridView.DataSource = this.dateBindingSource;
            this.DateGridView.Location = new System.Drawing.Point(18, 46);
            this.DateGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateGridView.Name = "DateGridView";
            this.DateGridView.ReadOnly = true;
            this.DateGridView.RowHeadersWidth = 62;
            this.DateGridView.Size = new System.Drawing.Size(1140, 615);
            this.DateGridView.TabIndex = 5;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Початок";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.startTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // NameTV
            // 
            this.NameTV.DataPropertyName = "NameTV";
            this.NameTV.HeaderText = "Назва";
            this.NameTV.MinimumWidth = 8;
            this.NameTV.Name = "NameTV";
            this.NameTV.ReadOnly = true;
            this.NameTV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameTV.Width = 150;
            // 
            // ChanelName
            // 
            this.ChanelName.DataPropertyName = "ChanelName";
            this.ChanelName.HeaderText = "Канал";
            this.ChanelName.MinimumWidth = 8;
            this.ChanelName.Name = "ChanelName";
            this.ChanelName.ReadOnly = true;
            this.ChanelName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ChanelName.Width = 150;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Тривалість";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            this.durationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.durationDataGridViewTextBoxColumn.Width = 70;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "Кінець";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.endTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // dateBindingSource
            // 
            this.dateBindingSource.DataSource = typeof(ConsoleAppTry.Models.Date);
            // 
            // FavGridView
            // 
            this.FavGridView.AllowUserToAddRows = false;
            this.FavGridView.AllowUserToDeleteRows = false;
            this.FavGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FavGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Genre,
            this.Калан,
            this.Id});
            this.FavGridView.Location = new System.Drawing.Point(20, 46);
            this.FavGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FavGridView.Name = "FavGridView";
            this.FavGridView.ReadOnly = true;
            this.FavGridView.RowHeadersWidth = 62;
            this.FavGridView.Size = new System.Drawing.Size(1138, 615);
            this.FavGridView.TabIndex = 6;
            // 
            // Name
            // 
            this.Name.HeaderText = "Назва";
            this.Name.MinimumWidth = 8;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Name.Width = 150;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Жанр";
            this.Genre.MinimumWidth = 8;
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Genre.Width = 150;
            // 
            // Калан
            // 
            this.Калан.HeaderText = "Канал";
            this.Калан.MinimumWidth = 8;
            this.Калан.Name = "Калан";
            this.Калан.ReadOnly = true;
            this.Калан.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Калан.Width = 150;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 150;
            // 
            // MainMenuViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 702);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DateGridView);
            this.Controls.Add(this.FavGridView);
            this.Controls.Add(this.TvshowGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1333, 798);
            this.MinimumSize = new System.Drawing.Size(961, 567);
  //          this.Name = "MainMenuViewer";
            this.Text = "MainMenuViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuViewer_FormClosing);
            this.Load += new System.EventHandler(this.MainMenuViewer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TvshowGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tVshowBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FavGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favouriteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TVprogramStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forTodayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forTomorrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forNext7DaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllDatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byChanelToolStripMenuItem;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView TvshowGridView;
        private System.Windows.Forms.BindingSource tVshowBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chanelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Favourite;
        private System.Windows.Forms.DataGridView DateGridView;
        private System.Windows.Forms.BindingSource dateBindingSource;
        private System.Windows.Forms.DataGridView FavGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Калан;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.ToolStripMenuItem TVshowListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChanelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
    }
}