

namespace ConsoleApp1
{
    using System;
    using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            string[] textArray = Console.ReadLine().Split();
            foreach (string word in textArray)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
        }
    }
}
