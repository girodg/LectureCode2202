using Day06CL;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Day06
{

    internal class Program
    {
        Dictionary<int, ulong> _fib = new Dictionary<int, ulong>();

        static void Main(string[] args)
        {
            Human.NumberOfHumans = 0;
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


            Program myProg = new Program();
            Stopwatch sw = new Stopwatch();
            long ms;
            ulong result;
            for (int i = 0; i <= 145; i++)
            {
                myProg._fib = new Dictionary<int, ulong>();
                myProg._fib.Add(0, 0);
                myProg._fib[1] = 1;
                sw.Restart();
                result = myProg.Fib2(i);
                sw.Stop();
                ms = sw.ElapsedMilliseconds;
                Console.Write($"Fib2({i}) = {result}");
                Console.CursorLeft = 45;
                Console.WriteLine($"{ms} ms");
            }
        }
        #region Fibonaccis

        static ulong Fib(int N)
        {
            if (N <= 0) return 0;
            if (N == 1) return 1;
            ulong result = Fib(N - 1) + Fib(N - 2);
            return result;
        }

        ulong Fib2(int N)
        {
            if (_fib.TryGetValue(N, out ulong result))
                return result;

            result = Fib2(N - 1) + Fib2(N - 2);
            _fib[N] = result;
            return result;
        } 
        #endregion

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
