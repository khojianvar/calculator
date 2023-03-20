using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double firstnumber = double.Parse(Console.ReadLine());
            Console.Write("Amal tanlang: 1-(+), 2-(-), 3-(/), 4-(*), 5-(%): ");
            string amal = Console.ReadLine();
            Console.Write("Enter second number: ");
            double secondnumber = double.Parse(Console.ReadLine());
            switch (amal)
            {
                case "1": Console.WriteLine($" {firstnumber} + {secondnumber} = {firstnumber + secondnumber}"); break;
                case "+": Console.WriteLine($" {firstnumber} + {secondnumber} = {firstnumber + secondnumber}"); break;
                case "2": Console.WriteLine($" {firstnumber} - {secondnumber} = {firstnumber - secondnumber}"); break;
                case "-": Console.WriteLine($" {firstnumber} - {secondnumber} = {firstnumber - secondnumber}"); break;
                case "3":
                    if (firstnumber == 0 || secondnumber == 0)
                    {
                        Console.WriteLine("0ga b`olib bo`lmaydi"); break;
                    }
                    else
                    {
                        Console.WriteLine($" {firstnumber} / {secondnumber} = {firstnumber / secondnumber}"); break;
                    }
                case "/":
                    if (firstnumber == 0 || secondnumber == 0)
                    {
                        Console.WriteLine("0ga b`olib bo`lmaydi"); break;
                    }
                    else
                    {
                        Console.WriteLine($" {firstnumber} / {secondnumber} = {firstnumber / secondnumber}"); break;
                    }
                case "4": Console.WriteLine($" {firstnumber} * {secondnumber} = {firstnumber * secondnumber}"); break;
                case "*": Console.WriteLine($" {firstnumber} * {secondnumber} = {firstnumber * secondnumber}"); break;
                case "5": Console.WriteLine($" {firstnumber} % {secondnumber} = {firstnumber % secondnumber}"); break;
                case "%": Console.WriteLine($" {firstnumber} % {secondnumber} = {firstnumber % secondnumber}"); break;
                default: Console.WriteLine($"Hurmatli mijoz siz kiritgan {amal} amali mavjud emas. Mavjud bo`lgan amallardan birini tanlang:  1-(+), 2-(-), 3-(/), 4-(*), 5-(%)"); break;
            }


            Main(args);
        }
    }
}
