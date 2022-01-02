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
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        private void Start_app_Click(object sender, EventArgs e)
        {
            Pre_start pre_start = new();
            pre_start.Show();
            this.Hide();
            
        }

        private void setings_app_Click(object sender, EventArgs e)
        {
            Ed_slovar ed_slovar = new();
            ed_slovar.Show();
            this.Hide();
        }
    }
}
