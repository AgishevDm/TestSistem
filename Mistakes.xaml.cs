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
    /// Логика взаимодействия для Mistakes.xaml
    /// </summary>
    public partial class Mistakes : Window
    {
        public Mistakes()
        {
           
            InitializeComponent();
            ErrorMaker();
        }

        public void ErrorMaker()
        {
            int len = MainWindow.TaskList.Count;
            for (int i = 0; i < len; i++)
            {
                string result;
                result = $"\nВОПРОС №{i+1}\n";
                result += MainWindow.TaskList[i].Question + "\nПравильный ответ: " + MainWindow.TaskList[i].Answer + "\nВаш ответ: " + MainWindow.TaskList[i].UserAnswer + "\n";
                ErrText.Text += result;
            }
        }


    }
}
