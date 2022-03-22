using System;

namespace lab3
{
    class Program
    {
        public struct Student
        {
            public string prizv;
            public int kurs;
            public string spec;
            public int fiz;
            public int mat;
            public int prog;
        };

        static void Main(string[] args)
        {
            string str = "lights on, no lights off no";
            Console.WriteLine($"STRING = {str}");

            #region task1
            Console.WriteLine();
            Console.WriteLine("TASK 1:");
            for (int j = 0; j < str.Length; j++)
                if ((str[j] == 'n' && str[j + 1] == 'o') || (str[j] == 'o' && str[j + 1] == 'n'))
                {
                    Console.WriteLine("String include on or no");
                    break;
                }

            str = str.Replace("no", "***");

            Console.WriteLine($"Modified String = {String.Join("", str)}");
            #endregion

            #region task2
            Console.WriteLine();
            Console.WriteLine("TASK 2:");
            str = "lights  off,     lights   on";
            int a = 0, b = 0, m = 0;
            char k = str[0];
            foreach (char c in str)
            {
                if (k != c)
                {
                    if (a - b > m)
                    {
                        m = a - b;
                    }
                    b = a;
                    k = c;
                }
                a++;
            }
            Console.WriteLine($"STRING = {str}");
            Console.WriteLine($"Max space elements count = {m}");
            #endregion

            #region task3
            string[] lastnames = { "Сухий", "Чортер", "Ячечак", "Савшак", "Сенишин" };
            string[] specialnist = { "KN", "ME", "IN", "PI", "TI" };

            Console.WriteLine();
            Console.WriteLine("Завдання 2:");

            Console.Write("Кiлькiсть студентiв = ");
            int N = Convert.ToInt32(Console.ReadLine());
            Student[] p = new Student[N]; // створення посилання на об`єкт типу Student
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                p[i].prizv = lastnames[rand.Next(5)];
                p[i].kurs = rand.Next(1, 5);
                p[i].spec = specialnist[rand.Next(5)];
                p[i].fiz = rand.Next(3, 6);
                p[i].mat = rand.Next(3, 6);
                p[i].prog = rand.Next(3, 6);
            }
            Console.WriteLine("===============================================================================\n" +
                              "| № |  Прiзвище  | Курс | Cпецiальнiсть | Фiзика | Математика | Програмування |\n" +
                              "-------------------------------------------------------------------------------");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"|{i,3}|{p[i].prizv,12}|{p[i].kurs,6}|{p[i].spec,15}|{p[i].fiz,8}|{p[i].mat,12}|{p[i].prog,15}|");
            }
            Console.WriteLine("===============================================================================");

            Console.WriteLine("Студенти що вчаться на вiдмiнно\n" +
                          "| № |  Прiзвище  |");
            for (int i = 0; i < N; i++)
            {
                if (p[i].fiz == 5 && p[i].mat == 5 && p[i].prog == 5)
                {
                    Console.WriteLine($"|{i,3}|{p[i].prizv,12}|");
                }
            }

            float fv = 0f;
            for (int i = 0; i < N; i++)
            {
                if ((p[i].fiz + p[i].mat + p[i].prog) / 3f >= 4.5f)
                {
                    fv += 1;
                }
            }
            float perc = fv / N * 100;
            Console.WriteLine($"Percent of students with 4,5 mark = {perc}%");

            #endregion
        }
    }
}
