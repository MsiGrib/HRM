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
using System.Windows.Threading;

namespace HRM.GUI.Forms
{
    public partial class add_worker : UserControl
    {
        private string path = null;

        public add_worker()
        {
            InitializeComponent();
        }

        public void update_language(bool is_eng)
        {
            name_admin_label.Text = is_eng ? "Full name" : "ФИО";
            label1.Text = is_eng ? "Passport details" : "Паспортные данные";
            label2.Text = is_eng ? "Department" : "Отдел";
            label3.Text = is_eng ? "Development level" : "Уровень разработки";
            label4.Text = is_eng ? "Salary" : "Зарплата";
            label5.Text = is_eng ? "Experience" : "Опыт работы";
            label6.Text = is_eng ? "Education" : "Образование";
            label7.Text = is_eng ? "Experience in other companies" : "Опыт в других компаниях";
            label8.Text = is_eng ? "Select application date" : "Выберите дату заявления";
            checkBox1.Text = is_eng ? "Use date" : "Использовать дату";
            add_img_btn.Text = is_eng ? "Upload a photo" : "Загрузить фото";
            add_btn.Text = is_eng ? "Add an employee" : "Добавить работника";
        }

        public void update_color()
        {
            this.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            name_admin_label.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label1.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label2.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label3.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label4.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label5.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label6.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label7.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label8.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            name_admin_label.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label1.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label2.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label3.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label4.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label5.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label6.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label7.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label8.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            dateTimePicker1.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            fio_textbox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            doc_textBox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            otdel_comboBox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            skill_comboBox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            sel_textBox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            obr_textBox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            expir_textBox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            richTextBox1.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            dateTimePicker1.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            fio_textbox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            doc_textBox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            otdel_comboBox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            skill_comboBox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            sel_textBox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            obr_textBox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            expir_textBox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            richTextBox1.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            checkBox1.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            checkBox1.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            add_img_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                MessageBox.Show(language_pack.get_add_worker_select_img(), language_pack.get_error());
                return;
            }
            if (!Directory.Exists("../../../../Работники"))
                Directory.CreateDirectory(Path.Combine("../../../../", "Работники"));
            worker wk = auth.GetInstance().add_worker(fio_textbox.Text, doc_textBox.Text,
                    otdel_comboBox.Text, skill_comboBox.Text, sel_textBox.Text,
                    expir_textBox.Text, obr_textBox.Text, path);
            if (wk == null)
                return;
            string ex_text = richTextBox1.Text;

            Task.Run(() => 
            {
                this.Invoke(new MethodInvoker(delegate 
                { 
                    add_btn.Enabled = false;
                }));
                create_file.worker_info(Path.GetFullPath(Path.Combine("../../../../", "Работники")), ex_text, wk, path, dateTimePicker1.Value, checkBox1.Checked);
                this.Invoke(new MethodInvoker(delegate
                {
                    add_btn.Enabled = true;
                }));
            });

            fio_textbox.Text = "";
            doc_textBox.Text = "";
            sel_textBox.Text = "";
            expir_textBox.Text = "";
            obr_textBox.Text = "";
            richTextBox1.Text = "";
            skill_comboBox.SelectedItem = null;
            otdel_comboBox.SelectedItem = null;
        }

        private void add_img_btn_Click(object sender, EventArgs e)
        {
            path = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                auth.GetInstance().set_ready(true);
            }
        }

        private void add_worker_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(2001, 1, 1);
        }
    }
}
