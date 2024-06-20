using HRM.GUI.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM
{
    public static class show_win
    {
        public static adress_f adress_f;
        public static signup_f signup_f;
        public static auth_password_f auth_password_f;
        public static settings_f settings_f;
        public static main_f main_f;
        public static redact_db_f redact_db_f;
        public static Process process_analitik;

        public static void init_forms()
        {
            adress_f = new adress_f();
            signup_f = new signup_f();
            auth_password_f = new auth_password_f();
            settings_f = new settings_f();
            redact_db_f = new redact_db_f();
            main_f = new main_f();
        }
    }
}
