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
            Console.WriteLine(Add(2, 4));

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
            int[] number = { 5, 6, 9, 12, 22, 21, 13 };
            Console.WriteLine(LargestInArray(number));

            Console.WriteLine("Palindrome");
            Console.WriteLine(IsPalindrome("noo"));

            Console.WriteLine("ArraySum");
            int[] sumss = { 2, 5, 6, 6, 19, 7, 12 };
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
            string Word = "Baller";
            Console.WriteLine(SwapEnds(Word));
        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
            return s.Length;
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            if (s == "Hello")
            {
                return true;
            }
            return false;
            // Additional Answers:
            return s == "Hello";
            return s.ToLower().StartsWith("hello");
        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }
            return n;
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {
            if (number <= 1 || number == 0) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;
            if (n <= 1) return n;
            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }
            return result;
        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {
            int answe = 0;
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                answe = numbers.Max();
            }

            return answe;
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            char[] cArray = s.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return string.Equals(reverse, s);
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            return numbers.Sum();
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            int count = 0;
            char[] cArray = s.ToCharArray();
            for (int i = 0; i <= cArray.Length - 1; i++)
            {
                if (cArray[i] == c)
                {
                    count++;
                }
            }
            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            return str1 + " " + str2;
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) return s;
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            string neword = String.Empty;

            neword += lastChar;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] != s[0] && s[i] != s.Length - 1)
                {
                    neword += s[i];
                }
            }
            neword += firstChar;
            return neword;
        }
    }
}
