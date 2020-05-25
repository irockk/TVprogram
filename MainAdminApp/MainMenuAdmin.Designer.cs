namespace MainAdminApp
{
    partial class MainMenuAdmin
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TVprogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наСьогодніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наЗавтраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наЦейТижденьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всіДатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TVshowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TVshowGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chanelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tVshowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.UsersCount = new System.Windows.Forms.Label();
            this.DateGridView = new System.Windows.Forms.DataGridView();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Searchbutton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TVshowGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tVshowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.TVprogramToolStripMenuItem,
            this.DateToolStripMenuItem,
            this.TVshowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveToolStripMenuItem.Text = "Зберегти";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitToolStripMenuItem.Text = "Вийти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // TVprogramToolStripMenuItem
            // 
            this.TVprogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наСьогодніToolStripMenuItem,
            this.наЗавтраToolStripMenuItem,
            this.наЦейТижденьToolStripMenuItem,
            this.всіДатиToolStripMenuItem});
            this.TVprogramToolStripMenuItem.Name = "TVprogramToolStripMenuItem";
            this.TVprogramToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.TVprogramToolStripMenuItem.Text = "Телепрограма";
            this.TVprogramToolStripMenuItem.Click += new System.EventHandler(this.TVprogramToolStripMenuItem_Click);
            // 
            // наСьогодніToolStripMenuItem
            // 
            this.наСьогодніToolStripMenuItem.Name = "наСьогодніToolStripMenuItem";
            this.наСьогодніToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.наСьогодніToolStripMenuItem.Text = "на сьогодні";
            this.наСьогодніToolStripMenuItem.Click += new System.EventHandler(this.наСьогодніToolStripMenuItem_Click);
            // 
            // наЗавтраToolStripMenuItem
            // 
            this.наЗавтраToolStripMenuItem.Name = "наЗавтраToolStripMenuItem";
            this.наЗавтраToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.наЗавтраToolStripMenuItem.Text = "на завтра";
            this.наЗавтраToolStripMenuItem.Click += new System.EventHandler(this.наЗавтраToolStripMenuItem_Click);
            // 
            // наЦейТижденьToolStripMenuItem
            // 
            this.наЦейТижденьToolStripMenuItem.Name = "наЦейТижденьToolStripMenuItem";
            this.наЦейТижденьToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.наЦейТижденьToolStripMenuItem.Text = "на наступні 7 днів";
            this.наЦейТижденьToolStripMenuItem.Click += new System.EventHandler(this.наЦейТижденьToolStripMenuItem_Click);
            // 
            // всіДатиToolStripMenuItem
            // 
            this.всіДатиToolStripMenuItem.Name = "всіДатиToolStripMenuItem";
            this.всіДатиToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.всіДатиToolStripMenuItem.Text = "всі дати";
            this.всіДатиToolStripMenuItem.Click += new System.EventHandler(this.всіДатиToolStripMenuItem_Click);
            // 
            // DateToolStripMenuItem
            // 
            this.DateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиToolStripMenuItem,
            this.видалитиToolStripMenuItem});
            this.DateToolStripMenuItem.Name = "DateToolStripMenuItem";
            this.DateToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.DateToolStripMenuItem.Text = "Дата";
            // 
            // додатиToolStripMenuItem
            // 
            this.додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            this.додатиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.додатиToolStripMenuItem.Text = "Додати";
            this.додатиToolStripMenuItem.Click += new System.EventHandler(this.додатиToolStripMenuItem_Click);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click_1);
            // 
            // TVshowToolStripMenuItem
            // 
            this.TVshowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.TVshowToolStripMenuItem.Name = "TVshowToolStripMenuItem";
            this.TVshowToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.TVshowToolStripMenuItem.Text = "Телепередача";
            this.TVshowToolStripMenuItem.Click += new System.EventHandler(this.TVshowToolStripMenuItem_Click_1);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.addToolStripMenuItem.Text = "Додати";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.editToolStripMenuItem.Text = "Редагувати";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.deleteToolStripMenuItem.Text = "Видалити";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // TVshowGridView
            // 
            this.TVshowGridView.AllowUserToResizeColumns = false;
            this.TVshowGridView.AllowUserToResizeRows = false;
            this.TVshowGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TVshowGridView.AutoGenerateColumns = false;
            this.TVshowGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TVshowGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.chanelNameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.TVshowGridView.DataSource = this.tVshowBindingSource;
            this.TVshowGridView.Location = new System.Drawing.Point(11, 25);
            this.TVshowGridView.Name = "TVshowGridView";
            this.TVshowGridView.ReadOnly = true;
            this.TVshowGridView.RowHeadersWidth = 62;
            this.TVshowGridView.Size = new System.Drawing.Size(834, 419);
            this.TVshowGridView.TabIndex = 5;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.genreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.genreDataGridViewTextBoxColumn.Width = 150;
            // 
            // chanelNameDataGridViewTextBoxColumn
            // 
            this.chanelNameDataGridViewTextBoxColumn.DataPropertyName = "ChanelName";
            this.chanelNameDataGridViewTextBoxColumn.HeaderText = "Канал";
            this.chanelNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chanelNameDataGridViewTextBoxColumn.Name = "chanelNameDataGridViewTextBoxColumn";
            this.chanelNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.chanelNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.chanelNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // tVshowBindingSource
            // 
            this.tVshowBindingSource.DataSource = typeof(ConsoleAppTry.Models.TVshow);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(288, 3);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(474, 20);
            this.SearchBox.TabIndex = 6;
            // 
            // UsersCount
            // 
            this.UsersCount.AutoSize = true;
            this.UsersCount.Location = new System.Drawing.Point(285, 90);
            this.UsersCount.Name = "UsersCount";
            this.UsersCount.Size = new System.Drawing.Size(0, 13);
            this.UsersCount.TabIndex = 7;
            // 
            // DateGridView
            // 
            this.DateGridView.AllowUserToAddRows = false;
            this.DateGridView.AutoGenerateColumns = false;
            this.DateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startTimeDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1});
            this.DateGridView.DataSource = this.dateBindingSource;
            this.DateGridView.Location = new System.Drawing.Point(11, 25);
            this.DateGridView.Name = "DateGridView";
            this.DateGridView.ReadOnly = true;
            this.DateGridView.RowHeadersWidth = 62;
            this.DateGridView.Size = new System.Drawing.Size(833, 418);
            this.DateGridView.TabIndex = 9;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Час початку";
            this.startTimeDataGridViewTextBoxColumn.MaxInputLength = 100;
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
            this.durationDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            this.durationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.durationDataGridViewTextBoxColumn.Width = 70;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "Час закінчення";
            this.endTimeDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.endTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id телешоу";
            this.idDataGridViewTextBoxColumn1.MaxInputLength = 100;
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idDataGridViewTextBoxColumn1.Width = 70;
            // 
            // dateBindingSource
            // 
            this.dateBindingSource.DataSource = typeof(ConsoleAppTry.Models.Date);
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(767, 3);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(75, 20);
            this.Searchbutton.TabIndex = 10;
            this.Searchbutton.Text = "Знайти";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // MainMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 456);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.UsersCount);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DateGridView);
            this.Controls.Add(this.TVshowGridView);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(988, 518);
            this.MinimumSize = new System.Drawing.Size(662, 299);
            this.Name = "MainMenuAdmin";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TVshowGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tVshowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TVshowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.DataGridView TVshowGridView;
        private System.Windows.Forms.BindingSource tVshowBindingSource;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label UsersCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chanelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem TVprogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.DataGridView DateGridView;
        private System.Windows.Forms.BindingSource dateBindingSource;
        private System.Windows.Forms.ToolStripMenuItem наСьогодніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наЗавтраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наЦейТижденьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всіДатиToolStripMenuItem;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
    }
}

