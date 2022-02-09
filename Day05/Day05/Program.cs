using System;

namespace Day05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] numbers = new float[] { 1, 2, 3, 4, 5, 6 };
            Swap(numbers, 2, 3);
            Print(numbers);

            string s2 = "bats", s1 = "Batmen";
            int compareResult = string.Compare(s1, s2, true);
            //0 EQUALS
            //-1 LESS THAN
            //1 GREATER THAN
            Console.WriteLine();
            if (compareResult == 0) Console.WriteLine($"{s1} EQUALS {s2}");
            else if(compareResult == -1) Console.WriteLine($"{s1} LESS THAN {s2}");
            else if (compareResult == 1) Console.WriteLine($"{s1} GREATER THAN {s2}");
        }

        private static void Print(float[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
            }
        }

        private static void Swap(float[] nums, int index1, int index2)
        {
            float temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = temp;
        }
    }
}
