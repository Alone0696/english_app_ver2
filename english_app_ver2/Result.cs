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
            this.results.Text = "Ваш результат " + Convert.ToString(Testing.True);
        }
    }
}
