using DevExpress.DataProcessing;
using HRM.GUI.Controls;
using HRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM.GUI.Forms
{
    public partial class redact_db_f : Form
    {
        private int iFormX, iFormY, iMouseX, iMouseY;
        private int id_worker = 0;
        private object[] worker_info;
        private List<string> current_month_list;
        private int current_bonus_id = 0;
        private double current_bonus_kpd = 0.0;

        public redact_db_f()
        {
            InitializeComponent();
        }
        public void update_lacalization()
        {
            label4.Text = language_pack.get_rdb_info();
            label1.Text = language_pack.get_rdb_fio();
            label2.Text = language_pack.get_rdb_docymet_info();
            label8.Text = language_pack.get_rdb_educ();
            label7.Text = language_pack.get_rdb_ex();
            label9.Text = language_pack.get_rdb_all_case();
            label10.Text = language_pack.get_rdb_compl_case();
            label11.Text = language_pack.get_rdb_house();
            label5.Text = language_pack.get_rdb_dev_level();
            label3.Text = language_pack.get_rdb_depart();
            label6.Text = language_pack.get_rdb_sel();
            add_btn.Text = language_pack.get_rdb_up_date();
            button1.Text = language_pack.get_rdb_del();
            List<string> tmp = new List<string>();
            for (int i = 0; i < table_combobox.Items.Count; i++)
                tmp.Add(table_combobox.Items[i].ToString());
            table_combobox.Items.Clear();

            for (int i = 0; i < tmp.Count; i++)
            {
                if (tmp[i] == "January" || tmp[i] == "Январь")
                    table_combobox.Items.Add(language_pack.get_pw_January());
                else if (tmp[i] == "February" || tmp[i] == "Февраль")
                    table_combobox.Items.Add(language_pack.get_pw_February());
                else if (tmp[i] == "March" || tmp[i] == "Март")
                    table_combobox.Items.Add(language_pack.get_pw_March());
                else if (tmp[i] == "April" || tmp[i] == "Апрель")
                    table_combobox.Items.Add(language_pack.get_pw_April());
                else if (tmp[i] == "May" || tmp[i] == "Май")
                    table_combobox.Items.Add(language_pack.get_pw_May());
                else if (tmp[i] == "June" || tmp[i] == "Июнь")
                    table_combobox.Items.Add(language_pack.get_pw_June());
                else if (tmp[i] == "July" || tmp[i] == "Июль")
                    table_combobox.Items.Add(language_pack.get_pw_July());
                else if (tmp[i] == "August" || tmp[i] == "Август")
                    table_combobox.Items.Add(language_pack.get_pw_August());
                else if (tmp[i] == "September" || tmp[i] == "Сентябрь")
                    table_combobox.Items.Add(language_pack.get_pw_September());
                else if (tmp[i] == "October" || tmp[i] == "Октябрь")
                    table_combobox.Items.Add(language_pack.get_pw_October());
                else if (tmp[i] == "November" || tmp[i] == "Ноябрь")
                    table_combobox.Items.Add(language_pack.get_pw_November());
                else if (tmp[i] == "December" || tmp[i] == "Декабрь")
                    table_combobox.Items.Add(language_pack.get_pw_December());
            }

        }
        public void update_color()
        {
            this.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            minimize_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            exit_btn.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            minimize_btn.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            exit_btn.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label1.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label2.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label3.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label4.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label5.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label6.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label7.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label8.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label9.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label10.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label11.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            label1.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label2.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label3.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label4.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label5.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label6.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label7.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label8.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label9.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label10.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            label11.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            textBox1.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            textBox2.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            textBox3.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            textBox4.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            textBox5.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            textBox6.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            textBox7.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            textBox8.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            textBox9.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            login_textbox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            textBox1.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            textBox2.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            textBox3.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            textBox4.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            textBox5.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            textBox6.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            textBox7.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            textBox8.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            textBox9.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            login_textbox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            table_combobox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            table_combobox.ListBackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            table_combobox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            table_combobox.ListTextColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
        }

        public void set_id_worker(int value)
        {
            login_textbox.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            table_combobox.Items.Clear();
            id_worker = value;
            worker_info = new object[7];
            List<worker> tmp = new List<worker>();
            List<bonus> bonus_list = new List<bonus>();
            current_month_list = new List<string>();
            bonus_list = entity_gateway.GetInstance().get_bonus();
            tmp = entity_gateway.GetInstance().get_workers();

            for (int i = 0; i < tmp.Count; i++)
            {
                if (tmp[i].Id == id_worker)
                {
                    worker_info[0] = tmp[i].Name;
                    worker_info[1] = tmp[i].Document_info;
                    worker_info[2] = tmp[i].Department;
                    worker_info[3] = tmp[i].Grade;
                    worker_info[4] = tmp[i].Salary;
                    worker_info[5] = tmp[i].Education;
                    worker_info[6] = tmp[i].Experience;
                    break;
                }
            }
            for (int i = 0; i < bonus_list.Count; i++)
            {
                if (bonus_list[i].Worker_Id == id_worker)
                {
                    textBox7.Text = bonus_list[i].Case_Supplied.ToString();
                    textBox8.Text = bonus_list[i].Case_Completed.ToString();
                    textBox9.Text = bonus_list[i].Hour.ToString();
                    current_bonus_id = bonus_list[i].Id;
                    current_bonus_kpd = bonus_list[i].KPD;

                    if (bonus_list[i].Month == "January" || bonus_list[i].Month == "Январь")
                        current_month_list.Add(language_pack.get_pw_January());
                    else if (bonus_list[i].Month == "February" || bonus_list[i].Month == "Февраль")
                        current_month_list.Add(language_pack.get_pw_February());
                    else if (bonus_list[i].Month == "March" || bonus_list[i].Month == "Март")
                        current_month_list.Add(language_pack.get_pw_March());
                    else if (bonus_list[i].Month == "April" || bonus_list[i].Month == "Апрель")
                        current_month_list.Add(language_pack.get_pw_April());
                    else if (bonus_list[i].Month == "May" || bonus_list[i].Month == "Май")
                        current_month_list.Add(language_pack.get_pw_May());
                    else if (bonus_list[i].Month == "June" || bonus_list[i].Month == "Июнь")
                        current_month_list.Add(language_pack.get_pw_June());
                    else if (bonus_list[i].Month == "July" || bonus_list[i].Month == "Июль")
                        current_month_list.Add(language_pack.get_pw_July());
                    else if (bonus_list[i].Month == "August" || bonus_list[i].Month == "Август")
                        current_month_list.Add(language_pack.get_pw_August());
                    else if (bonus_list[i].Month == "September" || bonus_list[i].Month == "Сентябрь")
                        current_month_list.Add(language_pack.get_pw_September());
                    else if (bonus_list[i].Month == "October" || bonus_list[i].Month == "Октябрь")
                        current_month_list.Add(language_pack.get_pw_October());
                    else if (bonus_list[i].Month == "November" || bonus_list[i].Month == "Ноябрь")
                        current_month_list.Add(language_pack.get_pw_November());
                    else if (bonus_list[i].Month == "December" || bonus_list[i].Month == "Декабрь")
                        current_month_list.Add(language_pack.get_pw_December());

                    table_combobox.SelectedItem = bonus_list[i].Month;
                }
            }
            login_textbox.Text = worker_info[0].ToString();
            textBox1.Text = worker_info[1].ToString();
            textBox2.Text = worker_info[2].ToString();
            textBox3.Text = worker_info[3].ToString();
            textBox4.Text = worker_info[4].ToString();
            textBox5.Text = worker_info[5].ToString();
            textBox6.Text = worker_info[6].ToString();
            table_combobox.Items.AddRange(current_month_list.ToArray());
        }

        private void redact_db_f_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<worker> tmp_worker = new List<worker>();
                List<bonus> tmp_bonus = new List<bonus>();
                tmp_worker = entity_gateway.GetInstance().get_workers();
                tmp_bonus = entity_gateway.GetInstance().get_bonus();
                Directory.Delete($"../../../../Работники/Личный кабинет работника {tmp_worker.Single(w => w.Id == id_worker).Name}", true);
                entity_gateway.GetInstance().delety_worker(tmp_worker.Single(w => w.Id == id_worker));
                for (int i = 0; i < tmp_bonus.Count; i++)
                {
                    if (tmp_bonus[i].Worker_Id == id_worker)
                    {
                        bonus tmp = tmp_bonus[i];
                        entity_gateway.GetInstance().delety_bonus(tmp);
                    }
                }
                login_textbox.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                table_combobox.SelectedItem = null;
                table_combobox.Items.Clear();
            }
            catch { }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            worker tmp = new worker();
            tmp.Id = id_worker;
            tmp.Name = login_textbox.Text;
            tmp.Document_info = textBox1.Text;
            tmp.Education = textBox5.Text;
            tmp.Department = textBox2.Text;
            tmp.Experience = Convert.ToDouble(textBox6.Text);
            tmp.Grade = textBox3.Text;
            tmp.Salary = Convert.ToDouble(textBox4.Text);
            entity_gateway.GetInstance().update_worker(tmp);

            bonus bonus = new bonus();
            bonus.Id = current_bonus_id;
            bonus.Worker_Name = login_textbox.Text;
            bonus.Worker_Otdel = textBox2.Text;
            bonus.Worker_Id = id_worker;
            bonus.Hour = Convert.ToInt32(textBox9.Text);
            for (int i = 0; i < table_combobox.Items.Count; i++)
            {
                if (table_combobox.Items[i].ToString() == "January" || table_combobox.Items[i].ToString() == "Январь")
                    bonus.Month = "Январь";
                else if (table_combobox.Items[i].ToString() == "February" || table_combobox.Items[i].ToString() == "Февраль")
                    bonus.Month = "Февраль";
                else if (table_combobox.Items[i].ToString() == "March" || table_combobox.Items[i].ToString() == "Март")
                    bonus.Month = "Март";
                else if (table_combobox.Items[i].ToString() == "April" || table_combobox.Items[i].ToString() == "Апрель")
                    bonus.Month = "Апрель";
                else if (table_combobox.Items[i].ToString() == "May" || table_combobox.Items[i].ToString() == "Май")
                    bonus.Month = "Май";
                else if (table_combobox.Items[i].ToString() == "June" || table_combobox.Items[i].ToString() == "Июнь")
                    bonus.Month = "Июнь";
                else if (table_combobox.Items[i].ToString() == "July" || table_combobox.Items[i].ToString() == "Июль")
                    bonus.Month = "Июль";
                else if (table_combobox.Items[i].ToString() == "August" || table_combobox.Items[i].ToString() == "Август")
                    bonus.Month = "Август";
                else if (table_combobox.Items[i].ToString() == "September" || table_combobox.Items[i].ToString() == "Сентябрь")
                    bonus.Month = "Сентябрь";
                else if (table_combobox.Items[i].ToString() == "October" || table_combobox.Items[i].ToString() == "Октябрь")
                    bonus.Month = "Октябрь";
                else if (table_combobox.Items[i].ToString() == "November" || table_combobox.Items[i].ToString() == "Ноябрь")
                    bonus.Month = "Ноябрь";
                else if (table_combobox.Items[i].ToString() == "December" || table_combobox.Items[i].ToString() == "Декабрь")
                    bonus.Month = "Декабрь";
            }
            bonus.Case_Completed = Convert.ToInt32(textBox8.Text);
            bonus.Case_Supplied = Convert.ToInt32(textBox7.Text);
            bonus.KPD = current_bonus_kpd;
            bonus.Worker_Skill = textBox3.Text;
            entity_gateway.GetInstance().update_bonus(bonus);
        }

        private void table_combobox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            //string curr = table_combobox.SelectedItem.ToString();
            //List<bonus> bonus_list = new List<bonus>();
            //bonus_list = entity_gateway.GetInstance().get_bonus();
            //for (int i = 0; i < bonus_list.Count; i++)
            //{
            //    if (curr == bonus_list[i].Month)
            //    {
            //        textBox7.Text = bonus_list[i].Case_Supplied.ToString();
            //        textBox8.Text = bonus_list[i].Case_Completed.ToString();
            //        textBox9.Text = bonus_list[i].Hour.ToString();
            //        current_bonus_id = bonus_list[i].Id;
            //        current_bonus_kpd = bonus_list[i].KPD;
            //    }
            //}
        }

        private void redact_db_f_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
