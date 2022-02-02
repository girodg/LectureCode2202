using System;
using System.Collections.Generic;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayChallenge();
            List<int> nums = new List<int>(10);
            nums.Add(2);
            nums.Add(4);
            nums.Add(5);
            nums.Add(6);
            nums.Add(7);
            nums.Add(2);
            nums.Add(4);
            nums.Add(5);
            nums.Add(6);
            nums.Add(5);
            nums.Add(6);//count = 11, capacity = 20
            //Console.WriteLine(nums[11]);//index range is 0 - (Count-1)
            Info(nums);
            Print(nums);
            ListChallenge();
        }

        private static void Print(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }


        static void Info(List<int> numbers)
        {
            //Count - # of items added
            //Capacity - size of the internal array
            Console.WriteLine($"Count: {numbers.Count}\tCapacity: {numbers.Capacity}");
        }

        static void ListChallenge()
        {
            List<double> grades = new List<double>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                grades.Add(rnd.NextDouble() * 100);
            }
            PrintGrades(grades);
        }

        private static void PrintGrades(List<double> grades)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------GRADES----------");
            Console.ResetColor();
            foreach (var grade in grades)
            {
                if (grade < 59.5) Console.ForegroundColor = ConsoleColor.Red;
                else if (grade < 69.5) Console.ForegroundColor = ConsoleColor.DarkYellow;
                else if (grade < 79.5) Console.ForegroundColor = ConsoleColor.Yellow;
                else if (grade < 89.5) Console.ForegroundColor = ConsoleColor.DarkGreen;
                else Console.ForegroundColor = ConsoleColor.Green;
                //OR, use a ternary
                Console.ForegroundColor = (grade < 59.5) ? ConsoleColor.Red :
                                          (grade < 69.5) ? ConsoleColor.DarkYellow :
                                          (grade < 79.5) ? ConsoleColor.Yellow :
                                          (grade < 89.5) ? ConsoleColor.DarkGreen : 
                                          ConsoleColor.Green;

                Console.WriteLine($"{grade,7:N2}");
            }
            Console.ResetColor();
        }

        static void ArrayChallenge()
        {
            int[] nums = new int[10];
            Random random = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next();
            }
            foreach (var number in nums)
            {
                Console.WriteLine(number);
            }
        }
    }
}
