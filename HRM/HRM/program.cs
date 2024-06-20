using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM
{
    internal static class program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            show_win.init_forms();
            Application.Run(show_win.adress_f);
            if (show_win.process_analitik != null && !show_win.process_analitik.HasExited)
                show_win.process_analitik.Kill();
        }
    }
}
