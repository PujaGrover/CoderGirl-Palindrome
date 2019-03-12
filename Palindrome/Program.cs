using System;

namespace Palindrome
{
    public static class Program
    {
        // TODO: Create a method that recognizes palindromes.
        public static void Main()
        {
            
            Console.WriteLine("Please enter a palindrome:");
            string inputPalindrome = Console.ReadLine().Trim().ToLower();
            bool checkPalindrome = IsPalindrome(inputPalindrome);
            Console.WriteLine($"Your input is {checkPalindrome}");
            Console.ReadLine();
        }
        public static bool IsPalindrome( string userInput)
        {
            // The name of the method you create should be IsPalindrome
            // The method should take a string as the input.
            // The method should return a bool - true if the input is a palindrome and false if it is not.
            userInput = userInput.ToLower();
            bool result = true;
            for ( int i = 0; i < userInput.Length; i++)
            {
                int user_Input_String_Length = userInput.Length;
                //Console.WriteLine(user_Input_String_Length);
                //Console.ReadLine();
                if ( userInput[i] != userInput[user_Input_String_Length - 1 -i])
                {
                    //Console.WriteLine(userInput[i]);
                    //Console.ReadLine();
                    result = false;
                }

            }
            return result;
        }        
        
    }
}
