using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace english_app
{
    public partial class Logic
    {
        static Random rand = new();
        public static List<string> my_question = new();
        public static List<string> my_answer = new();
        public static int i = 1;
        public static string a;
        static Dictionary<string, string> slovar = Program.ReadFromBinaryFile<Dictionary<string, string>>("slovar.slvr");
        List<string> keyList = new List<string>(slovar.Keys);

        public static Tuple<string,int> calculation()
        {
            string d = "Ваши ошибки:" + "\r" + "\n";
            var slovar = Program.ReadFromBinaryFile<Dictionary<string, string>>("slovar.slvr");
            int True;
            True = 0;
            for (int i = 0;i<my_question.Count;i++)
            {
                if (my_answer[i].ToLower() == slovar[my_question[i]].ToLower())
                {
                    True++;
                }
                else
                {
                    d+= my_question[i] + " -> " + "ваш ответ ~" + my_answer[i] + "~ ,а правильно:" + slovar[my_question[i]] + "\r" + "\n";
                }
            }
            return new Tuple<string,int>(d,True);
        }
        public void logic_last()
        {
            my_answer.Add(Program.access.textBox1.Text);
            Result result = new();
            result.ShowDialog();
            Program.access.Close();
        }
        
        private void del_one()
        {
            keyList.Remove(a);
        }
        public void logic_first()
        {
            Dictionary<string, string> slovar = Program.ReadFromBinaryFile<Dictionary<string, string>>("slovar.slvr");
            List<string> keyList = new List<string>(slovar.Keys);
            i = 1;
            a = "";
            my_question.Clear();
            my_answer.Clear();
            a = keyList[rand.Next(keyList.Count)];
            my_question.Add(a);
            Program.access.question.Text = a;
            Program.access.counter.Text = Convert.ToString(i);
            keyList.Remove(a);
            del_one();
        }
    
        public void logic_main()
        {
            a = keyList[rand.Next(keyList.Count)];
            my_question.Add(a);
            Program.access.question.Text = a;
            i++;
            my_answer.Add(Program.access.textBox1.Text);
            Program.access.counter.Text = Convert.ToString(i);
            keyList.Remove(a);
            Program.access.textBox1.Text = "";
        }
    }
}
