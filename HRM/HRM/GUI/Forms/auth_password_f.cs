using HRM.Auth;
using HRM.GUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM.GUI.Forms
{
    public partial class auth_password_f : Form
    {
        private application_db_context appli = null;
        private int iFormX, iFormY, iMouseX, iMouseY;

        public auth_password_f()
        {
            InitializeComponent();
            password_textbox.PasswordChar = '*';
        }
        public void update_language(bool is_eng)
        {
            label5.Text = language_pack.get_ap_password();
            login_btn.Text = language_pack.get_ap_confirm();
        }
        public void update_color()
        {
            this.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            password_textbox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            password_textbox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            minimize_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            exit_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label5.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            minimize_btn.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            exit_btn.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label5.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            show_win.auth_password_f.Hide();    
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password_textbox.Text))
            {
                MessageBox.Show(language_pack.get_ap_empty_data(), language_pack.get_error());
                return;
            }
            if (auth.GetInstance().auth_password(password_textbox.Text))
            {
                show_win.main_f.profile_worker1.auth(1);
                show_win.auth_password_f.Hide();
            }
            else
            {
                show_win.main_f.profile_worker1.auth(0);
                MessageBox.Show(language_pack.get_ap_no_user(), language_pack.get_error());
            }
            password_textbox.Text = "";
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void auth_password_f_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }

        private void auth_password_f_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }
    }
}
