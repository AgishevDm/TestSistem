using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.IO;
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
using System.Xml.Linq;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static List<Task> TaskList = new List<Task>();
        public static string MainName = "";
        public static string MainAmount = "";
        public static string MainGrade = "";


        private void StartTest(object sender, RoutedEventArgs e)
        {
            MainGrade = Grade.Text;
            MainName = StName.Text;
            MainAmount = Amount.Text;
            bool check = true;

            if (MainAmount.Length < 1 || MainName.Length < 1 || MainGrade.Length < 1)
            {
                MessageBox.Show("Заполните все поля!");
                check = false;
            }
            else
            {
                for (int i = 0; i < MainName.Length; i++)
                {
                    if (MainName[i] == ' ' || MainName[i] == '-')
                    {

                    }
                    else if (Char.IsLetter(MainName[i]) == false)
                    {
                        MessageBox.Show("Заполните фамилию и имя!");
                        check = false;
                        StName.Text = "";
                        i = MainName.Length;

                    }
                }
                string Tamount = Amount.Text;
                int amount;
                for (int i = 0; i < Tamount.Length; i++)
                {
                    if (char.IsDigit(Tamount[i])) { }
                    ///check = true;
                    else
                    {
                        MessageBox.Show("Количество заданий введено неверно");
                        Amount.Text = "";
                        check = false;
                        i = Tamount.Length;
                    }
                }
                if (check)
                {
                    amount = Convert.ToInt32(Amount.Text);
                    if (amount < 1 || amount > 30)
                    {
                        MessageBox.Show("Количество заданий от 1 до 30!");
                        check = false;
                        Amount.Text = "";
                    }
                }
            }
            if (check)
            {
                //new Test(MainAmount, MainName, MainGrade).Show();
                FileStream fs = new FileStream($"Test {MainName}.txt", FileMode.OpenOrCreate);
                fs.Close();
                Test Test = new Test(MainAmount, MainName, MainGrade);
                Test.Num = 1;                
                Test.Show();
                Test.MakeQQ();
                Hide();                
            }
        }

        private void Amount_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
