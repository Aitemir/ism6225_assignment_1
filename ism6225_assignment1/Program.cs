﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ism6225_assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);

            int n2 = 5;
            printSeries(n2);

            int n3 = 5;
            printTriangle(n3);

            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine("The number of jewels is  " + r4);

            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            //displayArray(r5);

            solvePuzzle();
        }

        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                var arrList = new List<int>(); // initialize array to store the values of self dividing numbers
                for (int i = x; i <= y; i++) // to iterate through each and use isSelfDividing method
                                             //and store the values in the arrList
                {
                    if (isSelfDividing(i))
                        arrList.Add(i);
                }
                int[] arrResult = arrList.ToArray(); // array created to store the results 

                Console.WriteLine("The range of self dividing numbers:" +
                    "[{0}]", string.Join(", ", arrResult)); // printing output
                Console.WriteLine("\n");


            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }


        // the isSelfDividing method is created to check if the value is self dividing
        private static bool isSelfDividing(int x) {

            int input = x;

            while (input > 1)
            {
                int remainder = input % 10;
                if (remainder == 0 || x % remainder != 0) {
                    return false;
                }

                input = input / 10;
            }

            return true;
        }

        public static void printSeries(int n)
        {
            try
            {
                int number = n;
                int x, y;
                int count = 0;


                for (x = 1; x <= number; x++) // the for loop iterates through the values to print them until the N terms

                {
                    for (y = 1; y <= x; y++) // this for loop iterates through each value 
                                             //and prints them based off the counter

                        if (count < number)
                        {
                            Console.Write(x);

                            // for loop to get rid of the last comma
                            if (count < n - 1) { // this particular if statement adds comma after each number
                                Console.Write(", ");
                            }

                            count++;
                        }
                }
                Console.WriteLine("\n");
            }

            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n)
        {
            try
            {
                // the for loop iterates in order to print blank strings as well as stars for the triangle
                for (int i = n; i >= 1; i--)
                {
                    for (int x = n; x > i; x--) // iteration prints the required number of blanks to create the triangle
                    {
                        Console.Write("  ");
                    }
                    for (int y = 1; y < 2 * i; y++) // iteration prints the required number of stars to create the triangle
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();

                }    
            }      

            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                int intCounter = 0;

                foreach (int i in S) // the foreach loop iterates through the stones array to identify the jewels
                {
                    foreach (int x in J) // the foreach loop increments the counter which represents number of jewels
                    {
                        if (i == x)
                            intCounter++;
                    }
                }

                return intCounter; // the method returns the counter - number of jewels found in the stones array
            }

            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;
        }

        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

            return null; // return the actual array
        }

        public static void solvePuzzle()
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
    }

    //



    //
}
