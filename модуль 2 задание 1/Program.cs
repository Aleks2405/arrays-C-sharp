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
            Array.Sort(arr); // воспользовался тем что есть и не стал изобретать велосипед 

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
            Console.WriteLine($"min = {arr[0]}, max = {arr[arr.Length - 1]}");
            Console.WriteLine($"summa = {sum}, proizvedenue = {proizvedenue}, summa chetnux elementov = {sum_chet_elem}");

            Random random = new Random();

            double[,] arr_2 = new double[3, 4];

            double min = 1;
            double max = 0;
            double podchet_stolbcob = 0;

            for (int i = 0; i < arr_2.GetLength (0); i++)
            {
                for (int j = 0; j < arr_2.GetLength(1); j++)

                {
                    Console.Write($" {arr_2[i, j] = Math.Round( random.NextDouble() *10,2)} " );
                    //Console.WriteLine();
                    sum += arr_2[i, j];
                    proizvedenue *= arr_2[i,j];

                    if (j % 2 != 0)
                    {
                        podchet_stolbcob += arr_2[i, j];
                    }

                    if (arr_2[0,0] > 0 && arr_2[i, j] < min)
                    {
                        min = arr_2[i, j];
                    }
                    if (arr_2[i, j] > max)
                    {
                        max = arr_2[i, j];
                    }

                }
                Console.WriteLine();
            }
           
           // Console.WriteLine($"mun = {arr_2[0,0]}, max = {arr_2[arr_2.Length - 1,arr_2.Length-1]}");
           Console.WriteLine($"summa = {sum}, proizvedenue = {proizvedenue}, summa nehetnux stolbcov = {podchet_stolbcob}, min = {min}" +
               $" max = {max}");

        }
    }
}
