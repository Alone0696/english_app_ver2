﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace english_app
{
    public partial class Pre_start : Form
    {
        public Pre_start()
        {
            InitializeComponent();
            Program.count = this;
        }

        private void Pre_start_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = Application.OpenForms[0];
            frm.Show();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Testing t = new();
            t.Show();
            this.Hide();
        }
    }
}
