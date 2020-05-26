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
                    TVshowGridView.DataSource = null;
                    TVshowGridView.DataSource = program.tvshowList;
                }
            }
            catch(Exception)
            {
              MessageBox.Show("Нічого не виділено. Виделіть весь рядок для видалення!");
            }
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TVshowGridView.Visible == false)
            {
               TVshowGridView.Show();
            }
            var add = new AddNew();
            add.program = program;
            if (add.ShowDialog() == DialogResult.OK)
                {
                    program.AddTVshow(add.TVshow);
                    tVshowBindingSource.ResetBindings(false);
                    program.IsDirty = true;
                    TVshowGridView.DataSource = null;
                    TVshowGridView.DataSource = program.tvshowList;

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
            var res = MessageBox.Show("Зберегти дані перед виходом?", "", MessageBoxButtons.YesNoCancel);
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
            pf.program = program;
            if (pf.ShowDialog() == DialogResult.OK)
            {
                program.dateList.Add(pf.Date);
                FillData();
                program.IsDirty = true;
                DateGridView.Hide();
                DateGridView.Show();
            }
        }
        private void видалитиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                var DelTime = Convert.ToDateTime(DateGridView.SelectedRows[0].Cells[0].Value);
                var DelIdShow = Convert.ToInt32(DateGridView.SelectedRows[0].Cells[3].Value);


                var res = MessageBox.Show($"Видалити {DelTime} ?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    for( int i = program.dateList.Count - 1; i >= 0; i--)
                    {
                        if(program.dateList[i].StartTime == DelTime && program.dateList[i].Id == DelIdShow)
                        {
                            program.dateList.RemoveAt(i);
                        }
                    }
                    DateGridView.Rows.Remove(DateGridView.SelectedRows[0]);
                    program.IsDirty = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Нічого не виділено. Виделіть весь рядок для видалення!");
                if(DateGridView.Visible == false)
                {
                    DateGridView.Show();
                    TVshowGridView.Hide();
                }
            }
        }


        //календар
       
        public void FillData()
        {
            dt.DefaultView.Sort = "";
            dt.Columns.Clear();
            dt.Clear();
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
        }
        private void наСьогодніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtDate.Clear();
            foreach(Date i in program.dateList)
            {
                if(i.StartTime >= DateTime.Today && i.StartTime <= DateTime.Today.AddDays(1))
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
                if (i.StartTime >= DateTime.Today.AddDays(1) && i.StartTime <= DateTime.Today.AddDays(2))
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
                if (i.StartTime >= DateTime.Today && i.StartTime <= DateTime.Today.AddDays(7))
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
        }
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateGridView.Hide();
            TVshowGridView.Hide();
        }

        private void MainMenuAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
