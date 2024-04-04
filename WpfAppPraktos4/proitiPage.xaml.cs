using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;

namespace WpfAppPraktos4
{
    public partial class proitiPage : Page
    {
        List<Human> humanlist = new List<Human>();
        int index = 0;
        int correct = 0;
        int incorrect = 0;

        private void vibor()
        {
            if (index < humanlist.Count)
            {
                NameTest.Content = humanlist[index].Name;
                Description.Content = humanlist[index].Description;
                JmiSuda1.Content = humanlist[index].Answer1;
                JmiSuda2.Content = humanlist[index].Answer2;
                JmiSuda3.Content = humanlist[index].Answer3;
            }
        }
        public proitiPage()
        {
            InitializeComponent();
            humanlist = JsonAgav.myDeserialize<List<Human>>();
            vibor();
        }

        private void JmiSuda1_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(humanlist[index].CorrectOption) == 0)
            {
                correct = correct + 1;
            }
            else
            {
                incorrect = incorrect + 1;
            }
            if (index < humanlist.Count - 1)
            {
                index = index + 1;
                vibor();
            }
            else if (index == humanlist.Count - 1)
            {
                NameTest.Content = $"Тест был пройден, правильных ответов {correct}, неправильных {incorrect}";
            }
        }

        private void JmiSuda2_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(humanlist[index].CorrectOption) == 1)
            {
                correct = correct + 1;
            }
            else
            {
                incorrect = incorrect + 1;
            }
            if (index < humanlist.Count - 1)
            {
                index = index + 1;
                vibor();
            }
            else if (index == humanlist.Count - 1)
            {
                NameTest.Content = $"Тест был пройден, правильных ответов {correct}, неправильных {incorrect}";
            }
        }
        private void JmiSuda3_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(humanlist[index].CorrectOption) == 2)
            {
                correct = correct + 1;
            }
            else
            {
                incorrect = incorrect + 1;
            }
            if (index < humanlist.Count - 1)
            {
                index = index + 1;
                vibor();
            }
            else if (index == humanlist.Count - 1)
            {
                NameTest.Content = $"Тест был пройден, правильных ответов {correct}, неправильных {incorrect}";
            }
        }
    }
}
