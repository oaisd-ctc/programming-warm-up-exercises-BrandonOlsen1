using System;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the Main method to test your functions.
            Console.WriteLine("Add");
            Console.WriteLine(Add(2 , 4));

            Console.WriteLine("Is Even");
            Console.WriteLine(IsEven(3));

            Console.WriteLine("Max Of Three");
            Console.WriteLine(MaxOfThree(3, 5, 6));

            Console.WriteLine("String Length");
            Console.WriteLine(StringLength("Hello"));

            Console.WriteLine("Starts Hello");
            Console.WriteLine(StartsHello("HI"));

            Console.WriteLine("Reverse String");
            Console.WriteLine(ReverseString("YOOO"));

            Console.WriteLine("Factorial");
            Console.WriteLine(Factorial(5));

            Console.WriteLine("Is Prime");
            Console.WriteLine(IsPrime(20));

            Console.WriteLine("FIB");
            Console.WriteLine(Fibonacci(15));

            Console.WriteLine("Largest In Array");
            int [] number = {5, 6, 9, 12, 22, 21, 13};   
            Console.WriteLine(LargestInArray(number));

            Console.WriteLine("Palindrome");
            Console.WriteLine(IsPalindrome("noo"));

            Console.WriteLine("ArraySum");
            int [] sumss = {2, 5, 6, 6, 19, 7, 12};
            Console.WriteLine(ArraySum(sumss));

            Console.WriteLine("Number Of Letters");
            String st = "HEEEEEEY";
             char ch = 'E';
            Console.WriteLine(CharCount(st, ch));

            Console.WriteLine("ConcatenateStrings");
            string String1 = "Hello";
            string String2 = "Everyone";
            Console.WriteLine(ConcatenateStrings(String1, String2));

            Console.WriteLine("SwapEnds");
            String Word = "Baller";
            Console.WriteLine(SwapEnds(Word));



        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
            int answer = a + b;
            return answer;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            if(number % 2 == 0)
            {
               return true;
            }
            return false;
        }

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {
            // HINT: You might want to use Math.Max function.
            // TODO: Implement this method.
            int MaxNumber = Math.Max(a, Math.Max(b,c));
            return MaxNumber;
        }

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
            return s.Length;
            // TODO: Implement this method.
           
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            // HINT: Use the string method "StartsWith".
            // TODO: Implement this method.
            if(s == "Hello")
            {
            return true;
            }
            return false;
        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            // TODO: Reverse the charArray.
            return new string(charArray);
        }

        
        public static int Factorial(int n)
        {
           if (n == 0) return 1;
            

            for(int i = n-1; i > 0; i--)
            {
               n *= i;
            }
            return n;
            // TODO: Calculate the factorial.
            ;
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {
            if (number <= 1 || number == 0) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            // TODO: Return the correct boolean value.
            return true;
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;
            if (n <= 1) return n;
            for (int i =2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }
                return result;



            // TODO: Calculate the nth Fibonacci number.
            
        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {
            int answe = 0;
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                 answe = numbers.Max();
                // TODO: Find the largest number in the array.
            }
            
            return answe;
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            char[] cArray = s.ToCharArray();
            string reverse = String.Empty;
            for(int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            if (reverse == s)
            {
                return true;
            }
            // TODO: Determine if the string is a palindrome.
            return false;
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = numbers.Sum();
            // TODO: Calculate the sum of the array's elements.
            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            int count = 0;
            char [] cArray = s.ToCharArray();
            for (int i = 0; i <= cArray.Length -1; i++)
            {
                if(cArray[i] == c)
                {
                    count++;
                }   
            }
            // TODO: Count how many times character c appears in string s.
            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            
            // TODO: Concatenate the two strings with a space in between.
            return str1 + " " +  str2;
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) return s;
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            string neword = String.Empty;


            neword += lastChar;
            

            for(int i = 0; i < s.Length - 1 ; i++)
            {
                if(s[i] != s[0] && s[i] != s.Length -1)
                {
                    neword += s[i];
                }
            }
            neword += firstChar;
            // TODO: Swap the first and last characters and return the modified string.
            return neword;
        }
    }
}
