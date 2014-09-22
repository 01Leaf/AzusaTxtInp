using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading;

namespace AzusaTxtInp
{
    static class Program
    {
        static int PID = -1;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("RegisterAs(Input)");

            while (PID==-1)
            {
                Console.WriteLine("GetAzusaPid()");
                try
                {
                    PID = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    
                }
            }

            new Thread(new ThreadStart(AzusaLock)).Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void AzusaLock()
        {
            while (true)
            {
                try
                {
                    System.Diagnostics.Process.GetProcessById(PID);
                    System.Threading.Thread.Sleep(1000);
                }
                catch
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
