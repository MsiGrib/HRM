using HRM.Auth;
using HRM.GUI.Controls;
using HRM.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HRM.GUI.Forms
{
    public partial class signup_f : Form
    {
        int iFormX, iFormY, iMouseX, iMouseY;
        string path;

        public signup_f()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(round_form.CreateRoundRectRgn(0, 0, Width, Height, 18, 18));
            password_textbox.PasswordChar = '*';
            password1_textbox.PasswordChar = '*';
        }
        public void update_language(bool is_eng)
        {
            label6.Text = language_pack.get_sf_registr();
            label4.Text = language_pack.get_sf_username();
            label5.Text = language_pack.get_sf_password();
            label7.Text = language_pack.get_sf_repeat_password();
            label8.Text = language_pack.get_sf_email();
            add_img_btn.Text = language_pack.get_sf_upload_img();
            signup_btn.Text = language_pack.get_sf_regist();
            label3.Text = language_pack.get_sf_recruit();
            label1.Text = language_pack.get_sf_employee();
            label2.Text = language_pack.get_sf_analitic();
        }
        public void update_color()
        {
            this.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            back_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            minimize_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            exit_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            minimize_btn.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            exit_btn.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            add_img_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            pictureBox1.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            pictureBox2.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            pictureBox3.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            pictureBox4.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            pictureBox5.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label1.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label2.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label3.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label4.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label5.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label6.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label7.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label8.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label1.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label2.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label3.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label4.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label5.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label6.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label7.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label8.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            login_textbox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            password_textbox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            password1_textbox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            mail_textbox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            login_textbox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            password_textbox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            password1_textbox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            mail_textbox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            back_btn.Image = manager_style.is_darck ? Image.FromFile("../../../images/back_dark.png") : Image.FromFile("../../../images/back_light.png");
            pictureBox2.Image = manager_style.is_darck ? Image.FromFile("../../../images/user_dark.png") : Image.FromFile("../../../images/user_light.png");
            pictureBox3.Image = manager_style.is_darck ? Image.FromFile("../../../images/password_dark.png") : Image.FromFile("../../../images/password_light.png");
            pictureBox4.Image = manager_style.is_darck ? Image.FromFile("../../../images/password_dark.png") : Image.FromFile("../../../images/password_light.png");
            pictureBox5.Image = manager_style.is_darck ? Image.FromFile("../../../images/email_dark.png") : Image.FromFile("../../../images/email_light.png");
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            show_win.signup_f.Hide();
            show_win.adress_f.Show();
            login_textbox.Text = "";
            password_textbox.Text = "";
            password1_textbox.Text = "";
            mail_textbox.Text = "";
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            bool reg = auth.GetInstance().register(login_textbox.Text, password_textbox.Text, password1_textbox.Text, mail_textbox.Text, path);
            if (!reg)
                return;
            if (!Directory.Exists("../../../../Администраторы"))
                Directory.CreateDirectory(Path.Combine("../../../../", "Администраторы"));
            Directory.CreateDirectory(Path.Combine("../../../../Администраторы/", login_textbox.Text));
            File.Copy(path, Path.Combine("../../../../Администраторы/", $"{login_textbox.Text}/icon_{login_textbox.Text}.png"));
            login_textbox.Text = "";
            password_textbox.Text = "";
            password1_textbox.Text = "";
            mail_textbox.Text = "";
            show_win.signup_f.Hide();
            show_win.adress_f.Show();
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

        private void password1_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void add_img_btn_Click(object sender, EventArgs e)
        {
            if (img_file_dialog.ShowDialog() == DialogResult.OK)
            {
                path = img_file_dialog.FileName;
                auth.GetInstance().set_ready(true);
            }
        }

        private void mail_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }
        private void signup_f_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }
        private void signup_f_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }
    }
}
