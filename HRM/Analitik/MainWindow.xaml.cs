using LiveCharts.Wpf;
using LiveCharts;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Analitik
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            plot1.Visibility = Visibility.Collapsed;
            plot1_1.Visibility = Visibility.Collapsed;
            plot1_2.Visibility = Visibility.Collapsed;
            plot1_3.Visibility = Visibility.Collapsed;

            if (Arguments.type_plot == 0)
            {
                this.Title = Arguments.name;
                plot1.Visibility = Visibility.Visible;
                SeriesCollection seriesViews = new SeriesCollection();
                PieSeries[] pieSeries_arr = new PieSeries[]
                {
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} руб.", chartPoint.Y),
                 DataLabels = true,
                 Title = "Отдел сисадминов",
                 Values = new ChartValues<double>(new double[] { Arguments.sum_dep1 })},
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} руб.", chartPoint.Y),
                 DataLabels = true,
                 Title = "Отдел системных программистов",
                 Values = new ChartValues<double>(new double[] { Arguments.sum_dep2 })},
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} руб.", chartPoint.Y),
                 DataLabels = true,
                 Title = "Отдел stm программистов",
                 Values = new ChartValues<double>(new double[] { Arguments.sum_dep3 })}
                };
                seriesViews.AddRange(pieSeries_arr);
                plot1.Series = seriesViews;
            }
            else if (Arguments.type_plot == 1)
            {
                this.Title = Arguments.name;
                plot1.Visibility = Visibility.Visible;
                SeriesCollection seriesViews = new SeriesCollection();
                PieSeries[] pieSeries_arr = new PieSeries[]
                {
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} задачи", chartPoint.Y),
                 DataLabels = true,
                 Title = "Отдел сисадминов",
                 Values = new ChartValues<double>(new double[] { Arguments.sum_dep1 })},
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} задачи", chartPoint.Y),
                 DataLabels = true,
                 Title = "Отдел системных программистов",
                 Values = new ChartValues<double>(new double[] { Arguments.sum_dep2 })},
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} задачи", chartPoint.Y),
                 DataLabels = true,
                 Title = "Отдел stm программистов",
                 Values = new ChartValues<double>(new double[] { Arguments.sum_dep3 })}
                };
                seriesViews.AddRange(pieSeries_arr);
                plot1.Series = seriesViews;
            }
            else if (Arguments.type_plot == 2)
            {
                this.Title = Arguments.name;
                plot1.Visibility = Visibility.Visible;
                SeriesCollection seriesViews = new SeriesCollection();
                PieSeries[] pieSeries_arr = new PieSeries[]
                {
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} задачи", chartPoint.Y),
                 DataLabels = true,
                 Title = "Отдел сисадминов",
                 Values = new ChartValues<double>(new double[] { Arguments.sum_dep1 })},
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} задачи", chartPoint.Y),
                 DataLabels = true,
                 Title = "Отдел системных программистов",
                 Values = new ChartValues<double>(new double[] { Arguments.sum_dep2 })},
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} задачи", chartPoint.Y),
                 DataLabels = true,
                 Title = "Отдел stm программистов",
                 Values = new ChartValues<double>(new double[] { Arguments.sum_dep3 })}
                };
                seriesViews.AddRange(pieSeries_arr);
                plot1.Series = seriesViews;
            }
            else if (Arguments.type_plot == 3)
            {
                this.Title = Arguments.name;
                plot1.Visibility = Visibility.Visible;
                SeriesCollection seriesViews = new SeriesCollection();
                PieSeries[] pieSeries_arr = new PieSeries[]
                {
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} руб.", chartPoint.Y),
                 DataLabels = true,
                 Title = "Junior",
                 Values = new ChartValues<double>(new double[] { Arguments.sum_dep1 })},
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} руб.", chartPoint.Y),
                 DataLabels = true,
                 Title = "Middle",
                 Values = new ChartValues<double>(new double[] { Arguments.sum_dep2 })},
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} руб.", chartPoint.Y),
                 DataLabels = true,
                 Title = "Senior",
                 Values = new ChartValues<double>(new double[] { Arguments.sum_dep3 })}
                };
                seriesViews.AddRange(pieSeries_arr);
                plot1.Series = seriesViews;
            }
            else if (Arguments.type_plot == 4)
            {
                this.Title = Arguments.name;
                plot1.Visibility = Visibility.Visible;
                SeriesCollection seriesViews = new SeriesCollection();
                PieSeries[] pieSeries_arr = new PieSeries[]
                {
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} задачи", chartPoint.Y),
                 DataLabels = true,
                 Title = "Junior",
                 Values = new ChartValues<double>(new double[] { Arguments.sum_dep1 })},
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} задачи", chartPoint.Y),
                 DataLabels = true,
                 Title = "Middle",
                 Values = new ChartValues<double>(new double[] { Arguments.sum_dep2 })},
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} задачи", chartPoint.Y),
                 DataLabels = true,
                 Title = "Senior",
                 Values = new ChartValues<double>(new double[] { Arguments.sum_dep3 })}
                };
                seriesViews.AddRange(pieSeries_arr);
                plot1.Series = seriesViews;
            }
            else if (Arguments.type_plot == 5)
            {
                this.Title = Arguments.name;
                plot1.Visibility = Visibility.Visible;
                SeriesCollection seriesViews = new SeriesCollection();
                PieSeries[] pieSeries_arr = new PieSeries[]
                {
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} задачи", chartPoint.Y),
                 DataLabels = true,
                 Title = "Junior",
                 Values = new ChartValues<double>(new double[] { Arguments.sum_dep1 })},
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} задачи", chartPoint.Y),
                 DataLabels = true,
                 Title = "Middle",
                 Values = new ChartValues<double>(new double[] { Arguments.sum_dep2 })},
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} задачи", chartPoint.Y),
                 DataLabels = true,
                 Title = "Senior",
                 Values = new ChartValues<double>(new double[] { Arguments.sum_dep3 })}
                };
                seriesViews.AddRange(pieSeries_arr);
                plot1.Series = seriesViews;
            }
            else if (Arguments.type_plot == 6)
            {
                this.Title = Arguments.name;
                plot1_1.Visibility = Visibility.Visible;
                plot1_2.Visibility = Visibility.Visible;
                plot1_3.Visibility = Visibility.Visible;
                SeriesCollection seriesViews1 = new SeriesCollection();
                PieSeries[] pieSeries_arr1 = new PieSeries[]
                {
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} чел.", chartPoint.Y),
                 DataLabels = true,
                 Title = "Junior",
                 Values = new ChartValues<double>(new double[] { Arguments.d_1_j })},
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} чел.", chartPoint.Y),
                 DataLabels = true,
                 Title = "Middle",
                 Values = new ChartValues<double>(new double[] { Arguments.d_1_m })},
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} чел.", chartPoint.Y),
                 DataLabels = true,
                 Title = "Senior",
                 Values = new ChartValues<double>(new double[] { Arguments.d_1_s })}
                };
                seriesViews1.AddRange(pieSeries_arr1);
                plot1_1.Series = seriesViews1;

                SeriesCollection seriesViews2 = new SeriesCollection();
                PieSeries[] pieSeries_arr2 = new PieSeries[]
                {
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} чел.", chartPoint.Y),
                 DataLabels = true,
                 Title = "Junior",
                 Values = new ChartValues<double>(new double[] { Arguments.d_2_j })},
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} чел.", chartPoint.Y),
                 DataLabels = true,
                 Title = "Middle",
                 Values = new ChartValues<double>(new double[] { Arguments.d_2_m })},
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} чел.", chartPoint.Y),
                 DataLabels = true,
                 Title = "Senior",
                 Values = new ChartValues<double>(new double[] { Arguments.d_2_s })}
                };
                seriesViews2.AddRange(pieSeries_arr2);
                plot1_2.Series = seriesViews2;

                SeriesCollection seriesViews3 = new SeriesCollection();
                PieSeries[] pieSeries_arr3 = new PieSeries[]
                {
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} чел.", chartPoint.Y),
                 DataLabels = true,
                 Title = "Junior",
                 Values = new ChartValues<double>(new double[] { Arguments.d_3_j })},
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} чел.", chartPoint.Y),
                 DataLabels = true,
                 Title = "Middle",
                 Values = new ChartValues<double>(new double[] { Arguments.d_3_m })},
             new PieSeries { LabelPoint = chartPoint => string.Format("{0} чел.", chartPoint.Y),
                 DataLabels = true,
                 Title = "Senior",
                 Values = new ChartValues<double>(new double[] { Arguments.d_3_s })}
                };
                seriesViews3.AddRange(pieSeries_arr3);
                plot1_3.Series = seriesViews3;
            }
        }
    }
}