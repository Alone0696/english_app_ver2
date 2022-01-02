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
        public static Testing  test;
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
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_menu());
            //Application.Run(new Ed_slovar());
        }
        
        public static string refresh_sl()
        {
            string d = "";
            var slovar = Program.ReadFromBinaryFile<Dictionary<string, string>>("slovar.slvr");
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
