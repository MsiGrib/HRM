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
using System.Windows.Input;
using System.Diagnostics;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HRM.GUI.Controls_Form
{
    public partial class profile_worker : UserControl
    {
        private List<search_worker_controller> search_control_list;
        private List<derectory_worker> derectory_list;
        private List<string> month_list;
        private bool is_placeholder = true;
        private bool is_busy = false;
        private int current_index_worker = 0;
        private int is_auth = 0;
        private DateTime time_prev;

        public profile_worker()
        {
            InitializeComponent();
            search_control_list = new List<search_worker_controller>();
            derectory_list = new List<derectory_worker>();
            month_list = new List<string>();
            result_panel.Height = 0;
            panel2.Visible = false;
            result_panel.MaximumSize = new System.Drawing.Size(321, 479);
            textBox1.ForeColor = Color.Gray;
            richTextBox1.Visible = false;
            add_btn.Visible = false;
            button1.Visible = false;
            button1.Enabled = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            time_prev = DateTime.MinValue;

        }
        public void update_language(bool is_eng)
        {
            textBox1.Text = language_pack.get_pw_search_worker();
            add_btn.Text = language_pack.get_pw_decrpt();
            button1.Text = language_pack.get_pw_encrypt();
            button2.Text = language_pack.get_pw_edit();
            hidden();
            if (comboBox1.Items.Count > 0)
            {
                List<string> month_list = new List<string>();
                month_list = comboBox1.Items.Cast<string>().ToList();
                comboBox1.Items.Clear();
                for (int i = 0; i < month_list.Count; i++)
                {
                    if (month_list[i] == "Январь" || month_list[i] == "January")
                        month_list[i] = language_pack.get_pw_January();
                    else if (month_list[i] == "Февраль" || month_list[i] == "February")
                        month_list[i] = language_pack.get_pw_February();
                    else if (month_list[i] == "Март" || month_list[i] == "March")
                        month_list[i] = language_pack.get_pw_March();
                    else if (month_list[i] == "Апрель" || month_list[i] == "April")
                        month_list[i] = language_pack.get_pw_April();
                    else if (month_list[i] == "Май" || month_list[i] == "May")
                        month_list[i] = language_pack.get_pw_May();
                    else if (month_list[i] == "Июнь" || month_list[i] == "June")
                        month_list[i] = language_pack.get_pw_July();
                    else if (month_list[i] == "Июль" || month_list[i] == "July")
                        month_list[i] = language_pack.get_pw_January();
                    else if (month_list[i] == "Август" || month_list[i] == "August")
                        month_list[i] = language_pack.get_pw_August();
                    else if (month_list[i] == "Сентябрь" || month_list[i] == "September")
                        month_list[i] = language_pack.get_pw_September();
                    else if (month_list[i] == "Октябрь" || month_list[i] == "October")
                        month_list[i] = language_pack.get_pw_October();
                    else if (month_list[i] == "Ноябрь" || month_list[i] == "November")
                        month_list[i] = language_pack.get_pw_November();
                    else if (month_list[i] == "December" || month_list[i] == "January")
                        month_list[i] = language_pack.get_pw_December();
                }
                comboBox1.Items.AddRange(month_list.ToArray());
            }
        }
        public void update_color()
        {
            this.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            flowLayoutPanel1.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            richTextBox1.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            textBox1.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            textBox1.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            pictureBox1.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            richTextBox1.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            comboBox1.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            comboBox1.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            panel2.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label1.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label2.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label3.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label4.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label5.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label6.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label7.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label1.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label2.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label3.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label4.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label5.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label6.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label7.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;

            for (int i = 0; i < derectory_list.Count; i++)
                derectory_list[i].update_color();
        }
        public void hidden()
        {
            textBox1.Text = "";
            is_busy = true;
            textBox1.Text = language_pack.get_pw_search_worker();
            is_busy = false;
            textBox1.ForeColor = Color.Silver;
            is_placeholder = true;
        }

        private void update_worker(int id)
        {
            try
            {
                derectory_list.Clear();
                int last_index = 0;
                current_index_worker = 0;
                current_index_worker = id;
                label1.Text = language_pack.get_pw_no_data();
                label2.Text = language_pack.get_pw_no_data();
                label3.Text = language_pack.get_pw_no_data();
                label4.Text = language_pack.get_pw_no_data();
                label5.Text = language_pack.get_pw_no_data();
                label6.Text = language_pack.get_pw_no_data();
                label7.Text = language_pack.get_pw_no_data();
                pictureBox1.Image = null;
                progress_bar1.set_value(0);

                flowLayoutPanel1.Controls.Clear();
                textBox1.Text = "";
                panel2.Visible = true;
                result_panel.Height = 0;
                month_list = new List<string>();
                List<worker> workers = new List<worker>();
                List<bonus> bonus = new List<bonus>();
                workers = entity_gateway.GetInstance().get_workers().ToList();
                bonus = entity_gateway.GetInstance().get_bonus().ToList();
                string img_path = "";
                for (int i = 0; i < workers.Count; i++)
                {
                    if (workers[i].Id == id)
                    {
                        label1.Text = workers[i].Name;
                        label2.Text = $"{language_pack.get_pw_no_levl()}: {workers[i].Grade}";
                        label3.Text = $"{language_pack.get_pw_no_sell()}: {workers[i].Salary}";
                        img_path = workers[i].Img;
                        using (Image img = Image.FromFile(img_path))
                        {
                            pictureBox1.Image = new Bitmap(img); // Создаем новый Bitmap, чтобы освободить исходный Image
                        }
  
                    }
                }
                for (int i = 0; i < bonus.Count; i++)
                {
                    if (bonus[i].Worker_Id == id)
                    {
                        month_list.Add(bonus[i].Month);
                        last_index = i;
                    }
                }

                List<string> direkts = new List<string>();
                direkts.AddRange(Directory.EnumerateFiles(
                        Path.GetFullPath($"../../../../Работники/Личный кабинет работника {label1.Text}")));

                for (int i = 0; i < direkts.Count; i++)
                {
                    derectory_worker tmp = new derectory_worker();
                    derectory_list.Add(tmp);
                    tmp.on_click += show_document;
                    tmp.set_data(Path.GetFileName(direkts[i]), Path.GetExtension(direkts[i]), Path.GetFullPath(direkts[i]));
                    flowLayoutPanel1.Controls.Add(tmp);
                }

                if (month_list.Count > 0)
                {
                    List<string> tmp = new List<string>();
                    comboBox1.Items.Clear();
                    for (int i = 0; i < month_list.Count; i++)
                    {
                        if (month_list[i] == "Январь" || month_list[i] == "January")
                            tmp.Add(language_pack.get_pw_January());
                        else if (month_list[i] == "Февраль" || month_list[i] == "February")
                            tmp.Add(language_pack.get_pw_February());
                        else if (month_list[i] == "Март" || month_list[i] == "March")
                            tmp.Add(language_pack.get_pw_March());
                        else if (month_list[i] == "Апрель" || month_list[i] == "April")
                            tmp.Add(language_pack.get_pw_April());
                        else if (month_list[i] == "Май" || month_list[i] == "May")
                            tmp.Add(language_pack.get_pw_May());
                        else if (month_list[i] == "Июнь" || month_list[i] == "June")
                            tmp.Add(language_pack.get_pw_July());
                        else if (month_list[i] == "Июль" || month_list[i] == "July")
                            tmp.Add(language_pack.get_pw_January());
                        else if (month_list[i] == "Август" || month_list[i] == "August")
                            tmp.Add(language_pack.get_pw_August());
                        else if (month_list[i] == "Сентябрь" || month_list[i] == "September")
                            tmp.Add(language_pack.get_pw_September());
                        else if (month_list[i] == "Октябрь" || month_list[i] == "October")
                            tmp.Add(language_pack.get_pw_October());
                        else if (month_list[i] == "Ноябрь" || month_list[i] == "November")
                            tmp.Add(language_pack.get_pw_November());
                        else if (month_list[i] == "December" || month_list[i] == "January")
                            tmp.Add(language_pack.get_pw_December());
                    }
                    comboBox1.Items.AddRange(tmp.ToArray());
                }
                label4.Text = $"{language_pack.get_pw_no_all_case()}: {bonus[last_index].Case_Supplied}";
                label5.Text = $"{language_pack.get_pw_compl_case()}: {bonus[last_index].Case_Completed}";
                label6.Text = $"{language_pack.get_pw_hours()}: {bonus[last_index].Hour}";
                label7.Text = $"{language_pack.get_pw_kpd()}: {bonus[last_index].KPD * 100.0}%";
                progress_bar1.set_value(Convert.ToInt32(bonus[last_index].KPD * 100.0));
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex) { }
        }

        private void show_document(string path)
        {
            if (Path.GetExtension(Path.GetFileName(path)) == ".txt")
            {
                richTextBox1.Visible = true;
                add_btn.Visible = true;
                button1.Visible = true;
                richTextBox1.Text = File.ReadAllText(path);
            }
            else
                Process.Start(path);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (is_busy)
                return;
            richTextBox1.Visible = false;
            add_btn.Visible = false;
            button1.Visible = false;
            button1.Enabled = false;
            flowLayoutPanel1.Controls.Clear();
            is_placeholder = textBox1.TextLength > 0 ? false : true;
            result_panel.Controls.Clear();
            search_control_list.Clear();
            result_panel.Height = 0;
            panel2.Visible = false;
            if (textBox1.TextLength >= 1)
            {
                List<worker> worker_list = new List<worker>();
                worker_list = entity_gateway.GetInstance().get_workers().ToList();
                for (int i = 0; i < worker_list.Count; i++)
                {
                    if (worker_list[i].Name.ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        search_worker_controller tmp = new search_worker_controller();
                        tmp.on_click += update_worker;
                        tmp.set_data(worker_list[i].Name, worker_list[i].Grade, worker_list[i].Id);
                        search_control_list.Add(tmp);
                        result_panel.Controls.Add(tmp);
                    }
                }
            }
            result_panel.Height = search_control_list.Count * 50;
            if (result_panel.Height > this.Height)
                result_panel.Height = this.Height;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (is_placeholder)
            {
                is_busy = true;
                textBox1.Text = "";
                is_busy = false;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (is_placeholder)
            {
                is_busy = true;
                textBox1.Text = language_pack.get_pw_search_worker();
                is_busy = false;
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = richTextBox1.Text;
            richTextBox1.Text = encryption.Encrypt(str);
            add_btn.Enabled = true;
            button1.Enabled = false;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (time_prev.AddMinutes(1) <= DateTime.Now)
            {
                is_auth = 0;
                show_win.auth_password_f.Show();
                time_prev = DateTime.Now;
            }

            if (is_auth == 1)
            {
                string str = richTextBox1.Text;
                richTextBox1.Text = encryption.Decrypt(str);
                add_btn.Enabled = false;
                button1.Enabled = true;
            }
            else 
            {
                show_win.auth_password_f.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string current_value = comboBox1.SelectedItem.ToString();
            label4.Text = language_pack.get_pw_no_data();
            label5.Text = language_pack.get_pw_no_data();
            label6.Text = language_pack.get_pw_no_data();
            label7.Text = language_pack.get_pw_no_data();
            progress_bar1.set_value(0);
            List<bonus> bonus = new List<bonus>();
            bonus = entity_gateway.GetInstance().get_bonus().ToList();
            for (int i = 0; i < bonus.Count; i++)
            {
                List<string> tmp = new List<string>();
                for (int j = 0; j < bonus.Count; j++)
                {
                    if (bonus[i].Month == "Январь" || bonus[i].Month == "January")
                        tmp.Add(language_pack.get_pw_January());
                    else if (bonus[i].Month == "Февраль" || bonus[i].Month == "February")
                        tmp.Add(language_pack.get_pw_February());
                    else if (bonus[i].Month == "Март" || bonus[i].Month == "March")
                        tmp.Add(language_pack.get_pw_March());
                    else if (bonus[i].Month == "Апрель" || bonus[i].Month == "April")
                        tmp.Add(language_pack.get_pw_April());
                    else if (bonus[i].Month == "Май" || bonus[i].Month == "May")
                        tmp.Add(language_pack.get_pw_May());
                    else if (bonus[i].Month == "Июнь" || bonus[i].Month == "June")
                        tmp.Add(language_pack.get_pw_July());
                    else if (bonus[i].Month == "Июль" || bonus[i].Month == "July")
                        tmp.Add(language_pack.get_pw_January());
                    else if (bonus[i].Month == "Август" || bonus[i].Month == "August")
                        tmp.Add(language_pack.get_pw_August());
                    else if (bonus[i].Month == "Сентябрь" || bonus[i].Month == "September")
                        tmp.Add(language_pack.get_pw_September());
                    else if (bonus[i].Month == "Октябрь" || bonus[i].Month    == "October")
                        tmp.Add(language_pack.get_pw_October());
                    else if (bonus[i].Month == "Ноябрь" || bonus[i].Month == "November")
                        tmp.Add(language_pack.get_pw_November());
                    else if (bonus[i].Month == "December" || bonus[i].Month == "January")
                        tmp.Add(language_pack.get_pw_December());
                }
                if (tmp[i] == current_value && bonus[i].Worker_Id == current_index_worker)
                {
                    label4.Text = $"{language_pack.get_pw_no_all_case()}: {bonus[i].Case_Supplied}";
                    label5.Text = $"{language_pack.get_pw_compl_case()}: {bonus[i].Case_Completed}";
                    label6.Text = $"{language_pack.get_pw_hours()}: {bonus[i].Hour}";
                    label7.Text = $"{language_pack.get_pw_kpd()}: {bonus[i].KPD * 100.0}%";
                    progress_bar1.set_value(Convert.ToInt32(bonus[i].KPD * 100.0));
                }
            }
        }

        public void auth(int statys)
        {
            if (statys == 1)
            {
                is_auth = 1;
                string str = richTextBox1.Text;
                richTextBox1.Text = encryption.Decrypt(str);
                add_btn.Enabled = false;
                button1.Enabled = true;
            }
            else if (statys == 0)
            {
                is_auth = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            show_win.redact_db_f.Show();
            show_win.redact_db_f.set_id_worker(current_index_worker);
        }
    }
}
