using HRM.GUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM.GUI.Forms
{
    public partial class settings_f : Form
    {
        int iFormX, iFormY, iMouseX, iMouseY;


        public settings_f()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void main_update_colors()
        {
            manager_style.is_darck = !rjToggleButton2.Checked;
            show_win.signup_f.update_color();
            show_win.main_f.update_color();
            show_win.auth_password_f.update_color();
            show_win.adress_f.update_color();
            show_win.main_f.profile_worker1.update_color();
            show_win.main_f.all_workers1.update_color();
            show_win.main_f.add_worker1.update_color();
            show_win.main_f.analitik_workers1.update_color();

            show_win.main_f.Invalidate();
            show_win.main_f.add_worker_btn.Invalidate();
            show_win.main_f.select_worker_btn.Invalidate();
            show_win.main_f.personal_area_btn.Invalidate();
            show_win.main_f.analytics_btn.Invalidate();
            show_win.main_f.back_btn.Invalidate();
            show_win.main_f.settings_btn.Invalidate();
            show_win.main_f.analitik_workers1.Invalidate();
            show_win.redact_db_f.update_color();
            show_win.redact_db_f.Invalidate();

            this.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            minimize_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            exit_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label1.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label2.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label3.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            name_admin_label.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            minimize_btn.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            exit_btn.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label1.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label2.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label3.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            name_admin_label.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
        }
        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            language_pack.is_eng = !rjToggleButton1.Checked;
            show_win.main_f.add_worker1.update_language(!rjToggleButton1.Checked);
            show_win.main_f.all_workers1.update_language(!rjToggleButton1.Checked);
            show_win.adress_f.update_language(!rjToggleButton1.Checked);
            show_win.auth_password_f.update_language(!rjToggleButton1.Checked);
            show_win.main_f.update_language(!rjToggleButton1.Checked);
            show_win.signup_f.update_language(!rjToggleButton1.Checked);
            show_win.main_f.Invalidate();
            show_win.main_f.add_worker_btn.Invalidate();
            show_win.main_f.select_worker_btn.Invalidate();
            show_win.main_f.personal_area_btn.Invalidate();
            show_win.main_f.analytics_btn.Invalidate();
            show_win.main_f.back_btn.Invalidate();
            show_win.main_f.settings_btn.Invalidate();
            show_win.main_f.analitik_workers1.update_language(language_pack.is_eng);
            show_win.redact_db_f.update_lacalization();
            show_win.main_f.profile_worker1.update_language(language_pack.is_eng);

            label3.Text = language_pack.get_lp_darck();
            label2.Text = language_pack.get_lp_light();
        }

        private void rjToggleButton2_CheckedChanged(object sender, EventArgs e)
        {
            main_update_colors();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void settings_f_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }

        private void settings_f_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }
    }
}
