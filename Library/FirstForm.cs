﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryForm
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            MainPanel.BackColor = Color.FromArgb(220, Color.White);
            //
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LibraryForm forma = new LibraryForm();
            forma.Show();
        }

        private void CreateCardBtn_Click(object sender, EventArgs e)
        {
            ReaderForm reader_form = new ReaderForm();
            reader_form.Owner = this;
            reader_form.ShowDialog();
        }
    }
}
