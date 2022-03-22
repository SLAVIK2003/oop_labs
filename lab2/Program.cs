using System;

namespace laba2
{
    class Program
    {
        static void Main()
        {
            //Завдання 1
            Console.WriteLine("Task 1");

            Random rnd = new Random(); //рандомайзер
            const int n = 20; //кількість елементів масиву
            int[] a = new int[n];//створення масиву

            int low = -20;//мінімальне значення рандомного числа
            int high = 50;//максимальне 

            for (int i = 0; i < n; i++)
                a[i] = low + rnd.Next() % (high - low + 1);//заповнення масиву рандомними числами

            Console.Write("a[] = {");               //
                                                    // 
            for (int i = 0; i < n; i++)             //
            {                                       //
                Console.Write($"{a[i]} , ");        //ВИВЕДЕННЯ МАССИВУ
                                                    //
            }                                       // 
            Console.WriteLine("}");                 //
            Console.WriteLine();

            int S = 0;//Сума
            int k = 0;//кількість

            for (int i = 0; i < n; i++)
                if (a[i] > 0 && !(a[i] % 5 == 0))
                {
                    S += a[i];
                    k++;
                    a[i] = 0;
                }//рахуємо суму, кількість і задаємо елементи нулями

            Console.WriteLine($"Number = {k}");
            Console.WriteLine($"Sum = {S}");
            Console.WriteLine();
            Console.Write("a[] = {");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} , ");
            }
            Console.WriteLine("}"); //виводимо змінений масив
            Console.WriteLine();

            //Завдання 2
            Console.WriteLine("Task 2");
            
            const int nt = 5;  //кількість елементів масиву
            low = 1;//мінімальне значення рандомного числа
            high = 10;//максимальне 

            for (int i = 0; i < nt; i++)
                a[i] = low + rnd.Next() % (high - low + 1);//заповнення масиву рандомними числами
            Console.Write("a[] = {");

            for (int i = 0; i < nt; i++)
            {
                Console.Write($"{a[i]} , ");

            }//ВИВЕДЕННЯ МАССИВУ
            Console.WriteLine("}");
            Console.WriteLine();

            int min = a[0];//мінімальний елемент
            int imin = 0;//індекс мінімального елементу
            for (int i = 1; i < nt; i++)
                if (a[i] < min)
                {
                    min = a[i];//якщо елемент менший за заданий мімальний то він стає мінімальним і його індекс стає індексом мінімального
                    imin = i;
                }

            int max = a[0];//макс елемент
            int imax = 0;//індекс макс елементу
            for (int i = 1; i < nt; i++)
                if (a[i] > max)
                {
                    max = a[i];//якщо елемент більший за заданий максимальний то він стає макс. і його індекс стає індексом макс.
                    imax = i;
                }

            max = a[imax];
            min = a[imin];
                              //міняємо місцями максимальний і мінімальний
            a[imax] = min;
            a[imin] = max;

            Console.Write("a[] = {");

            for (int i = 0; i < nt; i++)
            {
                Console.Write($"{a[i]} , ");

            }//ВИВЕДЕННЯ ЗМІНЕНОГО МАССИВУ
            Console.WriteLine("}");
            Console.WriteLine();

            //Завдання 3
            Console.WriteLine("Task 3");
            int rowCount = 4;//кількість рядків
            int colCount = 4;//стовпців

            int[,] ab = new int[rowCount, colCount];//створення масиву

            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < colCount; j++)
                    ab[i, j] = low + rnd.Next() % (high - low + 1);//заповнюєм масив рандомними значеннями

            Console.WriteLine();
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                    Console.Write($"{ab[i, j], 5}");//вивід масиву в формі таблиці

                Console.WriteLine();
            }
            Console.WriteLine();

            int tmp = 0;//змінна для збереження елементу матриці який буде змінено
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < i; j++)
                {
                    tmp = ab[i,j];
                    ab[i,j] = ab[j,i];      //транспозиція матриці
                    ab[j,i] = tmp;
                }

            Console.WriteLine("Transposed matrix:");

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)  
                    Console.Write($"{ab[i, j],5}");   

                Console.WriteLine();
            }//вивід транспонованої матриці
            Console.WriteLine();
        }
    }
}
