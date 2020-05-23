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
        public AddDate()
        {
            InitializeComponent();
        }
        
        private void AddDate_Load(object sender, EventArgs e)
        {
            DurationBox.Text = "в хвилинах";
            DurationBox.ForeColor = Color.Gray;
        }

        private void DurationBox_Enter(object sender, EventArgs e)
        {
            DurationBox.Text = null;
            DurationBox.ForeColor = Color.Black;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if(!TVprogram.CheckDuration(DurationBox.Text))  MessageBox.Show("Неправильний формат. Введіть значення у хвилинах!");
            else if(!program.CheckTime(dateTimePicker.Value, Convert.ToDouble(DurationBox.Text))) MessageBox.Show("Цей час недоступний!");
        }
    }
}
