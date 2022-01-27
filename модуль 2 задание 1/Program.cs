using System;

/*Задание 1
Объявить одномерный (5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. 
Заполнить одномерный массив
А числами, введенными с клавиатуры пользователем, а
двумерный массив В случайными числами с помощью
циклов. Вывести на экран значения массивов: массива
А в одну строку, массива В — в виде матрицы. Найти в
данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее
произведение всех элементов, сумму четных элементов
массива А, сумму нечетных столбцов массива В.*/
namespace модуль_2_задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            double[] arr = new double[size];
            double sum = 0, proizvedenue = 1;
            double sum_chet_elem = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToDouble(Console.ReadLine());

            }
            Console.WriteLine();
           

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                sum += arr[i];
                proizvedenue *= arr[i];

                if (arr[i] % 2 == 0)
                {
                    sum_chet_elem += arr[i];
                }

            }
            Console.WriteLine();
            Console.WriteLine($"summa = {sum}, proizvedenue = {proizvedenue}, summa chetnux elementov = {sum_chet_elem}");

            Random random = new Random();
            int n = 3;
            int m = 4;
            double[,] arr_2 = new double[n, m];
            double min = 0;
            double max = 0;
            double podchet_stolbcob = 0;

            for (int i = 0; i < arr_2.GetLength (0); i++)
            {
                for (int j = 0; j < arr_2.GetLength(1); j++)

                {
                    Console.Write($" {arr_2[i, j] = Math.Round( random.NextDouble() *10,1)} " ); // округление до 10                 
                    sum += arr_2[i, j];
                    proizvedenue *= arr_2[i,j];

                    if ((j +1) % 2 !=0)
                    {
                        podchet_stolbcob += arr_2[i, j];

                    } 
                }
                Console.WriteLine();
            }
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr_2.GetLength(0); j++)
                {
                    for (int a = 0; a < arr_2.GetLength(1); a++)
                    {
                        if (arr[i] == arr_2[j, a])
                        {
                            if (min == 0 && max == 0) min = max = arr[i];
                            else if (arr[i] > max) max = arr[i];
                            else if (arr[i] < min) min = arr[i];
                            Console.WriteLine(arr[i] + " ");

                            
                        }
                    }
                }
            }
           
           
           Console.WriteLine($"summa = {sum}, proizvedenue = {proizvedenue}, summa nehetnux stolbcov = {podchet_stolbcob}");
            Console.WriteLine($"min = {min}, max = {max}");
        }
    }
}
