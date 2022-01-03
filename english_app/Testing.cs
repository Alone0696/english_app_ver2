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
        Random rand = new Random();
        public static List<string> slova = new();
        public static List<string> verniy = new();
        public static List<string> oshibki = new();
        int n = Convert.ToInt32(Program.count.count.Text);
        public static int k, True, False = 0;
        int i = 1;
        string a, res_a, res;
        static Dictionary<string,string> slovar = Program.ReadFromBinaryFile<Dictionary<string, string>>("slovar.slvr");
        List<string> keyList = new List<string>(slovar.Keys);
        
        public void del_one()
        {
            keyList.Remove(a);
        }
        public Testing()
        {
            InitializeComponent();
            Dictionary<string, string> slovar = Program.ReadFromBinaryFile<Dictionary<string, string>>("slovar.slvr");
            List<string> keyList = new List<string>(slovar.Keys);
            (k, True, False) = (0, 0, 0);
            slova.Clear();
            verniy.Clear();
            oshibki.Clear();
            a = keyList[rand.Next(keyList.Count)];
            this.question.Text = a;
            this.counter.Text = Convert.ToString(i);
            res_a = a;
            res = slovar[a];
            slovar.Remove(a);
            keyList.Remove(a);
            del_one();
        }

        private void Testing_FormClosed(object sender, FormClosedEventArgs e)
        {
            Result result = new();
            Form frm = Application.OpenForms[1];
            frm.Show();
            result.ShowDialog();
        }

        private void next_Click(object sender, EventArgs e)
        {
            a = keyList[rand.Next(keyList.Count)];
            this.question.Text = a;
            i++;
            string g = this.textBox1.Text;
            this.counter.Text = Convert.ToString(i);
            if (g.ToLower() == res.ToLower())
            {
                True++;
            }
            else
            {
                oshibki.Add(g);
                False++;
                slova.Add(res_a);
                verniy.Add(res);
                k++;
            }
            res = slovar[a];
            res_a = a;
            keyList.Remove(a);
            this.textBox1.Text = "";
            if (i == n)
            {
                this.Close();
            }
        }
    }
}
