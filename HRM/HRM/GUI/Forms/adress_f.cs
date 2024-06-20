using HRM.Auth;
using HRM.GUI.Controls;
using HRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM.GUI.Forms
{
    public partial class adress_f : Form
    {
        application_db_context appli = null;
        int iFormX, iFormY, iMouseX, iMouseY;
        public adress_f()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(round_form.CreateRoundRectRgn(0, 0, Width, Height, 18, 18));
            password_textbox.PasswordChar = '*';
        }
        public void update_language(bool is_eng)
        {
            label6.Text = language_pack.get_af_sign_in();
            label4.Text = language_pack.get_af_username();
            label5.Text = language_pack.get_af_password();
            login_btn.Text = language_pack.get_af_log_in();
            signup_btn.Text = language_pack.get_af_register();
            label3.Text = language_pack.get_af_recru();
            label1.Text = language_pack.get_af_emplo();
            label2.Text = language_pack.get_af_analy();
        }
        public void update_color()
        {
            this.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            login_textbox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            password_textbox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            login_textbox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            password_textbox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            pictureBox1.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            pictureBox2.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            pictureBox3.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            minimize_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            exit_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label1.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label2.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label3.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label4.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label5.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label6.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            minimize_btn.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            exit_btn.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label1.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label2.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label3.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label4.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label5.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label6.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            signup_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            pictureBox2.Image = manager_style.is_darck ? Image.FromFile("../../../images/user_dark.png") : Image.FromFile("../../../images/user_light.png");
            pictureBox3.Image = manager_style.is_darck ? Image.FromFile("../../../images/password_dark.png") : Image.FromFile("../../../images/password_light.png");
        }

        private void adress_f_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }

        private void adress_f_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                bool any_admins = entity_gateway.GetInstance().get_admins().Any();
            });
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            show_win.adress_f.Hide();
            show_win.signup_f.Show();
            login_textbox.Text = "";
            password_textbox.Text = "";
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(login_textbox.Text) || string.IsNullOrEmpty(password_textbox.Text))
            {
                MessageBox.Show(language_pack.get_af_clear_data(), language_pack.get_error());
                return;
            }
            if (auth.GetInstance().authoriz(login_textbox.Text, password_textbox.Text))
            {
                show_win.adress_f.Hide();
                show_win.main_f.Show();
            }
            else
                MessageBox.Show(language_pack.get_af_no_worker(), language_pack.get_error());
            login_textbox.Text = "";
            password_textbox.Text = "";
        }

        private void login_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void password_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }
        private void adress_f_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
