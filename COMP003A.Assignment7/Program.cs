/*
 * Author: Logan Jones
 * Course: Comp-003A
 * Purpose: Weekloy assignment on Basic Data Structures
 */


using System;
using System.ComponentModel;

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            SectionSeparator("Array - CharacterCounter Section");

            Console.WriteLine("Please select a letter ");
            char charInput= Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter a word ");
            string word = Console.ReadLine();
            int finalCount= CharacterCounter(charInput, word);
            Console.WriteLine($"There are {finalCount} of the letter {char.ToUpper(charInput)} in this word");// I finally learned how to use a return value)

            SectionSeparator("Array - IsPalindrome Section");
            Console.WriteLine("Please enter a word to check if it is a palindrome! ");
            string palindrome = Console.ReadLine();
           bool palindromeCheck= IsPalindrome(palindrome);
            Console.WriteLine($"Is the word {palindrome} a palindrome: {palindromeCheck}");
            

            SectionSeparator("AddSection");
            List<string> names = new List<string>();
            char userInput = default;
            Console.WriteLine($"Please enter a name:");
            do
            {

                names.Add(Console.ReadLine());

                Console.WriteLine($"Press any key to add more or (e) to exit");
                userInput = Convert.ToChar(Console.ReadLine());
                Console.WriteLine($"\n");


            }
            while (userInput != 'e');
            

            SectionSeparator("List - Traversal Section");
            TraverseList(names);
            SectionSeparator("List - Reverse Traversal Section");
            TraverseListReverse(names);



        }
        static void SectionSeparator(string topic) {
            Console.WriteLine("".PadRight(50, '*') + $"\n\t{topic}" + "\n".PadRight(51, '*')) ;
        }
        static int CharacterCounter(char charInput, string word)
        {
            word = word.ToLower(); // changes the word to lower case
            charInput = char.ToLower(charInput);// changes the chosen Character into lowercase
            ///<summary> Makes both the word and char match for when the system checks for matching charcaters</summary>
            int charCount = 0;
            foreach(char ch in word)
            {
                if (charInput == ch)
                {
                    charCount++;
                }
            }
            return charCount;
            ///<summary> Since strings are collections of char, set a temp var, and if it equels your chosen letter, add to the count. Return the final count</summary>
            

        }
        static bool IsPalindrome(string word)
        {
            word=word.ToLower();
            int length = word.Length;
            for (int i = 0; i <length/2; i++)// i starts at the beginning of the word and travels down it
            {
                
                if (word[i] != word[length - 1 - i]) //compares i to the character at the end until they meet in the middle
                {
                    return false; //if at any point the letters don't match, it is false5
                }
             }
            return true;
        }
        static void TraverseList(List<string> list)
        {
            foreach(string word in list)
            {
                Console.WriteLine(word);
            }
        } /// <summary>
        /// Takes the finished list and writes it as is.
        /// </summary>
        /// <param name="list"></param>
        static void TraverseListReverse(List<string> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            { Console.WriteLine(list[i]); }
        }///<summary>
        /// For loop that begins with the last listed item and works its way back to the begining
        ///</summary>
       
    }
}
