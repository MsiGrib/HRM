using HRM.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using HRM.GUI.Controls;
using HRM.GUI;
using HRM.Auth;

namespace HRM.GUI.Forms
{
    public partial class main_f : Form
    {
        application_db_context appli = null;
        int iFormX, iFormY, iMouseX, iMouseY;

        public main_f()
        {
            InitializeComponent();
            Animator.Start();
            Region = System.Drawing.Region.FromHrgn(round_form.CreateRoundRectRgn(0, 0, Width, Height, 18, 18));
        }
        public void update_language(bool is_eng)
        {
            add_worker_btn.Text = language_pack.get_mf_add_worker();
            select_worker_btn.Text = language_pack.get_mf_all_workers();
            personal_area_btn.Text = language_pack.get_mf_pers_acc_worker();
            analytics_btn.Text = language_pack.get_mf_analitic();
            back_btn.Text = language_pack.get_mf_go_out();
            settings_btn.Text = language_pack.get_mf_settings();
        }
        public void update_color()
        {
            this.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            title_bar_panel.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            minimize_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            exit_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            minimize_btn.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            exit_btn.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            img_admin_picture.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            panel3.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            name_admin_label.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            name_admin_label.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            panel1.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            add_worker_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            select_worker_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            personal_area_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            analytics_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            back_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            settings_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            add_worker_btn.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            select_worker_btn.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            personal_area_btn.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            analytics_btn.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            back_btn.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            settings_btn.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            add_worker_btn.Img = manager_style.is_darck ? Image.FromFile("../../../images/document_dark.png") : Image.FromFile("../../../images/document_light.png");
            select_worker_btn.Img = manager_style.is_darck ? Image.FromFile("../../../images/worker_dark.png") : Image.FromFile("../../../images/worker_light.png");
            personal_area_btn.Img = manager_style.is_darck ? Image.FromFile("../../../images/table_dark.png") : Image.FromFile("../../../images/table_light.png");
            analytics_btn.Img = manager_style.is_darck ? Image.FromFile("../../../images/analitic1_dark.png") : Image.FromFile("../../../images/analitic1_light.png");
            settings_btn.Img = manager_style.is_darck ? Image.FromFile("../../../images/settings_dark.png") : Image.FromFile("../../../images/settings_light.png");
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void add_worker_btn_Click(object sender, EventArgs e)
        {
            nav_panel.Height = add_worker_btn.Height;
            nav_panel.Top = add_worker_btn.Top;
            nav_panel.Left = add_worker_btn.Left;

            add_worker1.Visible = true;
            all_workers1.Visible = false;
            profile_worker1.Visible = false;
            analitik_workers1.Visible = false;
            profile_worker1.hidden();
        }

        private void select_worker_btn_Click(object sender, EventArgs e)
        {
            nav_panel.Height = select_worker_btn.Height;
            nav_panel.Top = select_worker_btn.Top;
            nav_panel.Left = select_worker_btn.Left;

            all_workers1.Visible = true;
            add_worker1.Visible = false;
            profile_worker1.Visible = false;
            analitik_workers1.Visible = false;
            profile_worker1.hidden();
        }

        private void personal_area_btn_Click(object sender, EventArgs e)
        {
            nav_panel.Height = personal_area_btn.Height;
            nav_panel.Top = personal_area_btn.Top;
            nav_panel.Left = personal_area_btn.Left;

            profile_worker1.Visible = true;
            add_worker1.Visible = false;
            all_workers1.Visible = false;
            analitik_workers1.Visible = false;
        }

        private void analytics_btn_Click(object sender, EventArgs e)
        {
            nav_panel.Height = analytics_btn.Height;
            nav_panel.Top = analytics_btn.Top;
            nav_panel.Left = analytics_btn.Left;

            analitik_workers1.Visible = true;
            add_worker1.Visible = false;
            all_workers1.Visible = false;
            profile_worker1.Visible = false;
            profile_worker1.hidden();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            show_win.main_f.Hide();
            show_win.adress_f.Show();
            show_win.main_f.Dispose();
            show_win.main_f = new main_f();
            show_win.settings_f.Hide();
            show_win.settings_f.Dispose();
            show_win.settings_f = new settings_f();
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            show_win.settings_f.Show();
        }

        private void main_f_Load(object sender, EventArgs e)
        {
            add_worker1.Visible = true;
            all_workers1.Visible = false;
            profile_worker1.Visible = false;
            analitik_workers1.Visible = false;
            nav_panel.Height = add_worker_btn.Height;
            nav_panel.Top = add_worker_btn.Top;
            nav_panel.Left = add_worker_btn.Left;
            img_admin_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            img_admin_picture.ImageLocation = auth.GetInstance().admin.Img;
            name_admin_label.Text = auth.GetInstance().admin.User_Name;
            add_worker1.Visible = true;
            all_workers1.Visible = false;
            show_win.main_f.add_worker1.update_language(language_pack.is_eng);
            show_win.main_f.all_workers1.update_language(language_pack.is_eng);
            show_win.main_f.profile_worker1.update_language(language_pack.is_eng);
            show_win.adress_f.update_language(language_pack.is_eng);
            show_win.auth_password_f.update_language(language_pack.is_eng);
            show_win.main_f.update_language(language_pack.is_eng);
            show_win.signup_f.update_language(language_pack.is_eng);

            show_win.settings_f.main_update_colors();
        }
        private void title_bar_panel_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }

        private void title_bar_panel_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }
    }
}
