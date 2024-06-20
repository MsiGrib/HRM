using System.Configuration;
using System.Data;
using System.Windows;

namespace Analitik
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if (e.Args.Any() && !string.IsNullOrEmpty(e.Args[0]))
            {
                string[] str_arr = e.Args[0].Split(';');
                Arguments.type_plot = Convert.ToInt32(str_arr[0]);
                if (Arguments.type_plot == 0)
                {
                    Arguments.name = "Зарплата в месяц по отделам";
                    Arguments.count_graph = Convert.ToInt32(str_arr[1]);
                    Arguments.sum_dep1 = Convert.ToInt32(str_arr[2]);
                    Arguments.sum_dep2 = Convert.ToInt32(str_arr[3]);
                    Arguments.sum_dep3 = Convert.ToInt32(str_arr[4]);
                }
                else if (Arguments.type_plot == 1)
                {
                    Arguments.name = $"Все задачи по отделам за месяц: {str_arr[5]}";
                    Arguments.count_graph = Convert.ToInt32(str_arr[1]);
                    Arguments.sum_dep1 = Convert.ToInt32(str_arr[2]);
                    Arguments.sum_dep2 = Convert.ToInt32(str_arr[3]);
                    Arguments.sum_dep3 = Convert.ToInt32(str_arr[4]);
                    Arguments.month = str_arr[5];
                }
                else if (Arguments.type_plot == 2)
                {
                    Arguments.name = $"Выполненый задачи по отделам за месяц: {str_arr[5]}";
                    Arguments.count_graph = Convert.ToInt32(str_arr[1]);
                    Arguments.sum_dep1 = Convert.ToInt32(str_arr[2]);
                    Arguments.sum_dep2 = Convert.ToInt32(str_arr[3]);
                    Arguments.sum_dep3 = Convert.ToInt32(str_arr[4]);
                    Arguments.month = str_arr[5];
                }
                else if (Arguments.type_plot == 3)
                {
                    Arguments.name = $"Зарплата в месяц по уровням разработки";
                    Arguments.count_graph = Convert.ToInt32(str_arr[1]);
                    Arguments.sum_dep1 = Convert.ToInt32(str_arr[2]);
                    Arguments.sum_dep2 = Convert.ToInt32(str_arr[3]);
                    Arguments.sum_dep3 = Convert.ToInt32(str_arr[4]);
                }
                else if (Arguments.type_plot == 4)
                {
                    Arguments.name = $"Все задачи по уровням разработки за месяц: {str_arr[5]}";
                    Arguments.count_graph = Convert.ToInt32(str_arr[1]);
                    Arguments.sum_dep1 = Convert.ToInt32(str_arr[2]);
                    Arguments.sum_dep2 = Convert.ToInt32(str_arr[3]);
                    Arguments.sum_dep3 = Convert.ToInt32(str_arr[4]);
                    Arguments.month = str_arr[5];
                }
                else if (Arguments.type_plot == 5)
                {
                    Arguments.name = $"Выполненый задачи по уровням разработки за месяц: {str_arr[5]}";
                    Arguments.count_graph = Convert.ToInt32(str_arr[1]);
                    Arguments.sum_dep1 = Convert.ToInt32(str_arr[2]);
                    Arguments.sum_dep2 = Convert.ToInt32(str_arr[3]);
                    Arguments.sum_dep3 = Convert.ToInt32(str_arr[4]);
                    Arguments.month = str_arr[5];
                }
                else if (Arguments.type_plot == 6)
                {
                    Arguments.name = $"Колличество разных уровней программистов по отделам";
                    Arguments.count_graph = Convert.ToInt32(str_arr[1]);
                    Arguments.d_1_j = Convert.ToInt32(str_arr[2]);
                    Arguments.d_1_m = Convert.ToInt32(str_arr[3]);
                    Arguments.d_1_s = Convert.ToInt32(str_arr[4]);
                    Arguments.d_2_j = Convert.ToInt32(str_arr[5]);
                    Arguments.d_2_m = Convert.ToInt32(str_arr[6]);
                    Arguments.d_2_s = Convert.ToInt32(str_arr[7]);
                    Arguments.d_3_j = Convert.ToInt32(str_arr[8]);
                    Arguments.d_3_m = Convert.ToInt32(str_arr[9]);
                    Arguments.d_3_s = Convert.ToInt32(str_arr[10]);
                }
            }
        }
    }

}
