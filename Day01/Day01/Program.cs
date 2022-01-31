using System;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 7;
            int sum = Add(num1, num2);//pass by value
            PrintMessage();
            string msg = GetMessage();
            PrintMessage(msg);
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
        private static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static int Add(int n1, int n2)
        {
            int result = n1 + n2;
            return result;
        }

    }

}
