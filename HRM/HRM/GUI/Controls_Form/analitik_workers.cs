using HRM.GUI.Controls;
using HRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HRM.GUI.Controls_Form
{
    enum For
    {
        Department,
        Skill
    }

    enum By
    {
        Salary,
        All_case,
        Complited_case,
        Skill
    }


    public partial class analitik_workers : UserControl
    {
        private For _for { get; set; }
        private By _by { get; set; }

        private List<worker> workers_list;
        private List<bonus> bonus_list;
        private List<string> month_list = new List<string>() {"Январь", "Февраль", "Март",
                "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};
        
        public analitik_workers()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            radioButton2.Checked = true;
            radioButton6.Enabled = true;
            _for = For.Department;
            _by = By.Salary;
            table_combobox.Enabled = false;
            table_combobox.Items.AddRange(month_list.ToArray());
            table_combobox.SelectedItem = "Январь";
        }

        private void all_works_btn_Click(object sender, EventArgs e)
        {
            if (show_win.process_analitik != null && !show_win.process_analitik.HasExited)
                show_win.process_analitik.Kill();

            workers_list = new List<worker>();
            bonus_list = new List<bonus>();
            workers_list = entity_gateway.GetInstance().get_workers();
            bonus_list = entity_gateway.GetInstance().get_bonus();

            double sum_dep1 = 0;
            double sum_dep2 = 0;
            double sum_dep3 = 0;
            int type_plot = 0;
            string buf = "";

            if (_for == For.Department && _by == By.Salary)
                type_plot = 0;
            else if (_for == For.Department && _by == By.All_case)
                type_plot = 1;
            else if (_for == For.Department && _by == By.Complited_case)
                type_plot = 2;
            else if (_for == For.Skill && _by == By.Salary)
                type_plot = 3;
            else if (_for == For.Skill && _by == By.All_case)
                type_plot = 4;
            else if (_for == For.Skill && _by == By.Complited_case)
                type_plot = 5;
            else if (_for == For.Department && _by == By.Skill)
                type_plot = 6;




            if (type_plot == 0)
            {
                for (int i = 0; i < workers_list.Count; i++)
                {
                    if (workers_list[i].Department == "Сисадминов")
                        sum_dep1 += workers_list[i].Salary;
                    else if (workers_list[i].Department == "Системных программистов")
                        sum_dep2 += workers_list[i].Salary;
                    else if (workers_list[i].Department == "STM программситов")
                        sum_dep3 += workers_list[i].Salary;
                }
                // {type_plot} {колличество отделов} {значение 1}...{значение 3}
                buf = $"{type_plot};{3};{sum_dep1};{sum_dep2};{sum_dep3}";
            }
            else if (type_plot == 1)
            {
                for (int i = 0; i < bonus_list.Count; i++)
                { 
                    if (bonus_list[i].Worker_Otdel == "Сисадминов" && bonus_list[i].Month == table_combobox.SelectedItem.ToString())
                        sum_dep1 += bonus_list[i].Case_Supplied;
                    else if (bonus_list[i].Worker_Otdel == "Системных программистов" && bonus_list[i].Month == table_combobox.SelectedItem.ToString())
                        sum_dep2 += bonus_list[i].Case_Supplied;
                    else if (bonus_list[i].Worker_Otdel == "STM программситов" && bonus_list[i].Month == table_combobox.SelectedItem.ToString())
                        sum_dep3 += bonus_list[i].Case_Supplied;
                }
                // {type_plot} {колличество отделов} {значение 1}...{значение 3} {месяц}
                buf = $"{type_plot};{3};{sum_dep1};{sum_dep2};{sum_dep3};{table_combobox.SelectedItem.ToString()}";
            }
            else if (type_plot == 2)
            {
                for (int i = 0; i < bonus_list.Count; i++)
                {
                    if (bonus_list[i].Worker_Otdel == "Сисадминов" && bonus_list[i].Month == table_combobox.SelectedItem.ToString())
                        sum_dep1 += bonus_list[i].Case_Completed;
                    else if (bonus_list[i].Worker_Otdel == "Системных программистов" && bonus_list[i].Month == table_combobox.SelectedItem.ToString())
                        sum_dep2 += bonus_list[i].Case_Completed;
                    else if (bonus_list[i].Worker_Otdel == "STM программситов" && bonus_list[i].Month == table_combobox.SelectedItem.ToString())
                        sum_dep3 += bonus_list[i].Case_Completed;
                }
                // {type_plot} {колличество отделов} {значение 1}...{значение 3} {месяц}
                buf = $"{type_plot};{3};{sum_dep1};{sum_dep2};{sum_dep3};{table_combobox.SelectedItem.ToString()}";
            }
            else if (type_plot == 3)
            {
                for (int i = 0; i < workers_list.Count; i++)
                {
                    if (workers_list[i].Grade == "Junior")
                        sum_dep1 += workers_list[i].Salary;
                    else if (workers_list[i].Grade == "Middle")
                        sum_dep2 += workers_list[i].Salary;
                    else if (workers_list[i].Grade == "Senior")
                        sum_dep3 += workers_list[i].Salary;
                }
                // {type_plot} {колличество уровней} {значение 1}...{значение 3}
                buf = $"{type_plot};{3};{sum_dep1};{sum_dep2};{sum_dep3}";
            }
            else if (type_plot == 4)
            {
                for (int i = 0; i < bonus_list.Count; i++)
                {
                    if (bonus_list[i].Worker_Skill == "Junior" && bonus_list[i].Month == table_combobox.SelectedItem.ToString())
                        sum_dep1 += bonus_list[i].Case_Supplied;
                    else if (bonus_list[i].Worker_Skill == "Middle" && bonus_list[i].Month == table_combobox.SelectedItem.ToString())
                        sum_dep2 += bonus_list[i].Case_Supplied;
                    else if (bonus_list[i].Worker_Skill == "Senior" && bonus_list[i].Month == table_combobox.SelectedItem.ToString())
                        sum_dep3 += bonus_list[i].Case_Supplied;
                }
                // {type_plot} {колличество уровней} {значение 1}...{значение 3} {месяц}
                buf = $"{type_plot};{3};{sum_dep1};{sum_dep2};{sum_dep3};{table_combobox.SelectedItem.ToString()}";
            }
            else if (type_plot == 5)
            {
                for (int i = 0; i < bonus_list.Count; i++)
                {
                    if (bonus_list[i].Worker_Skill == "Junior" && bonus_list[i].Month == table_combobox.SelectedItem.ToString())
                        sum_dep1 += bonus_list[i].Case_Completed;
                    else if (bonus_list[i].Worker_Skill == "Middle" && bonus_list[i].Month == table_combobox.SelectedItem.ToString())
                        sum_dep2 += bonus_list[i].Case_Completed;
                    else if (bonus_list[i].Worker_Skill == "Senior" && bonus_list[i].Month == table_combobox.SelectedItem.ToString())
                        sum_dep3 += bonus_list[i].Case_Completed;
                }
                // {type_plot} {колличество уровней} {значение 1}...{значение 3} {месяц}
                buf = $"{type_plot};{3};{sum_dep1};{sum_dep2};{sum_dep3};{table_combobox.SelectedItem.ToString()}";
            }
            else if (type_plot == 6)
            {
                int d_1_j = 0;
                int d_1_m = 0;
                int d_1_s = 0;
                int d_2_j = 0;
                int d_2_m = 0;
                int d_2_s = 0;
                int d_3_j = 0;
                int d_3_m = 0;
                int d_3_s = 0;
                for (int i = 0; i < workers_list.Count; i++)
                {
                    if (workers_list[i].Department == "Сисадминов" && workers_list[i].Grade == "Junior")
                        d_1_j++;
                    else if (workers_list[i].Department == "Сисадминов" && workers_list[i].Grade == "Middle")
                        d_1_m++;
                    else if (workers_list[i].Department == "Сисадминов" && workers_list[i].Grade == "Senior")
                        d_1_s++;
                    else if (workers_list[i].Department == "Системных программистов" && workers_list[i].Grade == "Junior")
                        d_2_j++;
                    else if (workers_list[i].Department == "Системных программистов" && workers_list[i].Grade == "Middle")
                        d_2_m++;
                    else if (workers_list[i].Department == "Системных программистов" && workers_list[i].Grade == "Senior")
                        d_2_s++;
                    else if (workers_list[i].Department == "STM программситов" && workers_list[i].Grade == "Junior")
                        d_3_j++;
                    else if (workers_list[i].Department == "STM программситов" && workers_list[i].Grade == "Middle")
                        d_3_m++;
                    else if (workers_list[i].Department == "STM программситов" && workers_list[i].Grade == "Senior")
                        d_3_s++;
                }
                // {type_plot} {колличество уровней} {значение 1}...{значение 3}
                buf = $"{type_plot};{9};{d_1_j};{d_1_m};{d_1_s};{d_2_j};{d_2_m};{d_2_s};{d_3_j};{d_3_m};{d_3_s}";
            }




            show_win.process_analitik = Process.Start(new ProcessStartInfo {
                FileName = Path.GetFullPath("../../../Analitik/bin/Debug/net8.0-windows/Analitik.exe"),
                Arguments = buf
            });
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _for = For.Department;
            radioButton6.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _by = By.Salary;
            table_combobox.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            _by = By.All_case;
            table_combobox.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            _by = By.Complited_case;
            table_combobox.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            _for = For.Skill;
            radioButton6.Enabled = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            _by = By.Skill;
        }
        public void update_language(bool is_eng)
        {
            all_works_btn.Text = is_eng ? "Plot" : "График";
            radioButton1.Text = is_eng ? "Department" : "Отделам";
            radioButton5.Text = is_eng ? "Level of dev." : "Уровню разработки";
            groupBox1.Text = is_eng ? "By" : "По";
            groupBox2.Text = is_eng ? "What" : "Что";
            radioButton6.Text = is_eng ? "Level of dev." : "Уровень разработки";
            radioButton2.Text = is_eng ? "Salary" : "Зарплата";
            radioButton3.Text = is_eng ? "Total tasks" : "Всего задач";
            radioButton4.Text = is_eng ? "Complited tasks" : "Выполненые задачи";
        }
        public void update_color()
        {
            this.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            radioButton1.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            radioButton2.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            radioButton3.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            radioButton4.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            radioButton5.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            radioButton6.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            radioButton1.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            radioButton2.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            radioButton3.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            radioButton4.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            radioButton5.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            radioButton6.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            groupBox1.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            groupBox2.BackColor = manager_style.is_darck ? manager_style.one_darck : manager_style.one_light;
            groupBox1.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            groupBox2.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            table_combobox.BackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            table_combobox.ListBackColor = manager_style.is_darck ? manager_style.two_darck : manager_style.two_light;
            table_combobox.ForeColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
            table_combobox.ListTextColor = manager_style.is_darck ? manager_style.three_darck : manager_style.three_light;
        }
    }
}
