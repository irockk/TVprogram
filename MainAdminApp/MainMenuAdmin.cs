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
            program.FillTestData(100);
            userBindingSource.DataSource = program.userList;
            TVshowGridView.DataSource = program.tvshowList;
            UsersGridView.Hide();
            label1.Hide();
            TVshowGridView.Hide();
        
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            program.Load();
            tVshowBindingSource.ResetBindings(false);
        }

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
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            program.Save();
        }

        private void seeAlViewersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersGridView.Show();
            label1.Show();
        }

        private void seeAllTVshowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TVshowGridView.Show();
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
            if (pf.ShowDialog() == DialogResult.OK)
            {
                program.AddTVshow(pf.TVshow);
                tVshowBindingSource.ResetBindings(false);
                program.IsDirty = true;

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
                if (pf.ShowDialog() == DialogResult.OK)
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
       
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
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
            string Genre = "(Genre LIKE  '" + SearchBox.Text + "*')";
            view.RowFilter = Genre;
         //   string Chanel = "(ChanelName LIKE  '" + SearchBox.Text + "*')";
         //   view.RowFilter = Chanel;
          //  string Id = "(Id LIKE  '" + SearchBox.Text + "*')";
          //  view.RowFilter = Id;
            TVshowGridView.DataSource = view;
        }

        private void MainMenuAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
