using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Car : Vehicle
    {
        public int FuelCapacity { get; set; }

        public Car() 
        {
        }

        public void AddFuel()
        {
            try
            {
            ReEnter:

                Console.WriteLine("Elave etmek istediyiniz yanacagin miqdarini daxil edin");
                int fuel = Convert.ToInt32(Console.ReadLine());
            
                if (CurrentFuel + fuel > FuelCapacity)
                {
                    Console.WriteLine("Max tutum ashildi");
                    Console.WriteLine("Elave etmek istediyiniz yanacaq miqdarini yeniden daxil edin");
                    goto ReEnter;
                }
                else
                {
                    CurrentFuel += fuel;
                    Console.WriteLine($"{fuel} litr yanacaq elave olundu");
                }                


            }
            catch 
            {
                Console.WriteLine("Yanacaq miqdarini duzgun daxil edin");
            }
           
        }


    }
}
