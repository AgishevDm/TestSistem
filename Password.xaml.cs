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
    /// Логика взаимодействия для Password.xaml
    /// </summary>
    public partial class Password : Window
    {
        //Пароль для окна ошибок: 6666
        public string key = "6666";
        public Password()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            string password = PasswordForMistakes.Password;
            bool check = true;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsLetter(password[i]) == true)
                {
                    MessageBox.Show("Неверный пароль :(");
                    PasswordForMistakes.Password = "";
                    i = password.Length;
                    check = false;
                }
            }
            if (check)
            {
                if (key == password)
                {
                    new Mistakes().Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Неверный пароль :(");
                    PasswordForMistakes.Password = "";
                }
            }
        }
    }
}
