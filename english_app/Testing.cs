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
    public partial class Testing : Form
    {
        Logic l = new();
        public Testing()
        {
            InitializeComponent();
            Program.access = this;
            l.logic_first();
        }

        private void Testing_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = Application.OpenForms[1];
            frm.Show();
        }

        public void next_Click(object sender, EventArgs e)
        {
            if (Logic.i != Convert.ToInt32(Program.count.count.Text))
            {
                l.logic_main();
            }
            else 
            {
                l.logic_last();
            }
            
        }
    }
}
