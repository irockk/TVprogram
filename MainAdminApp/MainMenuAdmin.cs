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
        DataTable dt = new DataTable();
        DataTable dtDate = new DataTable();
        public MainMenuAdmin()
        {
            InitializeComponent();
            program = new TVprogram();
            Fill();
            program.Load();
            tVshowBindingSource.ResetBindings(false);
            TVshowGridView.DataSource = program.tvshowList;
            FillData();
            DateGridView.Hide();
        }
        
        //додавання, редагування, видалення TVshow
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var toDel = TVshowGridView.SelectedRows[0].DataBoundItem as TVshow;
                var res = MessageBox.Show($"Видалити {toDel.Name} ?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    program.tvshowList.Remove(toDel);
                    for(int u = program.userList.Count - 1; u >= 0; u--)
                    {
                        for(int i = program.userList[u].Favourite.Count - 1; i >=0; i--)
                        {
                            if (toDel == program.userList[u].Favourite[i])
                            {
                                program.userList[u].Favourite.Remove(program.userList[u].Favourite[i]);
                            }
                        }
                    }
                    for(int i = program.dateList.Count - 1; i >= 0; i--)
                    {
                        if (program.dateList[i].Id == toDel.Id) program.dateList.Remove(program.dateList[i]);
                    }

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
            try
            {
                if (TVshowGridView.Visible == false)
                {
                    TVshowGridView.Show();
                }
                var add = new AddNew();
                if (add.ShowDialog() == DialogResult.Cancel)
                {
                    program.AddTVshow(add.TVshow);
                    tVshowBindingSource.ResetBindings(false);
                    program.IsDirty = true;

                    var lastIdx = TVshowGridView.Rows.Count - 1;
                    TVshowGridView.Rows[lastIdx].Selected = true;
                    TVshowGridView.FirstDisplayedScrollingRowIndex = lastIdx;
                }
            }
            catch {}
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
                if (TVshowGridView.Visible == false)
                {
                    TVshowGridView.Show();
                }
                else
                MessageBox.Show("Нічого не виділено. Виделіть весь рядок для редагування!");
            }
        }


        //Выход и сохранение
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            program.Save();
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


        //робота с датами
        public void Fill()
        {
            dtDate.Columns.Add("StartTime");
            dtDate.Columns.Add("Duration");
            dtDate.Columns.Add("EndTime");
            dtDate.Columns.Add("Id");
        }
        private void додатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pf = new AddDate();
            pf.program = this.program;
            if (pf.ShowDialog() == DialogResult.OK)
            {
                dateBindingSource.ResetBindings(false);
                program.IsDirty = true;
                DateGridView.Hide();
                DateGridView.Show();

                var lastIdx = DateGridView.Rows.Count - 1;
                DateGridView.Rows[lastIdx].Selected = true;
                DateGridView.FirstDisplayedScrollingRowIndex = lastIdx;
            }
        }
        private void видалитиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                var DelDate = DateGridView.SelectedRows[0].DataBoundItem as Date;
                var res = MessageBox.Show($"Видалити {DelDate.StartTime} ?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    program.dateList.Remove(DelDate);
                   

                    tVshowBindingSource.ResetBindings(false);
                    program.IsDirty = true;
                    TVshowGridView.Hide();
                    TVshowGridView.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Нічого не виділено. Виделіть весь рядок для видалення!");
            }
        }


        //календар
        public void FillData()
        {
            
            dt.Columns.Add("StartTime", typeof(DateTime));
            dt.Columns.Add("Duration", typeof(double));
            dt.Columns.Add("EndTime", typeof(DateTime));
            dt.Columns.Add("Id", typeof(int));
            foreach (var element in program.dateList)
            {
                dt.Rows.Add(element.StartTime, element.Duration, element.EndTime, element.Id);
            }
            DateGridView.DataSource = dt;
            dt.DefaultView.Sort = "StartTime";
        }
        private void TVprogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TVshowGridView.Hide();
            SearchBox.Hide();
            Searchbutton.Hide();
        }
        private void наСьогодніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtDate.Clear();
            foreach(Date i in program.dateList)
            {
                if(i.StartTime >= DateTime.Today && i.EndTime <= DateTime.Today.AddDays(1))
                {
                    dtDate.Rows.Add(i.StartTime, i.Duration, i.EndTime, i.Id);
                }
            }
            DateGridView.DataSource = dtDate;
            DateGridView.Show();
        }
        private void наЗавтраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtDate.Clear();
            foreach (Date i in program.dateList)
            {
                if (i.StartTime >= DateTime.Today.AddDays(1) && i.EndTime <= DateTime.Today.AddDays(2))
                {
                    dtDate.Rows.Add(i.StartTime, i.Duration, i.EndTime, i.Id);
                }
            }
            DateGridView.DataSource = dtDate;
            DateGridView.Show();
        }
        private void всіДатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtDate.Clear();
            foreach (Date i in program.dateList)
            {
                dtDate.Rows.Add(i.StartTime, i.Duration, i.EndTime, i.Id);
            }
            DateGridView.DataSource = dtDate;
            DateGridView.Show();
        }
        private void наЦейТижденьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtDate.Clear();
            foreach (Date i in program.dateList)
            {
                if (i.StartTime >= DateTime.Today && i.EndTime <= DateTime.Today.AddDays(7))
                {
                    dtDate.Rows.Add(i.StartTime, i.Duration, i.EndTime, i.Id);
                }
            }
            DateGridView.DataSource = dtDate;
            DateGridView.Show();
        }
        private void TVshowToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DateGridView.Hide();
            TVshowGridView.Show();
            SearchBox.Show();
            Searchbutton.Show();
        }
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateGridView.Hide();
            TVshowGridView.Hide();
            Searchbutton.Hide();
            SearchBox.Hide();
        }


        //пошук
        private void Searchbutton_Click(object sender, EventArgs e)
        {
                for (int i = 0; i < TVshowGridView.RowCount; i++)
                {
                TVshowGridView.Rows[i].Selected = false;
                    for (int j = 0; j < TVshowGridView.ColumnCount; j++)
                        if (TVshowGridView.Rows[i].Cells[j].Value != null)
                            if (TVshowGridView.Rows[i].Cells[j].Value.ToString().Contains(SearchBox.Text))
                            {
                            TVshowGridView.Rows[i].Selected = true;
                                break;
                            }
                }
        }
    }
}
