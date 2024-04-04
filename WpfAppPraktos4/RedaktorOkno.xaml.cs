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
using static System.Net.Mime.MediaTypeNames;

namespace WpfAppPraktos4
{

    public partial class RedaktorOkno : Window
    {
        List<Human> humanlist = new List<Human>();
        public RedaktorOkno()
        {
            InitializeComponent();
            humanlist = JsonAgav.myDeserialize<List<Human>>(); 
            DataGridAgav.ItemsSource = humanlist; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Human> humanlist2 = new List<Human>();
            foreach (var item in DataGridAgav.Items)
            {
                if (item is Human item2)
                {
                    humanlist2.Add(item2);
                }
            }
            JsonAgav.mySerialize(humanlist2);
        }
    }
}
