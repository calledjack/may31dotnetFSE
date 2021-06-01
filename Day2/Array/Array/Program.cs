using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[length];
            int counter = 0;
            string strChoice = "";
            do
            {
                strChoice = Console.ReadLine();
                words[counter] = strChoice;
                counter++;
            } while (strChoice != "No" && counter <= words.Length);
            Console.WriteLine("You have entered the following");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            }
    }
}
