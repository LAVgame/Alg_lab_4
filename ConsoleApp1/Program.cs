using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();
            sw.Start();
            Console.WriteLine("Введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            float[] arr = new float[n];
            float max = float.MinValue;
            float min = float.MaxValue;          
            for (int i = 0; i < n; i++)
            {
                arr[i] = new Random().Next(-1000,1001);
                //Max

                if (max < arr[i] )
                {
                    max = arr[i];
                }
                //Min
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            sw.Stop();
            Console.WriteLine($"Min = {min}; Max = {max};");
            Console.WriteLine($"Время выполнения: {sw.Elapsed}");


        }
    }
}
