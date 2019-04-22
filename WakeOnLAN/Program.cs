using System;
using System.Windows.Forms;

namespace WakeOnLAN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                try
                {
                    WakeOnLan.SendMagicPacket(args[0]);
                    Console.WriteLine("Wake on LAN package has been sent");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wake on LAN failed!");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                    Console.WriteLine("Usage: wakeonlan 01:23:45:67:89:AB");
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var showMacOnGui = args.Length == 2 && String.Equals(args[0], "-gui", StringComparison.CurrentCultureIgnoreCase);
                Application.Run(new MainForm(showMacOnGui ? args[1] : String.Empty));
            }
        }
    }
}
