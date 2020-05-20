namespace MainAdminApp
{
    partial class AddNew
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Genrelabel = new System.Windows.Forms.Label();
            this.Chanellabel = new System.Windows.Forms.Label();
            this.OKbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.ChanelBox = new System.Windows.Forms.ComboBox();
            this.GenreBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(92, 48);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(331, 26);
            this.NameBox.TabIndex = 0;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(20, 52);
            this.Namelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(60, 20);
            this.Namelabel.TabIndex = 1;
            this.Namelabel.Text = "Назва:";
            // 
            // Genrelabel
            // 
            this.Genrelabel.AutoSize = true;
            this.Genrelabel.Location = new System.Drawing.Point(24, 105);
            this.Genrelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Genrelabel.Name = "Genrelabel";
            this.Genrelabel.Size = new System.Drawing.Size(53, 20);
            this.Genrelabel.TabIndex = 2;
            this.Genrelabel.Text = "Жанр:";
            // 
            // Chanellabel
            // 
            this.Chanellabel.AutoSize = true;
            this.Chanellabel.Location = new System.Drawing.Point(24, 162);
            this.Chanellabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Chanellabel.Name = "Chanellabel";
            this.Chanellabel.Size = new System.Drawing.Size(60, 20);
            this.Chanellabel.TabIndex = 4;
            this.Chanellabel.Text = "Канал:";
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(18, 348);
            this.OKbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(112, 35);
            this.OKbutton.TabIndex = 6;
            this.OKbutton.Text = "Ok";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(446, 348);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(112, 35);
            this.Cancelbutton.TabIndex = 7;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // ChanelBox
            // 
            this.ChanelBox.FormattingEnabled = true;
            this.ChanelBox.Items.AddRange(new object[] {
            "1+1",
            "Інтер",
            "НТН",
            "UA: Перший\t",
            "ICTV",
            "Україна 24",
            "Zoom",
            "СТБ",
            "ТЕТ",
            "К2",
            "5 канал"});
            this.ChanelBox.Location = new System.Drawing.Point(91, 162);
            this.ChanelBox.Name = "ChanelBox";
            this.ChanelBox.Size = new System.Drawing.Size(331, 28);
            this.ChanelBox.TabIndex = 8;
            // 
            // GenreBox
            // 
            this.GenreBox.FormattingEnabled = true;
            this.GenreBox.Items.AddRange(new object[] {
            "Реаліті-шоу",
            "Ток-шоу",
            "Художній фільм",
            "Новини",
            "Дитячі",
            "Політичні",
            "Освітні"});
            this.GenreBox.Location = new System.Drawing.Point(90, 105);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(332, 28);
            this.GenreBox.TabIndex = 9;
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 402);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.ChanelBox);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.Chanellabel);
            this.Controls.Add(this.Genrelabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.NameBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddNew";
            this.Text = "AddNew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Genrelabel;
        private System.Windows.Forms.Label Chanellabel;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.ComboBox ChanelBox;
        private System.Windows.Forms.ComboBox GenreBox;
    }
}