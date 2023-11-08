using System;

namespace palindromo
{
    class Program
    {
        public static bool Palindromo()
        {
            string word = Console.ReadLine();

            for (int i = word.Length; i > 0; i--)
            {
                Console.WriteLine(word[i - 1]);
                Console.WriteLine(word[word.Length - i]);

                if (word[i - 1] == word[word.Length - i])
                    Console.WriteLine("lendo...");
                else
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            if (Palindromo())
                Console.WriteLine("sim");
            else
                Console.WriteLine("não");
        }
    }
}
