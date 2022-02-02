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
            List<double> vs = new List<double>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                vs.Add(rnd.NextDouble() * 100);
            }
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
