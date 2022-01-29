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
using Microsoft.Win32;
using LiveCharts;
using LiveCharts.Wpf;
using national_statistics.src.model;
using System.Data;

namespace national_statistics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

        
    {
        //Attributes
        private DataTable dataTable;

        //Relationships
        private NationalStatistic nationalS;

        public MainWindow()
        {
            InitializeComponent();
            nationalS = new NationalStatistic();
            dataTable = new DataTable();
            displayLettersInCbx();

        }

       

        public void createGraphic()
        {
            SeriesCollection series = new();
            foreach (Department dep in nationalS.getDepartments())
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

        private void ButtonImportData_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Title = "Import Data";
            d.Filter = "CSV files | *.csv;";
            if (d.ShowDialog() == true && d.CheckFileExists == true)
            {
                nationalS.importFile(d.FileName);
                dataTable = nationalS.fillTable(nationalS.getDepartments());
                dataGrid.ItemsSource = dataTable.DefaultView;
                dataGrid.GridLinesVisibility = DataGridGridLinesVisibility.All;
                createGraphic();
            }
        }

        private void displayLettersInCbx()
        {
            char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            cbx.ItemsSource = letters;
        }

        private void cbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Department> results = nationalS.filterDepartments(char.Parse(cbx.SelectedValue.ToString()));
            dataTable = nationalS.fillTable(results);
            dataGrid.ItemsSource = dataTable.DefaultView;
        }
    }
}
