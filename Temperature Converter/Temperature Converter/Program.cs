using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to please 'c' to use the currency converter or anything else to use the temperature converter");
            string answer=Console.ReadLine();
            if (answer == "c")
            {
                Console.WriteLine("you have selected the currency conver");
                Console.WriteLine("please enter 'a' to convert from pounds or anything else to convert from euros");
                string choice=Console.ReadLine();

                if (choice == "a")
                {
                    Console.WriteLine("please enter your amount in British pounds");
                    float pounds = float.Parse(Console.ReadLine());
                    float euros = pounds * 1.16f;
                    Console.WriteLine("the amount in euros is " + euros.ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("please enter your amount in euros");
                    float euros=float.Parse(Console.ReadLine());
                    float pounds = euros / 1.16f;
                    Console.WriteLine("the amount in British pounds is " + pounds.ToString("0.00"));
                }
            }
            else
            {
                Console.WriteLine("welcome to the temprerature converter");
                Console.WriteLine("please enter 'a' to convert from celcuis or anything else to convert from farenheit");
                string choice= Console.ReadLine();
                if (choice == "a")
                {
                    Console.WriteLine("enter a temperature in celcuis");
                    float celcuis=float.Parse(Console.ReadLine());
                    float farenheit = celcuis * 1.18f + 32f;
                    Console.WriteLine("the temperature in farenheit is " + farenheit);
                }
                else
                {
                    Console.WriteLine("please enter a temperature in farenheit");
                    float farenheit=float.Parse(Console.ReadLine());
                    float celcuis = (farenheit - 32f) / 1.8f;
                    Console.WriteLine("the temperature in celcuis is " + celcuis);
                }
            }
        }
    }
}
