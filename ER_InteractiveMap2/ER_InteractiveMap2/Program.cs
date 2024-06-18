using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ER_InteractiveMap2
{
    internal static class Program
    {
        public static MainMap_Overworld overworld;
        public static MainMap_Underground underground;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            overworld = new MainMap_Overworld();
            underground = new MainMap_Underground();

            Application.Run(new Login());
            Application.Run(new MainMap_Overworld());


            //Application.Run(new MainMap_Overworld());
        }
    }
}
