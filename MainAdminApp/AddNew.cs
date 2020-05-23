using ConsoleAppTry.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAdminApp
{
    public partial class AddNew : Form
    {
        public TVshow TVshow { set; get; }
        public AddNew()
        {
            InitializeComponent();
        }
        public AddNew(TVshow tvshow) : this()
        {
            TVshow = tvshow;
            NameBox.Text = tvshow.Name;
            GenreBox.Text = tvshow.Genre;
            ChanelBox.Text = tvshow.ChanelName;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameBox.Text) != true && string.IsNullOrWhiteSpace(GenreBox.Text) != true && string.IsNullOrWhiteSpace(ChanelBox.Text) != true)
            {
                if (TVprogram.CheckAdd(NameBox.Text, GenreBox.Text, ChanelBox.Text) == 1)
                {
                    if (TVshow == null)
                    {
                        TVshow = new TVshow(NameBox.Text, GenreBox.Text, ChanelBox.Text);
                    }
                    else
                    {
                        TVshow.Name = NameBox.Text;
                        TVshow.Genre = GenreBox.Text;
                        TVshow.ChanelName = ChanelBox.Text;
                    }
                    Close();
                }
                else if(TVprogram.CheckAdd(NameBox.Text, GenreBox.Text, ChanelBox.Text) == 0)
                {
                    NameBox.Clear();
                    MessageBox.Show("Назва має містити до 50 символів");
                }
                else if (TVprogram.CheckAdd(NameBox.Text, GenreBox.Text, ChanelBox.Text) == -1)
                {
                    MessageBox.Show("Довжина полів не має перевищувати 50 символів");
                }
            }
            else MessageBox.Show("Всі поля мають бути заповнені");
        }
    }
}
