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
            this.NameBox.Location = new System.Drawing.Point(61, 31);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(222, 20);
            this.NameBox.TabIndex = 0;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(13, 34);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(42, 13);
            this.Namelabel.TabIndex = 1;
            this.Namelabel.Text = "Назва:";
            // 
            // Genrelabel
            // 
            this.Genrelabel.AutoSize = true;
            this.Genrelabel.Location = new System.Drawing.Point(16, 68);
            this.Genrelabel.Name = "Genrelabel";
            this.Genrelabel.Size = new System.Drawing.Size(39, 13);
            this.Genrelabel.TabIndex = 2;
            this.Genrelabel.Text = "Жанр:";
            // 
            // Chanellabel
            // 
            this.Chanellabel.AutoSize = true;
            this.Chanellabel.Location = new System.Drawing.Point(16, 105);
            this.Chanellabel.Name = "Chanellabel";
            this.Chanellabel.Size = new System.Drawing.Size(41, 13);
            this.Chanellabel.TabIndex = 4;
            this.Chanellabel.Text = "Канал:";
            // 
            // OKbutton
            // 
            this.OKbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbutton.Location = new System.Drawing.Point(12, 226);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 6;
            this.OKbutton.Text = "Додати";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbutton.Location = new System.Drawing.Point(297, 226);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 7;
            this.Cancelbutton.Text = "Скасувати";
            this.Cancelbutton.UseVisualStyleBackColor = true;
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
            this.ChanelBox.Location = new System.Drawing.Point(61, 105);
            this.ChanelBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChanelBox.Name = "ChanelBox";
            this.ChanelBox.Size = new System.Drawing.Size(222, 21);
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
            this.GenreBox.Location = new System.Drawing.Point(60, 68);
            this.GenreBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(223, 21);
            this.GenreBox.TabIndex = 9;
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.ChanelBox);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.Chanellabel);
            this.Controls.Add(this.Genrelabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.NameBox);
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