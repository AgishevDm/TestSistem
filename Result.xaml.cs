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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Result.xaml
    /// </summary>
    public partial class Result : Window
    {
        public Result(string info, int kol)
        {
            InitializeComponent();
            Data.Content = info;
            ResultAndPercent.Content = User.Rez(kol);
            User m = new User();
            Mark.Content = $"ОЦЕНКА {m.Mark()}";
        }

        private void Mistake_Click(object sender, RoutedEventArgs e)
        {
            new Password().Show();
        }

        private void NewTest_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Hide();
        }
    }
}
