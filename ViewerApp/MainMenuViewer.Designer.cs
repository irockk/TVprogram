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
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouriteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forTodayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forNextHourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forTomorrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forThisWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forNextWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjfgdfkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byChanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.TvshowGridView = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chanelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Favourite = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tVshowBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.unsortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TvshowGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tVshowBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.favouriteToolStripMenuItem1,
            this.showToolStripMenuItem,
            this.hjfgdfkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.saveToolStripMenuItem.Text = "Save All";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // favouriteToolStripMenuItem1
            // 
            this.favouriteToolStripMenuItem1.Name = "favouriteToolStripMenuItem1";
            this.favouriteToolStripMenuItem1.Size = new System.Drawing.Size(100, 29);
            this.favouriteToolStripMenuItem1.Text = "Favourite";
            this.favouriteToolStripMenuItem1.Click += new System.EventHandler(this.favouriteToolStripMenuItem1_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forNowToolStripMenuItem,
            this.forTodayToolStripMenuItem,
            this.forNextHourToolStripMenuItem,
            this.forTomorrowToolStripMenuItem,
            this.forThisWeekToolStripMenuItem,
            this.forNextWeekToolStripMenuItem});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.showToolStripMenuItem.Text = "TVprogram";
            // 
            // forNowToolStripMenuItem
            // 
            this.forNowToolStripMenuItem.Name = "forNowToolStripMenuItem";
            this.forNowToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.forNowToolStripMenuItem.Text = "For now";
            // 
            // forTodayToolStripMenuItem
            // 
            this.forTodayToolStripMenuItem.Name = "forTodayToolStripMenuItem";
            this.forTodayToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.forTodayToolStripMenuItem.Text = "For today";
            // 
            // forNextHourToolStripMenuItem
            // 
            this.forNextHourToolStripMenuItem.Name = "forNextHourToolStripMenuItem";
            this.forNextHourToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.forNextHourToolStripMenuItem.Text = "For next hour";
            // 
            // forTomorrowToolStripMenuItem
            // 
            this.forTomorrowToolStripMenuItem.Name = "forTomorrowToolStripMenuItem";
            this.forTomorrowToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.forTomorrowToolStripMenuItem.Text = "For tomorrow";
            // 
            // forThisWeekToolStripMenuItem
            // 
            this.forThisWeekToolStripMenuItem.Name = "forThisWeekToolStripMenuItem";
            this.forThisWeekToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.forThisWeekToolStripMenuItem.Text = "For this week";
            // 
            // forNextWeekToolStripMenuItem
            // 
            this.forNextWeekToolStripMenuItem.Name = "forNextWeekToolStripMenuItem";
            this.forNextWeekToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.forNextWeekToolStripMenuItem.Text = "For next week";
            // 
            // hjfgdfkToolStripMenuItem
            // 
            this.hjfgdfkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byNameToolStripMenuItem,
            this.byGenreToolStripMenuItem,
            this.byChanelToolStripMenuItem,
            this.unsortToolStripMenuItem});
            this.hjfgdfkToolStripMenuItem.Name = "hjfgdfkToolStripMenuItem";
            this.hjfgdfkToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.hjfgdfkToolStripMenuItem.Text = "Sort";
            // 
            // byNameToolStripMenuItem
            // 
            this.byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            this.byNameToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.byNameToolStripMenuItem.Text = "by name";
            this.byNameToolStripMenuItem.Click += new System.EventHandler(this.byNameToolStripMenuItem_Click);
            // 
            // byGenreToolStripMenuItem
            // 
            this.byGenreToolStripMenuItem.Name = "byGenreToolStripMenuItem";
            this.byGenreToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.byGenreToolStripMenuItem.Text = "by genre";
            this.byGenreToolStripMenuItem.Click += new System.EventHandler(this.byGenreToolStripMenuItem_Click);
            // 
            // byChanelToolStripMenuItem
            // 
            this.byChanelToolStripMenuItem.Name = "byChanelToolStripMenuItem";
            this.byChanelToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.byChanelToolStripMenuItem.Text = "by chanel";
            this.byChanelToolStripMenuItem.Click += new System.EventHandler(this.byChanelToolStripMenuItem_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(18, 42);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBox.MaxLength = 1000;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(1138, 26);
            this.SearchBox.TabIndex = 3;
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
            this.Index,
            this.nameDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.chanelNameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.Favourite});
            this.TvshowGridView.DataSource = this.tVshowBindingSource1;
            this.TvshowGridView.Location = new System.Drawing.Point(18, 82);
            this.TvshowGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TvshowGridView.Name = "TvshowGridView";
            this.TvshowGridView.ReadOnly = true;
            this.TvshowGridView.RowHeadersWidth = 62;
            this.TvshowGridView.Size = new System.Drawing.Size(1140, 615);
            this.TvshowGridView.TabIndex = 4;
            this.TvshowGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TvshowGridView_CellContentClick);
            this.TvshowGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.TvshowGridView_RowsAdded);
            // 
            // Index
            // 
            this.Index.HeaderText = "№";
            this.Index.MaxInputLength = 10;
            this.Index.MinimumWidth = 8;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Index.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.genreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.genreDataGridViewTextBoxColumn.Width = 150;
            // 
            // chanelNameDataGridViewTextBoxColumn
            // 
            this.chanelNameDataGridViewTextBoxColumn.DataPropertyName = "ChanelName";
            this.chanelNameDataGridViewTextBoxColumn.HeaderText = "ChanelName";
            this.chanelNameDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.chanelNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chanelNameDataGridViewTextBoxColumn.Name = "chanelNameDataGridViewTextBoxColumn";
            this.chanelNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.chanelNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chanelNameDataGridViewTextBoxColumn.Width = 150;
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
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // Favourite
            // 
            this.Favourite.HeaderText = "Favourite";
            this.Favourite.MinimumWidth = 8;
            this.Favourite.Name = "Favourite";
            this.Favourite.ReadOnly = true;
            this.Favourite.Width = 70;
            // 
            // tVshowBindingSource1
            // 
            this.tVshowBindingSource1.DataSource = typeof(ConsoleAppTry.Models.TVshow);
            // 
            // unsortToolStripMenuItem
            // 
            this.unsortToolStripMenuItem.Name = "unsortToolStripMenuItem";
            this.unsortToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.unsortToolStripMenuItem.Text = "unsort";
            // 
            // MainMenuViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 709);
            this.Controls.Add(this.TvshowGridView);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1339, 816);
            this.MinimumSize = new System.Drawing.Size(889, 585);
            this.Name = "MainMenuViewer";
            this.Text = "MainMenuViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuViewer_FormClosing);
            this.Load += new System.EventHandler(this.MainMenuViewer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TvshowGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tVshowBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chanelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Favourite;
        private System.Windows.Forms.ToolStripMenuItem unsortToolStripMenuItem;
    }
}