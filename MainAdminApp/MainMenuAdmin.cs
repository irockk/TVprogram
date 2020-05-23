using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleAppTry.Models;

namespace MainAdminApp
{
    public partial class MainMenuAdmin : Form
    {
        TVprogram program;
        public MainMenuAdmin()
        {
            InitializeComponent();
            program = new TVprogram();
            //program.FillTestData(100);
            program.Load();
            tVshowBindingSource.ResetBindings(false);
            userBindingSource.DataSource = program.userList;
            TVshowGridView.DataSource = program.tvshowList;
            UsersGridView.Hide();
            label1.Hide();
            TVshowGridView.Hide();
            SearchBox.Hide();
            UserCount.Hide();
        
        }
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            program.Save();
        }

        private void seeAlViewersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserCount.Text = "Загальна кількість користувачів: " + program.userList.Count.ToString();
            TVshowGridView.Hide();
            SearchBox.Hide();
            UserCount.Show();
            UsersGridView.Show();
            label1.Show();

        }

        private void seeAllTVshowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersGridView.Hide();
            UserCount.Hide();
            label1.Hide();
            TVshowGridView.Show();
            SearchBox.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var toDel = TVshowGridView.SelectedRows[0].DataBoundItem as TVshow;
                var res = MessageBox.Show($"Delete {toDel.Name} ?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    program.tvshowList.Remove(toDel);
                    tVshowBindingSource.ResetBindings(false);
                    program.IsDirty = true;
                    TVshowGridView.Hide();
                    TVshowGridView.Show();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Нічого не виділено. Виделіть весь рядок для видалення!");
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pf = new AddNew();
            if (pf.ShowDialog() == DialogResult.Cancel)
            {
                program.AddTVshow(pf.TVshow);
                tVshowBindingSource.ResetBindings(false);
                program.IsDirty = true;
                TVshowGridView.Hide();
                TVshowGridView.Show();

                // select and scroll to the last row
                var lastIdx = TVshowGridView.Rows.Count - 1;
                TVshowGridView.Rows[lastIdx].Selected = true;
                TVshowGridView.FirstDisplayedScrollingRowIndex = lastIdx;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var toEdit = TVshowGridView.SelectedRows[0].DataBoundItem as TVshow;
                var pf = new AddNew(toEdit);
                if (pf.ShowDialog() == DialogResult.Cancel)
                {
                    tVshowBindingSource.ResetBindings(false);
                    program.IsDirty = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Нічого не виділено. Виделіть весь рядок для редагування!");
            }
        }
       //Фильтр для поиска
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if(SearchBox.Text != "Введіть назву телепередачі")
            FilterDataView();
        }        
        private void FilterDataView()
        {
            DataTable dt = new DataTable();
            DataView view = new DataView();

            dt.Columns.Add("Name");
            dt.Columns.Add("Genre");
            dt.Columns.Add("ChanelName");
            dt.Columns.Add("Id");
            foreach (var element in program.tvshowList)
            {
                dt.Rows.Add(element.Name, element.Genre, element.ChanelName, element.Id);
            }

            view = dt.DefaultView;
            string Name = "(Name LIKE  '" + SearchBox.Text + "*')";
            view.RowFilter = Name;
            TVshowGridView.DataSource = view;
        }
        private void MainMenuAdmin_Load(object sender, EventArgs e)
        {
            SearchBox.Text = "Введіть назву телепередачі";
            SearchBox.ForeColor = Color.Gray;
        }
        private void SearchBox_Enter(object sender, EventArgs e)
        {
            SearchBox.Text = null;
            SearchBox.ForeColor = Color.Black;
        }

        //Выход и сохранение
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!program.IsDirty)
                return;
            var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    program.Save();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        //робота с датами
        private void додатиДатуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pf = new AddDate();
            pf.program = this.program;
            if (pf.ShowDialog() == DialogResult.Cancel)
            {
                tVshowBindingSource.ResetBindings(false);
                program.IsDirty = true;
                TVshowGridView.Hide();
                TVshowGridView.Show();

                // select and scroll to the last row
                var lastIdx = TVshowGridView.Rows.Count - 1;
                TVshowGridView.Rows[lastIdx].Selected = true;
                TVshowGridView.FirstDisplayedScrollingRowIndex = lastIdx;
            }
        }

        private void редагуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
