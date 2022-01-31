using System;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Add(5, 7);
            PrintMessage();
            string msg = GetMessage();
        }

        private static string GetMessage()
        {
            string message;
            Console.Write("Please enter a message: ");
            message = Console.ReadLine();
            return message;
        }

        private static void PrintMessage()
        {
            Console.WriteLine("Hello Gotham. I am the hero you need.");
        }

        public static int Add(int n1, int n2)
        {
            int result = n1 + n2;
            return result;
        }

    }

}
