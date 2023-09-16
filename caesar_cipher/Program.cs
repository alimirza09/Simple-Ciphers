using System;
using System.Collections.Generic;
namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            Console.WriteLine("Enter the Sentence which need to to encrypted: ");
            string sentence = Console.ReadLine();
            sentence = sentence.ToUpper();
            Console.WriteLine("Number of shifts you want to try");
            int times = Convert.ToInt32(Console.ReadLine());


            List<char> encrypted = new List<char>();
            int j = 0;
            char i = sentence[j];
            int f = 1;
            while (f < times)
            {

                while (sentence.Length > j)
                {
                    i = sentence[j];
                    if (alphabet.Contains(i))
                    {
                        int index = Array.IndexOf(alphabet, i);
                        index = index + f;
                        while(index >= 26)    
                        {    
                           index = index - 26;
                        }
                        encrypted.Add(alphabet[index]);
                    }

                    else
                    {
                        encrypted.Add(i);
                    }
                    j++;
                }
                if (sentence.Length == j)
                {
                    
                    string Real_Encryption = string.Join("", encrypted);
                    Console.WriteLine(Real_Encryption);
                    Real_Encryption = "";
                    encrypted.Clear();
                    f++;
                    j = 0;
                }
            }
        }
    }
}