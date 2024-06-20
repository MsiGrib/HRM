using HRM.GUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM.GUI.Controls_Form
{
    public partial class all_workers : UserControl
    {
        private bool is_ascending = false;
        private bool is_descending = false;
        string[] worker_fields = new string[] { "ФИО", "Уровень", "Отдел", "Зарплата", "Опыт работы" };
        string[] analitik_fields = new string[] { "Все задачи", "Выполненые задачи", "Часы работы", "Производительность" };
        string[] month_fields = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль",
                                               "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        string[] table_fields = new string[] { "Админы", "Работники", "Анализ данных" };

        public all_workers()
        {
            InitializeComponent();
            table_combobox.Items.AddRange(table_fields);
            table_combobox.SelectedIndex = 1;
            parameter_combobox.Items.AddRange(worker_fields);
            parameter_combobox.SelectedIndex = 0;
            month_combobox.Items.Clear();
            month_combobox.Enabled = false;
            table_combobox.ClientSize = new System.Drawing.Size(205, 40);
            parameter_combobox.ClientSize = new System.Drawing.Size(205, 40);
            month_combobox.ClientSize = new System.Drawing.Size(205, 40);
        }
        public void update_language(bool is_eng)
        {
            worker_fields = is_eng ? new string[] { "Name", "Level", "Department", "Salary", "Work Experience" } : new string[] { "ФИО", "Уровень", "Отдел", "Зарплата", "Опыт работы" };
            analitik_fields = is_eng ? new string[] { "All tasks", "Completed tasks", "Working hours", "Efficiency" } : new string[] { "Все задачи", "Выполненые задачи", "Часы работы", "Производительность" };
            month_fields = is_eng ? new string[] {"January", "February", "March", "April", "May", "June", "July",
                                                  "August", "September", "October", "November", "December"} : new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль",
                                                                      "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            table_fields = is_eng ? new string[] { "Admins", "Employees", "Data Analysis" } : new string[] { "Админы", "Работники", "Анализ данных" };
            rj_button2.Text = is_eng ? "Ascending" : "По возрастанию";
            rj_button1.Text = is_eng ? "Descending" : "По убыванию";
            int idx = table_combobox.SelectedIndex;
            table_combobox.Items.Clear();
            table_combobox.Items.AddRange(table_fields);
            table_combobox.SelectedIndex = idx;
            if (table_combobox.SelectedIndex == 0)
            {
                if (dataGridView1.Rows.Count > 0)
                    visien_table_admins();
            }
            else if (table_combobox.SelectedIndex == 1)
            {
                parameter_combobox.Items.Clear();
                parameter_combobox.Items.AddRange(worker_fields);
                parameter_combobox.SelectedIndex = 0;
                if (dataGridView1.Rows.Count > 0)
                    visien_table_workers();
            }
            else if (table_combobox.SelectedIndex == 2)
            {
                parameter_combobox.Items.Clear();
                parameter_combobox.Items.AddRange(analitik_fields);
                parameter_combobox.SelectedIndex = 0;
                month_combobox.Items.AddRange(month_fields);
                month_combobox.SelectedIndex = 0;
                if (dataGridView1.Rows.Count > 0)
                    vievs_table_bonus();
            }
        }
        public void update_color()
        {
            this.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            panel1.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            all_works_btn.Image = manager_style.is_darck ? Image.FromFile("../../../images/people_dark.png") : Image.FromFile("../../../images/people_light.png");
            rj_button1.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            rj_button2.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            rj_button1.Background_color = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            rj_button2.Background_color = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            rj_button1.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            rj_button2.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            table_combobox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            parameter_combobox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            month_combobox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            table_combobox.ListBackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            parameter_combobox.ListBackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            month_combobox.ListBackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            table_combobox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            parameter_combobox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            month_combobox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            table_combobox.ListTextColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            parameter_combobox.ListTextColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            month_combobox.ListTextColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
        }

        private void visien_table_admins()
        {
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[0].HeaderCell.Value = "Id";
            dataGridView1.Columns[1].HeaderCell.Value = language_pack.get_aw_name_user();
            dataGridView1.Columns[2].HeaderCell.Value = language_pack.get_aw_password();
            dataGridView1.Columns[3].HeaderCell.Value = language_pack.get_aw_email();
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Width = 130;
            for (int i = 0; i <= 3; i++)
                dataGridView1.Columns[i].Resizable = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 8.2F, FontStyle.Bold);
        }

        private void visien_table_workers()
        {
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[0].HeaderCell.Value = "Id";
            dataGridView1.Columns[1].HeaderCell.Value = language_pack.get_aw_worker_name();
            dataGridView1.Columns[2].HeaderCell.Value = language_pack.get_aw_docyment_info();
            dataGridView1.Columns[3].HeaderCell.Value = language_pack.get_aw_deport();
            dataGridView1.Columns[4].HeaderCell.Value = language_pack.get_aw_levle();
            dataGridView1.Columns[5].HeaderCell.Value = language_pack.get_aw_sellary();
            dataGridView1.Columns[6].HeaderCell.Value = language_pack.get_aw_exp();
            dataGridView1.Columns[7].HeaderCell.Value = language_pack.get_aw_edu();
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = language_pack.is_eng ? 150 : 150;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[6].Width = 70;
            dataGridView1.Columns[7].Width = 100;
            for (int i = 0; i <= 7; i++)
                dataGridView1.Columns[i].Resizable = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 8.2F, FontStyle.Bold);
        }

        private void vievs_table_bonus()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "Id";
            dataGridView1.Columns[1].HeaderCell.Value = language_pack.get_aw_id_work();
            dataGridView1.Columns[2].HeaderCell.Value = language_pack.get_aw_worker_name();
            dataGridView1.Columns[3].HeaderCell.Value = language_pack.get_aw_deport();
            dataGridView1.Columns[4].HeaderCell.Value = language_pack.get_aw_levle();
            dataGridView1.Columns[5].HeaderCell.Value = language_pack.get_aw_all_case();
            dataGridView1.Columns[6].HeaderCell.Value = language_pack.get_aw_compl_case();
            dataGridView1.Columns[7].HeaderCell.Value = language_pack.get_aw_hou();
            dataGridView1.Columns[8].HeaderCell.Value = language_pack.get_aw_kpd();
            dataGridView1.Columns[9].HeaderCell.Value = language_pack.get_aw_mont();
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].Width = language_pack.is_eng ? 150 : 150;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 40;
            dataGridView1.Columns[8].Width = language_pack.is_eng ? 150 : 150;
            dataGridView1.Columns[9].Width = 60;
            for (int i = 0; i <= 9; i++)
                dataGridView1.Columns[i].Resizable = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 8.2F, FontStyle.Bold);
        }

        private void fields()
        {
            parameter_combobox.Items.Clear();
            month_combobox.Items.Clear();
            if (table_combobox.SelectedIndex == 0)
            {
                
            }
            else if (table_combobox.SelectedIndex == 1)
            {
                parameter_combobox.Items.AddRange(worker_fields);
                parameter_combobox.SelectedIndex = 0;
            }
            else if (table_combobox.SelectedIndex == 2)
            {
                parameter_combobox.Items.AddRange(analitik_fields);
                parameter_combobox.SelectedIndex = 0;
                month_combobox.Items.AddRange(month_fields);
                month_combobox.SelectedIndex = 0;
            }
        }
        private void parameter_combobox_enable(bool enabled)
        {
            parameter_combobox.Enabled = enabled;
            parameter_combobox.BorderColor = enabled ? Color.FromArgb(52, 189, 180) : Color.FromArgb(237, 237, 237);
            parameter_combobox.IconColor = enabled ? Color.FromArgb(52, 189, 180) : Color.FromArgb(237, 237, 237);
            rj_button1.Enabled = enabled;
            rj_button2.Enabled = enabled;
            if (!enabled)
            {
                rj_button1.Background_color = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
                rj_button2.Background_color = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            }
            parameter_combobox.Texts = "";
        }

        private void month_combobox_enable(bool enabled)
        {
            month_combobox.Enabled = enabled;
            month_combobox.BorderColor = enabled ? Color.FromArgb(52, 189, 180) : Color.FromArgb(237, 237, 237);
            month_combobox.IconColor = enabled ? Color.FromArgb(52, 189, 180) : Color.FromArgb(237, 237, 237);
            month_combobox.Texts = "";
        }

        private void rj_button2_Click(object sender, EventArgs e)
        {
            is_ascending = true;
            is_descending = false;
            rj_button2.Background_color = Color.FromArgb(52, 189, 180);
            rj_button1.Background_color = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;

        }

        private void rj_button1_Click(object sender, EventArgs e)
        {
            is_ascending = false;
            is_descending = true;
            rj_button2.Background_color = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            rj_button1.Background_color = Color.FromArgb(52, 189, 180);
        }

        private void all_works_btn_Click(object sender, EventArgs e)
        {
            if (table_combobox.SelectedIndex == 0)
            {
                dataGridView1.DataSource = entity_gateway.GetInstance().get_admins();
                visien_table_admins();
            }
            else if (table_combobox.SelectedIndex == 1)
            {
                if (!is_ascending && !is_descending)
                {
                    dataGridView1.DataSource = entity_gateway.GetInstance().get_workers();
                }
                else if (is_ascending && !is_descending)
                {// по возрастанию
                    if (parameter_combobox.SelectedItem.ToString() == language_pack.get_aw_fio())
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_workers().OrderBy(w => w.Name).ToList();
                    else if (parameter_combobox.SelectedItem.ToString() == language_pack.get_aw_levl())
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_workers().OrderBy(w => w.Grade).ToList();
                    else if (parameter_combobox.SelectedItem.ToString() == language_pack.get_aw_depor())
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_workers().OrderBy(w => w.Department).ToList();
                    else if (parameter_combobox.SelectedItem.ToString() == language_pack.get_aw_sell())
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_workers().OrderBy(w => w.Salary).ToList();
                    else if (parameter_combobox.SelectedItem.ToString() == language_pack.get_aw_ex())
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_workers().OrderBy(w => w.Experience).ToList();
                    else
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_workers();
                }
                else if (!is_ascending && is_descending)
                {// по убыванию
                    if (parameter_combobox.SelectedItem.ToString() == language_pack.get_aw_fio())
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_workers().OrderBy(w => w.Name).Reverse().ToList();
                    else if (parameter_combobox.SelectedItem.ToString() == language_pack.get_aw_levl())
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_workers().OrderBy(w => w.Grade).Reverse().ToList();
                    else if (parameter_combobox.SelectedItem.ToString() == language_pack.get_aw_depor())
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_workers().OrderBy(w => w.Department).Reverse().ToList();
                    else if (parameter_combobox.SelectedItem.ToString() == language_pack.get_aw_sell())
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_workers().OrderBy(w => w.Salary).Reverse().ToList();
                    else if (parameter_combobox.SelectedItem.ToString() == language_pack.get_aw_ex())
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_workers().OrderBy(w => w.Experience).Reverse().ToList();
                    else
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_workers();
                }
                visien_table_workers();
            }
            else if (table_combobox.SelectedIndex == 2)
            {
                if (!is_ascending && !is_descending)
                {
                    dataGridView1.DataSource = entity_gateway.GetInstance().get_bonus();
                }
                else if (is_ascending && !is_descending)
                {// по возрастанию
                    if (parameter_combobox.SelectedItem.ToString() == language_pack.get_aw_all_case())
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_bonus().Where(w => w.Month == month_combobox.SelectedItem.ToString()).OrderBy(w => w.Hour).ToList();
                    else if (parameter_combobox.SelectedItem.ToString() == language_pack.get_aw_compl_case())
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_bonus().Where(w => w.Month == month_combobox.SelectedItem.ToString()).OrderBy(w => w.Case_Completed).ToList();
                    else if (parameter_combobox.SelectedItem.ToString() == language_pack.get_aw_did_hous())
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_bonus().Where(w => w.Month == month_combobox.SelectedItem.ToString()).OrderBy(w => w.Hour).ToList();
                    else if (parameter_combobox.SelectedItem.ToString() == language_pack.get_aw_kpd())
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_bonus().Where(w => w.Month == month_combobox.SelectedItem.ToString()).OrderBy(w => w.KPD).ToList();
                }
                else if (!is_ascending && is_descending)
                {// по убыванию
                    if (parameter_combobox.SelectedItem.ToString() == language_pack.get_aw_all_case())
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_bonus().Where(w => w.Month == month_combobox.SelectedItem.ToString()).OrderBy(w => w.Hour).Reverse().ToList();
                    else if (parameter_combobox.SelectedItem.ToString() == language_pack.get_aw_compl_case())
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_bonus().Where(w => w.Month == month_combobox.SelectedItem.ToString()).OrderBy(w => w.Case_Completed).Reverse().ToList();
                    else if (parameter_combobox.SelectedItem.ToString() == language_pack.get_aw_did_hous())
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_bonus().Where(w => w.Month == month_combobox.SelectedItem.ToString()).OrderBy(w => w.Hour).Reverse().ToList();
                    else if (parameter_combobox.SelectedItem.ToString() == language_pack.get_aw_kpd())
                        dataGridView1.DataSource = entity_gateway.GetInstance().get_bonus().Where(w => w.Month == month_combobox.SelectedItem.ToString()).OrderBy(w => w.KPD).Reverse().ToList();
                }
                vievs_table_bonus();
            }
        }

        private void table_combobox_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {
            bool parametr_enabled = table_combobox.SelectedIndex == 1 || table_combobox.SelectedIndex == 2;
            bool month = table_combobox.SelectedIndex == 2;
            parameter_combobox_enable(parametr_enabled);
            month_combobox_enable(month);
            fields();
        }
    }
}
