using System;
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
    public partial class Ed_slovar : Form
    {
        public Ed_slovar()
        {
            Program.show_sl = this;
            InitializeComponent();
            this.slovar.Text = Program.refresh_sl();
            this.add.Focus();

        }
    
        private void Ed_slovar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = Application.OpenForms[0];
            frm.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Add add = new();
            add.ShowDialog();
        }

        private void del_Click(object sender, EventArgs e)
        {
            Del del = new();
            del.ShowDialog();
        }
    }
}
