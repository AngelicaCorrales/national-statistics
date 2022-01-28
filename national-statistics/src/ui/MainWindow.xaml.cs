using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;
using national_statistics.src.model;

namespace national_statistics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Relationships
        private NationalStatistics nationalS;

        public MainWindow()
        {
            InitializeComponent();
            nationalS = new NationalStatistics();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        public void createGraphic()
        {
            SeriesCollection series = new();
            foreach (Department dep in nationalS.Departments)
            {
                series.Add(new PieSeries()
                {
                    Title = dep.getName(),
                    Values = new ChartValues<int> { dep.getMunicipalities().Count },
                    DataLabels = true,
                });
            }
            pieChart.Series = series;

        }
    }
}
