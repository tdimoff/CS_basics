﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphabetical_indices
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)('a' + i);
            }
            string word = Console.ReadLine().ToLower();
            foreach (char letter in word)
            {
                for (int index = 0; index < alphabet.Length; index++)
                {
                    if (letter == alphabet[index])
                    {
                        Console.WriteLine("{1}", letter, index);
                    }
                }
            }
        }
    }
}
