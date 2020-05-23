namespace MainAdminApp
{
    partial class AddDate
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
            this.Addbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DurationBox = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(12, 225);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 0;
            this.Addbutton.Text = "Додати";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(302, 225);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(70, 24);
            this.Cancelbutton.TabIndex = 1;
            this.Cancelbutton.Text = "Скасувати";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(127, 40);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // DurationBox
            // 
            this.DurationBox.Location = new System.Drawing.Point(127, 148);
            this.DurationBox.Name = "DurationBox";
            this.DurationBox.Size = new System.Drawing.Size(100, 20);
            this.DurationBox.TabIndex = 3;
            this.DurationBox.Enter += new System.EventHandler(this.DurationBox_Enter);
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(9, 40);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(112, 13);
            this.start.TabIndex = 4;
            this.start.Text = "Час та дата початку:";
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Location = new System.Drawing.Point(55, 151);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(66, 13);
            this.duration.TabIndex = 5;
            this.duration.Text = "Тривалість:";
            // 
            // AddDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.start);
            this.Controls.Add(this.DurationBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Addbutton);
            this.Name = "AddDate";
            this.Text = "AddDate";
            this.Load += new System.EventHandler(this.AddDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox DurationBox;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label duration;
    }
}