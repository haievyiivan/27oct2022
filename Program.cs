using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27oct2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            //Exercise1();

            // Exercise 3
            //Exercise3();

            // Exercise 4
            //Exercise4();

            Console.ReadKey();

        }

        public static void Exercise1()
        {
            // Get num
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());

            // Convert num to string
            string sNum = num.ToString();

            // Add '0' 
            sNum += "0";

            // Display num in the console
            Console.WriteLine($"{num} * 10 = {sNum}");

            // if u want funcion tu return num
            // change void to int
            // return int.Parse(sNum);
        }

        public static void Exercise3()
        {
            // Get num
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());

            // Add 0.5 to num
            double answer = num + 0.5;

            // Display answer in the console
            Console.WriteLine($"{num} + 0.5 = {answer}");

            // if u want funcion tu return answer
            // change void to double
            // return answer;
        }

        public static void Exercise4()
        {
            // Get num
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());

            int answer;

            if (num <= 5000)
            {
                // Count how much you need to add
                answer = 5000 - num;

                // Display answer in the console
                Console.WriteLine($"To get 5000 you need to add {answer} to your number({num})");
            }
            else
            {
                // Count how much you need to subtract
                answer = 5000 - num;

                // Display answer in the console
                Console.WriteLine($"To get 5000 you need to subtract {Math.Abs(answer)} from your number({num})");
            }

            // if u want funcion tu return answer
            // change void to int
            // return answer;
        }
    }
}
