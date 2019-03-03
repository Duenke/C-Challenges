﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPracticeP1
{
    class Program : Util
    {
        static void Main(string[] args)
        {
            /*
            Given a string, check to see if it is a palindrome. Return true or false.

            Constraints:
            - The string will be ALL UPPERCASE.
            - The string will contain no special characters or spaces.
            - The string will not be NULL.
            
            In-puts / Out-puts:
            - "RACECAR" / True
            - "110011" / True
            - "BALL" / False

            Logical Approach:
            - Check the first and last characters to see if they are the same.
            - Repeat going in to the middle until the string is completely checked.
            - Return true or false.
            */

            Console.WriteLine("CheckPalindrome");
            Console.WriteLine("Given a string, check to see if it is a palindrome.\n");

            string s = "RACECAR";
            string t = "110011";
            string u = "BALL";

            Console.WriteLine($"{s} is a palindrome: {CheckPalindrome(s)}");
            Console.WriteLine($"{t} is a palindrome: {CheckPalindrome(t)}");
            Console.WriteLine($"{u} is a palindrome: {CheckPalindrome(u)}");

            Console.WriteLine("-----------------------------");

            /*
            Given an integer array, find the smallest integer in the array.

            Constraints:
            - The array will not be empty.
            - The array may not be in any order.
            - The array will not be all 0s.
            
            In-puts / Out-puts:
            - int[] a = new int[] { 99, 2, 4 } / 2
            - int[] b = new int[] { 11, 255, 34, 77, 8 } / 8
            - int[] c = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } / 1

            Logical Approach:
            - Declare a variable for the smallest value called min.
            - Check each element in the array for the values.
            - If the value is smaller than the min variable, assign it to min.
            */

            Console.WriteLine("GetMin");
            Console.WriteLine("Given an integer array, find the smallest integer in the array.\n");

            int[] a = new int[] { 99, 2, 4 };
            int[] b = new int[] { 11, 255, 34, 77, 8 };
            int[] c = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine($"The smallest value in int[] a is: {GetMin(a)}.");
            Console.WriteLine($"The smallest value in int[] b is: {GetMin(b)}.");
            Console.WriteLine($"The smallest value in int[] c is: {GetMin(c)}.");

            Console.WriteLine("-----------------------------");

            /*
            Given an integer array, find the largest integer in the array.

            Constraints:
            - The array will not be empty.
            - The array may not be in any order.
            - The array will not be all 0s.
            
            In-puts / Out-puts:
            - int[] a = new int[] { 99, 2, 4 } / 99
            - int[] b = new int[] { 11, 255, 34, 77, 8 } / 255
            - int[] c = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } / 10

            Logical Approach:
            - Declare a variable for the largest value called max.
            - Check each element in the array for the values.
            - If the value is larger than the max variable, assign it to max.
            */

            Console.WriteLine("GetMax");
            Console.WriteLine("Given an integer array, find the largest integer in the array.\n");

            a = new int[] { 99, 2, 4 };
            b = new int[] { 11, 255, 34, 77, 8 };
            c = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine($"The largest value in int[] a is: {GetMax(a)}.");
            Console.WriteLine($"The largest value in int[] b is: {GetMax(b)}.");
            Console.WriteLine($"The largest value in int[] c is: {GetMax(c)}.");

            Console.ReadKey();
        }
    }
}