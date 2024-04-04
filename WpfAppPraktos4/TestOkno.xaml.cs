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
using System.Windows.Shapes;

namespace WpfAppPraktos4
{
    public partial class TestOkno : Window
    {
        public TestOkno()
        {
            InitializeComponent();
        }

        private void redaktor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void proiti_Click(object sender, RoutedEventArgs e)
        {
            //Frameagav.Content = new Pusto();
            Frameagav.Content = new proitiPage();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); 
        }
    }
}
