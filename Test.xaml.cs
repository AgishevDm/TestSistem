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
using System.IO;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        protected int num;
        public int Num { get { return num; } set { num = value; } }
        protected string kol, info;
        
        public string Kol { get { return kol; } set { kol = value; } }
        public string Info { get { return info; } set { info = value; } }

        private static List<int> UsedNumbers = new List<int>();
        

        Random Rand = new Random();

        public Test(string Count, string Name, string Grade)
        {
            InitializeComponent();
            kol = Count;
            num = 1;
            info = $"{Name}, {Grade}";
            Counter.Content = $"ВОПРОС {num} из {Count}";
            if (num < int.Parse(Count))
                next.Content = "Далее";
            else next.Content = "Завершить";            
        }

        public void MakeQQ()
        {
            OneAnswer.Visibility = Visibility.Hidden;
            ManyAnswers.Visibility = Visibility.Hidden;
            AnswerText.Visibility = Visibility.Hidden;
            ch1.IsChecked = ch2.IsChecked = ch3.IsChecked = ch4.IsChecked = false;
            rb1.IsChecked = rb2.IsChecked = rb3.IsChecked = rb4.IsChecked = false;
            AnswerText.Text = "";
            Task Task = new Task();
            int n = Rand.Next(1, Task.TestAmount+1);//генерация номера вопроса, которого ещё не было в списке
            if (Convert.ToInt32(MainWindow.MainAmount)-1 >= Task.TestAmount)
            {
                MessageBox.Show("Тест не готов.");
                new Result(info, int.Parse(kol)).Show();
                Hide();
                Close();
            }
            else
            {
                while (UsedNumbers.Contains(n))
                {
                    n = Rand.Next(1, Task.TestAmount+1);
                }
                UsedNumbers.Add(n);
                MainWindow.TaskList.Add(Task.TaskMaker(n));
                QuestionTest.Text = MainWindow.TaskList[num - 1].Question;
                if (MainWindow.TaskList[num - 1].Answtype == "Один")
                {
                    OneAnswer.Visibility = Visibility.Visible;
                    var numbers = MainWindow.TaskList[num - 1].Choise
                        .Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                    rb1.Content = numbers.ElementAt(0);
                    rb2.Content = numbers.ElementAt(1);
                    rb3.Content = numbers.ElementAt(2);
                    rb4.Content = numbers.ElementAt(3);
                }
                else if (MainWindow.TaskList[num - 1].Answtype == "Много")
                {
                    ManyAnswers.Visibility = Visibility.Visible;
                    var numbers = MainWindow.TaskList[num - 1].Choise
                        .Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                    ch1.Content = numbers.ElementAt(0);
                    ch2.Content = numbers.ElementAt(1);
                    ch3.Content = numbers.ElementAt(2);
                    ch4.Content = numbers.ElementAt(3);
                }
                else
                {
                    AnswerText.Visibility = Visibility.Visible;
                }
            }
        }

        private void AnswerText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            // блок записи ответа
            if (OneAnswer.Visibility == Visibility.Visible)
            {
                MainWindow.TaskList[num - 1].UserAnswer = ((bool)(rb1.IsChecked)) ? rb1.Content.ToString() :
                                                            ((bool)(rb2.IsChecked)) ? rb2.Content.ToString() :
                                                            ((bool)(rb3.IsChecked)) ? rb3.Content.ToString() :
                                                            ((bool)(rb4.IsChecked)) ? rb4.Content.ToString() : "";

            }
            else if (ManyAnswers.Visibility == Visibility.Visible)
            {
                MainWindow.TaskList[num - 1].UserAnswer = "";
                if ((bool)(ch1.IsChecked)) MainWindow.TaskList[num - 1].UserAnswer += ch1.Content + ";";
                if ((bool)(ch2.IsChecked)) MainWindow.TaskList[num - 1].UserAnswer += ch2.Content + ";";
                if ((bool)(ch3.IsChecked)) MainWindow.TaskList[num - 1].UserAnswer += ch3.Content + ";";
                if ((bool)(ch4.IsChecked)) MainWindow.TaskList[num - 1].UserAnswer += ch4.Content + ";";
            }
            else if (AnswerText.Visibility == Visibility.Visible)
                MainWindow.TaskList[num - 1].UserAnswer = AnswerText.Text;
            // конец блока записи ответа
            // блок сохранения вопроса в файл
            string result = $"\nВОПРОС №{num}\n";
            result += MainWindow.TaskList[num - 1].Question + "\nПравильный ответ: " + MainWindow.TaskList[num - 1].Answer + "\nВаш ответ: " + MainWindow.TaskList[num - 1].UserAnswer + "\n";
            FileStream fs = new FileStream($"Test {MainWindow.MainName}.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(result);
            sw.Close();
            // конец блока сохранения вопроса в файл
            num++;
            if (!(next.Content.ToString() == "Завершить"))
                MakeQQ(); //формирование нового вопроса, пока нет надписи "завершить"
            else fs.Close();
            User.SaveMe(num); // сравнение ответа пользователя и правильного ответа

            if (num < int.Parse(kol))
            { 
                Counter.Content = $"ВОПРОС {num} из {int.Parse(kol)}";
                next.Content = "Далее";
                //генерация вопроса
            }
            else if (num == int.Parse(kol))
            {
                Counter.Content = $"ВОПРОС {num} из {int.Parse(kol)}";
                next.Content = "Завершить";
                //генерация вопроса
            }
            else
            {
                new Result(info, int.Parse(kol)).Show();
                Hide();
            }
        }

    }

    public class Task
    {
        private string question;
        private string choise;
        private string answtype;
        private string answer;
        private string useranswer;
        private int testamount;

        public string Question { get { return question; } set { question = value; } }
        public string Choise { get { return choise; } set { choise = value; } }
        public string Answtype { get { return answtype; } set { answtype = value; } }
        public string Answer { get { return answer; } set { answer = value; } }
        public string UserAnswer { get { return useranswer; } set { useranswer = value; } }
        public int TestAmount { get { return testamount; } set { testamount = value; } }
        public Task(string a, string b, string c, string d, string e)
        {
            Question = a;
            Choise = b;
            Answtype = c;
            Answer = d;
            UserAnswer = e;
        }

        public Task()
        {
            Read task = new Read($"{MainWindow.MainGrade}.ini");
            TestAmount = Convert.ToInt32(task.ReadINI("0", "n"));
        }
        public static Task TaskMaker(int n)
        {
            Read task = new Read($"{MainWindow.MainGrade}.ini");
            string quest = task.ReadINI($"{n}", "Вопрос");
            string type = task.ReadINI($"{n}", "Тип ответа"); // один много текст
            string choices = task.ReadINI($"{n}", "Варианты");
            string answer = task.ReadINI($"{n}", "Ответ");
            return new Task(quest, choices, type, answer, null);
        }        
    }
}

