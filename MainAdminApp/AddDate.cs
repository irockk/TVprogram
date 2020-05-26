using ConsoleAppTry.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAdminApp
{
   public partial class AddDate : Form
    {
       public TVprogram program;
        public Date Date { set; get; }
        public AddDate()
        {
            InitializeComponent();
        }
        private void AddDate_Load(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            DurationBox.Text = "в хвилинах";
            DurationBox.ForeColor = Color.Gray;
            foreach (TVshow i in program.tvshowList)
            {
                NameBox.Items.Add(i.Id + "- " + i.Name);
            }
        }
        private void DurationBox_Enter(object sender, EventArgs e)
        {
            DurationBox.Text = null;
            DurationBox.ForeColor = Color.Black;
        }
        private void Addbutton_Click(object sender, EventArgs e)
        {
            string IdShow = NameBox.Text.Substring(0, NameBox.Text.IndexOf('-'));
            if (!TVprogram.CheckDuration(DurationBox.Text) || Convert.ToDouble(DurationBox.Text) <= 0)  MessageBox.Show("Неправильний формат. Введіть значення у хвилинах!");
            else if(!program.CheckTime(dateTimePicker.Value, Convert.ToDouble(DurationBox.Text), Convert.ToInt32(IdShow))) MessageBox.Show("Цей час недоступний!");
            else
            {
                Date = new Date(dateTimePicker.Value, Convert.ToDouble(DurationBox.Text), Convert.ToInt32(IdShow));
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
