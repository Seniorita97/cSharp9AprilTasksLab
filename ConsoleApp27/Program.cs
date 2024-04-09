using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 73, 4, 5, 6, 7, 8, -123, 10, 11, 12, 233, 49, };
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
                int[] newarr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    newarr[i] = arr[i];
                }

            Console.WriteLine($"{newarr[0]} {newarr[1]} {newarr[n-1]} {newarr[n-2]}");

                int sum = newarr[0] + newarr[1] + newarr[n-1] + newarr[n-2];

            Console.WriteLine(sum);

                //Console.WriteLine("Brendi daxil et");
                //string brend = Console.ReadLine();

                //Console.WriteLine("Modeli daxil et");
                //string model = Console.ReadLine();

                //Console.WriteLine("Millaji daxil et");
                //int millage = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Movcud yanacagi daxil et");
                //int currentFuel = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Max yanacaq tutumunu daxil et");
                //int fuelCapacity = Convert.ToInt32(Console.ReadLine());

                //Car car1 = new Car()
                //{
                //    Brend = brend,
                //    Millage = millage,
                //    Model = model,  
                //    FuelCapacity = fuelCapacity,
                //    CurrentFuel = currentFuel
                //};

                //car1.AddFuel();

                //Console.WriteLine("Indiki benzin "+car1.CurrentFuel);
            }
    }
}
