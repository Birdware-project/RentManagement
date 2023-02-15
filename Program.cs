using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moneyhome
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string startupPath = Environment.CurrentDirectory;
            string fileName = startupPath + @"\dbconfig.txt";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                // Check if file already exists.     
                if (!File.Exists(fileName))
                {
                    Application.Run(new InitialForm());
                }
                // Open the stream and read it back.    
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        //MessageBox.Show(s);
                    }
                    //MessageBox.Show(s);
                    Application.Run(new Login(s));
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

    }
}
