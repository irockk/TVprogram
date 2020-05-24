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
            this.всіТелешоуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouriteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forTodayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forNextHourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forThisWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forTomorrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forNextWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjfgdfkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byChanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.TvshowGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chanelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Favourite = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tVshowBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DateGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChanelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.favouriteToolStripMenuItem1,
            this.showToolStripMenuItem,
            this.hjfgdfkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всіТелешоуToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // всіТелешоуToolStripMenuItem
            // 
            this.всіТелешоуToolStripMenuItem.Name = "всіТелешоуToolStripMenuItem";
            this.всіТелешоуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.всіТелешоуToolStripMenuItem.Text = "Всі телешоу";
            this.всіТелешоуToolStripMenuItem.Click += new System.EventHandler(this.всіТелешоуToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Зберегти";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Вийти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // favouriteToolStripMenuItem1
            // 
            this.favouriteToolStripMenuItem1.Name = "favouriteToolStripMenuItem1";
            this.favouriteToolStripMenuItem1.Size = new System.Drawing.Size(76, 22);
            this.favouriteToolStripMenuItem1.Text = "Улюблене";
            this.favouriteToolStripMenuItem1.Click += new System.EventHandler(this.favouriteToolStripMenuItem1_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forNowToolStripMenuItem,
            this.forTodayToolStripMenuItem,
            this.forNextHourToolStripMenuItem,
            this.forThisWeekToolStripMenuItem,
            this.forTomorrowToolStripMenuItem,
            this.forNextWeekToolStripMenuItem});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.showToolStripMenuItem.Text = "Телепрограма";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // forNowToolStripMenuItem
            // 
            this.forNowToolStripMenuItem.Name = "forNowToolStripMenuItem";
            this.forNowToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.forNowToolStripMenuItem.Text = "на зараз";
            // 
            // forTodayToolStripMenuItem
            // 
            this.forTodayToolStripMenuItem.Name = "forTodayToolStripMenuItem";
            this.forTodayToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.forTodayToolStripMenuItem.Text = "на сьогодні";
            // 
            // forNextHourToolStripMenuItem
            // 
            this.forNextHourToolStripMenuItem.Name = "forNextHourToolStripMenuItem";
            this.forNextHourToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.forNextHourToolStripMenuItem.Text = "на завтра";
            // 
            // forThisWeekToolStripMenuItem
            // 
            this.forThisWeekToolStripMenuItem.Name = "forThisWeekToolStripMenuItem";
            this.forThisWeekToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.forThisWeekToolStripMenuItem.Text = "на вчора";
            // 
            // forTomorrowToolStripMenuItem
            // 
            this.forTomorrowToolStripMenuItem.Name = "forTomorrowToolStripMenuItem";
            this.forTomorrowToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.forTomorrowToolStripMenuItem.Text = "на наступні 7 днів";
            // 
            // forNextWeekToolStripMenuItem
            // 
            this.forNextWeekToolStripMenuItem.Name = "forNextWeekToolStripMenuItem";
            this.forNextWeekToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.forNextWeekToolStripMenuItem.Text = "всі дати";
            this.forNextWeekToolStripMenuItem.Click += new System.EventHandler(this.forNextWeekToolStripMenuItem_Click);
            // 
            // hjfgdfkToolStripMenuItem
            // 
            this.hjfgdfkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byNameToolStripMenuItem,
            this.byGenreToolStripMenuItem,
            this.byChanelToolStripMenuItem});
            this.hjfgdfkToolStripMenuItem.Name = "hjfgdfkToolStripMenuItem";
            this.hjfgdfkToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.hjfgdfkToolStripMenuItem.Text = "Сортувати";
            this.hjfgdfkToolStripMenuItem.Click += new System.EventHandler(this.hjfgdfkToolStripMenuItem_Click);
            // 
            // byNameToolStripMenuItem
            // 
            this.byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            this.byNameToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.byNameToolStripMenuItem.Text = "по назві";
            this.byNameToolStripMenuItem.Click += new System.EventHandler(this.byNameToolStripMenuItem_Click);
            // 
            // byGenreToolStripMenuItem
            // 
            this.byGenreToolStripMenuItem.Name = "byGenreToolStripMenuItem";
            this.byGenreToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.byGenreToolStripMenuItem.Text = "по жанру";
            this.byGenreToolStripMenuItem.Click += new System.EventHandler(this.byGenreToolStripMenuItem_Click);
            // 
            // byChanelToolStripMenuItem
            // 
            this.byChanelToolStripMenuItem.Name = "byChanelToolStripMenuItem";
            this.byChanelToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.byChanelToolStripMenuItem.Text = "по каналу";
            this.byChanelToolStripMenuItem.Click += new System.EventHandler(this.byChanelToolStripMenuItem_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(300, 4);
            this.SearchBox.MaxLength = 1000;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(472, 20);
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
            this.TvshowGridView.Location = new System.Drawing.Point(12, 30);
            this.TvshowGridView.Name = "TvshowGridView";
            this.TvshowGridView.ReadOnly = true;
            this.TvshowGridView.RowHeadersWidth = 62;
            this.TvshowGridView.Size = new System.Drawing.Size(760, 400);
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
            this.DateGridView.AutoGenerateColumns = false;
            this.DateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.ChanelName,
            this.startTimeDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.DateGridView.DataSource = this.dateBindingSource;
            this.DateGridView.Location = new System.Drawing.Point(12, 30);
            this.DateGridView.Name = "DateGridView";
            this.DateGridView.RowHeadersWidth = 62;
            this.DateGridView.Size = new System.Drawing.Size(760, 400);
            this.DateGridView.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Назва";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 130;
            // 
            // ChanelName
            // 
            this.ChanelName.HeaderText = "Канал";
            this.ChanelName.MinimumWidth = 8;
            this.ChanelName.Name = "ChanelName";
            this.ChanelName.ReadOnly = true;
            this.ChanelName.Width = 150;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Час початку";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.startTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Тривалість";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            this.durationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.durationDataGridViewTextBoxColumn.Width = 150;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "Час закінченні";
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
            this.FavGridView.Location = new System.Drawing.Point(13, 30);
            this.FavGridView.Name = "FavGridView";
            this.FavGridView.ReadOnly = true;
            this.FavGridView.Size = new System.Drawing.Size(759, 400);
            this.FavGridView.TabIndex = 6;
            // 
            // Name
            // 
            this.Name.HeaderText = "Назва";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Жанр";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Калан
            // 
            this.Калан.HeaderText = "Канал";
            this.Калан.Name = "Калан";
            this.Калан.ReadOnly = true;
            this.Калан.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MainMenuViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 456);
            this.Controls.Add(this.FavGridView);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TvshowGridView);
            this.Controls.Add(this.DateGridView);
            this.MaximumSize = new System.Drawing.Size(896, 538);
            this.MinimumSize = new System.Drawing.Size(648, 388);
     //       this.Name = "MainMenuViewer";
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
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forTodayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forNextHourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forTomorrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forThisWeekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forNextWeekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjfgdfkToolStripMenuItem;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChanelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView FavGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Калан;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.ToolStripMenuItem всіТелешоуToolStripMenuItem;
    }
}