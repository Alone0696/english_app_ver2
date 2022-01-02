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
    public partial class Del : Form
    {
        public Del()
        {
            InitializeComponent();
        }

        private void del_in_Click(object sender, EventArgs e)
        {
            var slovar = Program.ReadFromBinaryFile<Dictionary<string, string>>("slovar.slvr");
            string a = this.ruen.Text;
            if (slovar.Remove(a) == false)
            {
                this.status.Text = "Ошибка";
                this.status.Visible = true;
            }
            else
            {
                slovar.Remove(a);
                Program.WriteToBinaryFile<Dictionary<string, string>>("slovar.slvr", slovar);
                Program.show_sl.slovar.Text = Program.refresh_sl();
                this.ruen.Text = "";
                this.status.Text = "Успешно";
                this.status.Visible = true;
            }
        }
    }
}
