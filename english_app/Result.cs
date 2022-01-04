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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
            string S;
            int True;
            (S, True) = Logic.calculation();
            this.textBox1.Text = S;
            this.results.Text = "Ваш результат " + Convert.ToString(True) + " из " + Convert.ToString(Program.count.count.Text);
        }
    }
}
