using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace english_app
{
    static class Program
    {
        public static Ed_slovar show_sl;
        public static Pre_start count;
        public static int s_count;
        public static Testing access;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Dictionary<string, string> slovar = new();
            string file_path = @"slovar.slvr";
            if (File.Exists(file_path))
            {
                Start();
            }
            else 
            {
                WriteToBinaryFile<Dictionary<string, string>>("slovar.slvr", slovar);
                Start();
            }
        }

        static void Start()
        {
            refresh_sl();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_menu());
        }
        
        public static string refresh_sl()
        {
            string d = "";
            var slovar = Program.ReadFromBinaryFile<Dictionary<string, string>>("slovar.slvr");
            s_count = slovar.Count();
            foreach (var key in slovar)
            {
                d+= key.Key + " -> " + key.Value + '\r' + '\n';
            }
            return d;
        }
        
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }
        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
