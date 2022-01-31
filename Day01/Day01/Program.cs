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
            TimeStamp(ref msg);
            PrintMessage(msg);

            string age = "steev";
            try
            {
                int myAge = int.Parse(age);
            }
            catch (Exception ex)
            {
                Console.Write("STEEV! NO.\n");
            }
            age = "12";
            bool isNumber = int.TryParse(age, out int goodAge);


            Factor(ref num1, 3);
            Factor(ref num2, 3);
            //$ - interpolated string
            Console.WriteLine($"factored: {num1}");

            int grade = 59;
            int curve = 5;
            CurveGrade(grade, curve, out int newGR);

            MyFavoriteNumber(out int myFave);
            Console.WriteLine($"Your favorite number was {myFave}? weird.");
        }

        static void MyFavoriteNumber(out int fave)
        {
            Console.Write("What is your favorite number? ");
            string numStr = Console.ReadLine();
            if (!int.TryParse(numStr, out fave))
            {
                Console.WriteLine("Please enter a number next time. Steev.");
            }
        }
        static void CurveGrade(int grade, int curve, out int newGrade)
        {
            newGrade = grade + curve;
            if (newGrade > 100) newGrade = 100;
        }

        private static void TimeStamp(ref string original)
        {
            //original = DateTime.Now + ": " + original;
            //OR build the string with interpolation
            original = $"{DateTime.Now}: {original}";
        }

        static void Factor(ref int num, int factor)
        {
            num *= factor;
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
