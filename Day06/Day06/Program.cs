using System;
using System.Collections.Generic;

namespace Day06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 06!");
            List<int> list = new List<int>() { 5, 3, 13, 7, 42 };
            int searchNum = 13;
            int foundIndex = LinearSearch(list, searchNum);
            if(foundIndex >= 0)
                Console.WriteLine($"Found {searchNum} at index {foundIndex}");
            else
                Console.WriteLine($"Did not find {searchNum}");

            searchNum = 100;
            foundIndex = LinearSearch(list, searchNum);
            if (foundIndex >= 0)
                Console.WriteLine($"Found {searchNum} at index {foundIndex}");
            else
                Console.WriteLine($"Did not find {searchNum}");
        }

        static int LinearSearch(List<int> nums, int searchItem)
        {
            int index = -1;//-1 means we did not find the item
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == searchItem)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
