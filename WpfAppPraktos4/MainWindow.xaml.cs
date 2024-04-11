using System.Text;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using Newtonsoft;

namespace WpfAppPraktos4
{
    public partial class MainWindow : Window
    {
        TestOkno testokno = new TestOkno();
        RedaktorOkno redaktorokno = new RedaktorOkno();
        string parol = "Агав";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            testokno.Show();
            this.Close();
        }

        private void redaktirovanie_Click(object sender, RoutedEventArgs e)
        {
            if (parol == Password.Text)
            {
                redaktorokno.Show();
                this.Close();
            }

        }
    }
}