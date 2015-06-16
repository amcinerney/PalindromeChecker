using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            string input = p.GetWord();
            p.TestIfPalindrome(input);
            p.SimplerCheck(input);
        }

        public string GetWord()
        {
            Console.WriteLine("Enter a word :");
            string input = Console.ReadLine();
            return input;
        }

        public void TestIfPalindrome(string input)
        {
            input = input.ToLower();
            int wordLength = input.Length - 1 ;
            int i = 0;
            char[] letterArray = input.ToCharArray();

            do
            {
                if (letterArray[i] == letterArray[wordLength])
                {
                    i++;
                    wordLength--;
                }
                else
                {
                    Console.WriteLine("Word is not a palindrome");
                    Console.ReadKey();
                    return;
                }
            }
            while (i <= wordLength);

            Console.WriteLine("Word is a palindrome");
            Console.ReadKey();
        }

        public void SimplerCheck(string input)
        {

            if (input.SequenceEqual(input.Reverse()))
            {
                Console.WriteLine("Word is a palindrome");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Word is not a palindrome");
                Console.ReadKey();
            }
        }
    }
}
