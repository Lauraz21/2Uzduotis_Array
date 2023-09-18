using System.Reflection.Metadata.Ecma335;

namespace _2Uzduotis_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Katinas";
            GetCharArray(word);

        }
        public static void GetCharArray(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }
        }
    }
}