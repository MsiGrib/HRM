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

namespace HRM.GUI.Controls
{
    public partial class derectory_worker : UserControl
    {
        private string path = null;

        public delegate void click_handler(string str);
        public event click_handler on_click = null;

        public derectory_worker()
        {
            InitializeComponent();
            update_color();
        }
        public void update_color()
        {
            this.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label1.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label1.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            pictureBox1.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
        }

        public void set_data(string name, string icon, string full_path)
        {
            path = full_path;
            label1.Text = name;
            if (icon == ".docx" || icon == ".docm" || icon == ".dotx" || icon == ".dotm")
                pictureBox1.Image = Image.FromFile(Path.GetFullPath("../../../images/word_docx.png"));
            else if (icon == ".doc" || icon == ".wbk")
                pictureBox1.Image = Image.FromFile(Path.GetFullPath("../../../images/word_doc.png"));
            else if (icon == ".pdf")
                pictureBox1.Image = Image.FromFile(Path.GetFullPath("../../../images/pdf.png"));
            else if (icon == ".png" || icon == ".jpg" || icon == ".jpeg" || icon == ".bmp")
                pictureBox1.Image = Image.FromFile(Path.GetFullPath("../../../images/worker_icon.png"));
            else if (icon == ".txt")
            { 
                pictureBox1.Image = Image.FromFile(Path.GetFullPath("../../../images/txt.png"));
                label1.Text += language_pack.get_derectory_worker_crypt();
            }
        }
        private void focus_on()
        {
            label1.BackColor = manager_style.is_darck ? Color.FromArgb(85, 89, 91) : Color.FromArgb(235, 232, 232);
            this.BackColor = manager_style.is_darck ? Color.FromArgb(85, 89, 91) : Color.FromArgb(235, 232, 232);
            pictureBox1.BackColor = manager_style.is_darck ? Color.FromArgb(85, 89, 91) : Color.FromArgb(235, 232, 232);
            this.Update();
            label1.Update();
        }
        private void focus_off()
        {
            label1.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            this.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            pictureBox1.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            this.Update();
            label1.Update();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            on_click?.Invoke(path);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            on_click?.Invoke(path);
        }

        private void derectory_worker_Click(object sender, EventArgs e)
        {
            on_click?.Invoke(path);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            focus_on();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            focus_on();
        }

        private void derectory_worker_MouseEnter(object sender, EventArgs e)
        {
            focus_on();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            focus_off();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            focus_off();
        }

        private void derectory_worker_MouseLeave(object sender, EventArgs e)
        {
            focus_off();
        }
    }
}
