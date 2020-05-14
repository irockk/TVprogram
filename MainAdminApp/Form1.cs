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
    public partial class Form1 : Form
    {
        TVprogram program;
        public Form1()
        {
            InitializeComponent();
            program = new TVprogram();
            program.FillTestData(60);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            program.Load();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
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
    }
}
