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

        private void ButtonCreateGraphic_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonImportData_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Title = "Import Data";
            d.Filter = "CVS files |*.cvs;";
            if(d.ShowDialog() == true && d.CheckFileExists == true)
            {
                nationalS.importFile(d.FileName);
            }
        }
    }
}
