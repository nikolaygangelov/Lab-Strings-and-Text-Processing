using System;

namespace _4._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            string replacedText = string.Empty;
            for (int i = 0; i < banWords.Length; i++)
            {
                string asterix = string.Empty;
                for (int j = 0; j < banWords[i].Length; j++)
                {
                    asterix += '*';
                }
                replacedText = text.Replace(banWords[i], asterix);
                text = replacedText;
            }
            Console.WriteLine(replacedText);
        }
    }
}
