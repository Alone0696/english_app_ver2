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
            this.results.Text = "Ваш результат " + Convert.ToString(Testing.True) + " из " + Convert.ToString(Program.count.count.Text);
            int i;
            if (Testing.False == 0)
            {
                this.textBox1.Text = "Ошибок нет!)";
            }
            else
            {
                for (i = 0; i < Testing.k; i++)
                {
                    this.textBox1.Text += Testing.slova[i] + " -> " + "ваш ответ ~" +Testing.oshibki[i] + "~ ,а правильно:" + Testing.verniy[i] + "\r" + "\n";
                }
            }
        }
    }
}
