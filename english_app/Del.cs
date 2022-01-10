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
            this.tableLayoutPanel1.BackColor = this.tableLayoutPanel2.BackColor = this.tableLayoutPanel3.BackColor = Program.main_color;
            this.ruen.BackColor = Program.box_color;
            this.del_in.BackColor = Program.button_color;
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
