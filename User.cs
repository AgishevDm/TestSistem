using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp3
{
    class User
    {
        public static int per;
        public static int count = 0;
        public static int amount = 0;
        //-----------------------------
        //метод для генерации вопросов
        //-----------------------------
        public static string Rez(int kol)
        {
            amount = kol;
            string rez;

            //-------------------------------------------------
            //формирование результатов после прохождения теста
            //-------------------------------------------------

            per = (count * 100) / amount;
            if (count == 1 && count == 21) rez = $"       {count} верный ответ из {amount}\nВаш процент выполнения: {per} % ";  
            else rez = $"       {count} верных ответов из {amount}\nВаш процент выполнения: {per} % ";
            return rez;
        }
        public int Mark()
        {
            int mark;
            if (per > 80) mark = 5;
            else if (per > 60) mark = 4;
            else if (per > 40) mark = 3;
            else mark = 2;
            return mark;
        }

        public static void SaveMe(int num)
        {
            string trueval = MainWindow.TaskList[num - 2].Answer.ToLower();
            string userval = MainWindow.TaskList[num - 2].UserAnswer.ToLower();
            if (trueval == userval)
                count++;
        }

        //------------------------------------
        //метод для составления списка ошибок
        //------------------------------------
    }
}
