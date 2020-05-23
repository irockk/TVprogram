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
        TVprogram program;
        DataTable dt = new DataTable();
        public MainMenuViewer()
        {
            InitializeComponent();
            program = new TVprogram();
            program.Load();
         //   program.FillTestData(50);
            tVshowBindingSource1.DataSource = program.tvshowList;
         //   FavouriteGridView.Hide();
           

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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
            /*
            foreach (var element in program.userCurr.Favourite)
            {
                dt.Rows.Add(element.Name, element.Genre, element.ChanelName, element.Id);
            }
            FavouriteGridView.DataSource = dt;
            */
        }

        private void MainMenuViewer_Load(object sender, EventArgs e)
        {
            FillData();
            SearchBox.Text = "Введіть назву телепередачі";
            SearchBox.ForeColor = Color.Gray;
        }
        
        private void TvshowGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                //Reference the GridView Row.
                DataGridViewRow row = TvshowGridView.Rows[e.RowIndex];

                //Set the CheckBox selection.
                row.Cells["Favourite"].Value = !Convert.ToBoolean(row.Cells["Favourite"].EditedFormattedValue);

                DataGridViewCell cell = this.TvshowGridView.Rows[e.RowIndex].Cells[4];
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

        //нумерация строк
        private void TvshowGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < TvshowGridView.Rows.Count; i++)
                TvshowGridView.Rows[i].Cells[0].Value = i + 1;
        }
        

        private void favouriteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TvshowGridView.Hide();
            MessageBox.Show(program.userCurr.Favourite[0].ToString());
      //    FavouriteGridView.Show();
        }


        private void SearchBox_Enter(object sender, EventArgs e)
        {
            SearchBox.Text = null;
            SearchBox.ForeColor = Color.Black;
        }

      
    }
}
