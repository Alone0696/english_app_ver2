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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            this.en.Text = "";
        }

        private void add_in_Click(object sender, EventArgs e)
        {
            var slovar = Program.ReadFromBinaryFile<Dictionary<string, string>>("slovar.slvr");
            string a = this.en.Text;
            string b = this.ru.Text;
            try
            {
                if (a == "")
                {
                    this.status.Text = "Пустой ввод";
                    this.status.Visible = true;
                }
                else
                {
                    slovar.Add(a, b);
                    Program.WriteToBinaryFile<Dictionary<string, string>>("slovar.slvr", slovar);
                    Program.show_sl.slovar.Text = Program.refresh_sl();
                    this.en.Text = "";
                    this.ru.Text = "";
                    this.status.Visible = true;
                }
            }
            catch
            {
                this.status.Text = "Ошибка";
                this.status.Visible = true;
            }
        }
    }
}
