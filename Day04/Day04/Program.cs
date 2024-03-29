﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileIO();
            string filePath = "steev.txt";
            WriteData(filePath);
            ReadData(filePath);
            WriteJson(filePath);

            //implement factorial
            //N! = N * (N-1) * (N-2)...1
            //5! = 5 * 4 * 3 * 2 * 1
            //5! = 5 * 4!
            long result = Fac(5);
            Console.WriteLine($"5! = {result}");
            Bats(0);
            Console.ReadKey();
            Console.WriteLine("Hello World!");
            MakeItSO(200);
            for (int i = 0; i < 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void FileIO()
        {
            string filePath = "steev.txt";
            char delimiter = '?';
            //1. OPEN THE FILE
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                //2. WRITE THE FILE
                sw.Write("Batman!");
                sw.Write(delimiter);
                sw.Write(5);
                sw.Write(delimiter);
                sw.Write(13.7);
                sw.Write(delimiter);
                sw.Write(true);
            }//3. CLOSE THE FILE


            //reading the CSV
            Console.WriteLine("---------READING CSV-----------");
            //LONG WAY
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(delimiter);
                    foreach (var item in data)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            //QUICK WAY
            string fileData = File.ReadAllText(filePath);//all 3 steps: open, read, close
            string[] fData = fileData.Split(delimiter);
            foreach (var item in fData)
                Console.WriteLine(item);

            Dictionary<string, float> menu = new Dictionary<string, float>()
            {
                {"waffles", 5.99F },
                {"French Toast", 8.99F },
                {"Omelet", 10.99F },
                {"bacon", 4.99F },
                {"cinnamon rolls", 3.99F }
            };

            //change the extension to .json
            filePath = Path.ChangeExtension(filePath, ".json");
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    JsonSerializer ser = new JsonSerializer();
                    ser.Formatting = Formatting.Indented;
                    ser.Serialize(jtw, menu);
                }
            }

            if (File.Exists(filePath))
            {
                Console.WriteLine("---------Today's Menu----------");
                try
                {
                    string jsonData = File.ReadAllText(filePath);
                    Dictionary<string, float> todaysMenu = JsonConvert.DeserializeObject<Dictionary<string, float>>(jsonData);
                    foreach (var item in todaysMenu)
                    {
                        Console.WriteLine($"{item.Value,7:C2} {item.Key}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Not a menu file.");
                }
            }
        }

        static void WriteJson(string fileName)
        {
            fileName = Path.ChangeExtension(fileName, ".json");
            List<int> numbers = new List<int>() { 5, 7, 9, 13, 17, 42, 1 };
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    serializer.Serialize(jtw, numbers);
                }
            }
        }

        static void WriteData(string fileName)
        {
            char delimiter = '>';
            List<int> numbers = new List<int>() { 5, 7, 9, 13, 17, 42, 1 };
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                bool isFirst = true;
                foreach (var number in numbers)
                {
                    if (!isFirst)
                        sw.Write(delimiter);
                    sw.Write(number);
                    isFirst = false;
                }
            }
        }

        static void ReadData(string filePath)
        {
            Console.WriteLine("---------READData----------");
            char delimiter = '>';
            if (File.Exists(filePath))
            {
                string fText = File.ReadAllText(filePath);
                string[] fData = fText.Split(delimiter);
                List<int> nums = new List<int>();
                foreach (var item in fData)
                {
                    if (int.TryParse(item, out int num))
                        nums.Add(num);
                }
                foreach (var item in nums)
                    Console.WriteLine(item);
            }
            else
                Console.WriteLine($"The {filePath} does not exists.");
        }

        static void Bats(int i)
        {
            if (i < 100)
            {
                Console.Write((char)78);
                Console.Write((char)65);
                Console.Write(' ');
                Bats(++i);
            }
            else
                Console.WriteLine("Batman!");
        }

        static long Fac(int N)
        {
            if (N > 1)
            {
                long result = N * Fac(N - 1);
                return result;
            }
            return 1;
        }
        static void MakeItSO(int N)
        {
            //EXIT CONDITION to stop
            if (N < 255)
            {
                Console.WriteLine($"{N} Engage!");
                MakeItSO(N + 1);
            }
            Console.WriteLine($"{N} Power down!");
        }
    }
}
