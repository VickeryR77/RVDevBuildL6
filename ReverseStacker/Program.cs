using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Compression;

namespace ReverseStacker
{
    class Program
    {

        public static string Stack(string entry) 
        {
            Stack<char> st = new Stack<char>();

            string reverse = "";
            char letter;

            for (int i = 0; i < entry.Length; i++)
            {
                letter = entry[i];
                st.Push(letter);
            }

            for (int j = 0; j < entry.Length; j++)
            {
                reverse+=st.Pop();
            }

            return reverse;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Write a word or sentence you'd like to see reversed.");
            string word = Console.ReadLine();
            
            string reversed = Stack(word);

            Console.WriteLine(reversed);
            
        }

    }
            
}
