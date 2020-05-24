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

namespace ViewerApp
{
    public partial class MainMenuViewer : Form
    {
        public TVprogram program;
        DataTable dt = new DataTable();
        DataTable dtDate = new DataTable();
        public MainMenuViewer(TVprogram pr)
        {
            InitializeComponent();
            program = pr;
            SearchBox.Hide();
            FavGridView.Hide();
            tVshowBindingSource1.DataSource = program.tvshowList;
            DateGridView.Hide();
            dateBindingSource.ResetBindings(false);
            DateGridView.DataSource = program.dateList;
        }
        private void MainMenuViewer_Load(object sender, EventArgs e)
        {
            FillData();
            SearchBox.Text = "Введіть назву телепередачі";
            SearchBox.ForeColor = Color.Gray;
        }

        //вихід і збереження
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            program.Save();
        }
        private void MainMenuViewer_FormClosing(object sender, FormClosingEventArgs e)
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
        
        //додавання до улюблених
        private void TvshowGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                //Reference the GridView Row.
                DataGridViewRow row = TvshowGridView.Rows[e.RowIndex];

                //Set the CheckBox selection.
                row.Cells["Favourite"].Value = !Convert.ToBoolean(row.Cells["Favourite"].EditedFormattedValue);

                DataGridViewCell cell = TvshowGridView.Rows[e.RowIndex].Cells[3];
                int idFav = Int32.Parse(cell.Value.ToString());

                //If CheckBox is checked, display Message Box.
                if (Convert.ToBoolean(row.Cells["Favourite"].Value))
                {

                    program.userCurr.AddFav(program.tvshowList[program.TVshowIndexByID(idFav)]);
                    MessageBox.Show(row.Cells[1].Value + " додано до улюблених");
                    program.IsDirty = true;
                }
                else
                {
                    program.userCurr.DeleteFav(program.tvshowList[e.RowIndex]);
                    MessageBox.Show(row.Cells[1].Value + " видалено з улюблених");
                    program.IsDirty = true;
                }
            }
        }
        private void favouriteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FavGridView.Rows.Clear();
            FillFav();
            DateGridView.Hide();
            TvshowGridView.Hide();
            FavGridView.Show();
        }

        //сортування
        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.DefaultView.Sort = "Name";
        }
        private void byGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.DefaultView.Sort = "Genre";
        }
        private void byChanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.DefaultView.Sort = "ChanelName";
        }
        public void FillData()
        {
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Genre", typeof(string));
            dt.Columns.Add("ChanelName", typeof(string));
            dt.Columns.Add("Id", typeof(int));
            foreach (var element in program.tvshowList)
            {
                dt.Rows.Add(element.Name, element.Genre, element.ChanelName, element.Id);
            }
            TvshowGridView.DataSource = dt;
        }
        public void FillFav()
        {
            foreach(TVshow i in program.userCurr.Favourite)
            {
                FavGridView.Rows.Add(i.Name, i.Genre, i.ChanelName, i.Id);
            }
        }
        //фильтрация
        private void SearchBox_Enter(object sender, EventArgs e)
        {
            SearchBox.Text = null;
            SearchBox.ForeColor = Color.Black;
        }
        private void FilterDataView()
        {
            DataTable dtF = new DataTable();
            DataView view = new DataView();

            dtF.Columns.Add("Name");
            dtF.Columns.Add("Genre");
            dtF.Columns.Add("ChanelName");
            dtF.Columns.Add("Id");
            foreach (var element in program.tvshowList)
            {
                dtF.Rows.Add(element.Name, element.Genre, element.ChanelName, element.Id);
            }

            view = dtF.DefaultView;
            string Name = "(Name LIKE  '" + SearchBox.Text + "*')";
            view.RowFilter = Name;
            TvshowGridView.DataSource = view;
        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text != "Введіть назву телепередачі")
                FilterDataView();
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBox.Hide();
            TvshowGridView.Hide();
            DateGridView.Show();
        }
        public void Fill()
        {
            dtDate.Columns.Add("Id");
            dtDate.Columns.Add("ChanelName");
            dtDate.Columns.Add("StartTime");
            dtDate.Columns.Add("Duration");
            dtDate.Columns.Add("EndTime");
        }
        private void forNextWeekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Date i in program.dateList)
            {
                int index = program.TVshowIndexByID(i.Id);
                dtDate.Rows.Add(program.tvshowList[index].Name, program.tvshowList[index].ChanelName, i.StartTime, i.Duration, i.EndTime);
            }
            DateGridView.DataSource = dtDate;
            DateGridView.Show();
        }
        private void hjfgdfkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TvshowGridView.Show();
            DateGridView.Hide();
            FavGridView.Hide();
        }
        private void всіТелешоуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBox.Show();
            TvshowGridView.Show();
            DateGridView.Hide();
            FavGridView.Hide();
        }
    }
}