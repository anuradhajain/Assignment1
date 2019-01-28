using System;
using System.Linq;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // value of x and y: the range
            int x = 5; int y = 15;

            // Calling the method that finds all prime numbers in a given range. x and y are sent as arguements to the called function 
            Console.WriteLine("The prime numbers are: ");
            printPrimeNumbers(x, y);
            Console.WriteLine("\n");

            // value of n1
            int n1 = 5;

            // calling the method to get series result. n1 is passed as an arguement
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);
            Console.WriteLine("\n");

            // value of n2: decimal number
            long n2 = 15;

            // calling the method to convert from decimal to binary. n2 is passed as an arguement to the called function
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);
            Console.WriteLine("\n");

            // value of n3: binary number
            long n3 = 1111;

            // calling method to convert from binary to decimal. sending n3 as argument to the called function
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);
            Console.WriteLine("\n");

            // value of n4: rows in the pattern
            int n4 = 5;

            // calling the method to print the star pattern. n is passed as an argument to the called function
            printTriangle(n4);
                
            // initializing array arr
            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };

            // calling the function that computes frequency of numbers in array arr. arr is sent as argument to the called function
            computeFrequency(arr);

            // Displaying exit message and taking user input to exit application
            Console.WriteLine("\nPress any key to exit ");
            Console.ReadKey(true);

        } // end of main

        // Method for printing prime numbers between range x and y. X and Y are sent as parameters from the called method to this method. Nothing is returned back to called method
        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                // loop to run from x to y
                for (int i = x; i <= y; i++)
                {
                    // Counter to count the number of factors of j
                    int count = 0;

                    // loop to run from 1 to number itself that is i
                    for (int j = 1; j <= i; j++)
                    {
                        // Check if modulus of i % j is equal to 0 or not. If yes, increase count by one  
                        if (i % j == 0)
                        {
                            count++;
                        }

                    } // end of for loop i

                    // Using the fact that prime numbers have only two factors, to determine if a number is prime or not
                    // If the count is 2, print the number
                    if (count == 2)
                    {
                        Console.Write(i + " ");
                    } // end of if

                } // end of for loop i 
            } // end of try

            // This block is executed when error occurs in the try block else not
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            } // end of catch

        }  // end of Printprimenumber method

        // this method calculates the result of a series till n numbers. n is taken as an argument from the calling function and the result is returned to the calling function
        public static double getSeriesResult(int n)
        {
            double x = 0;
            try
            {
                // for loop to calculate the result of the series till n
                for (int i =1; i <= n; i++)
                {
                    // using the modules of 2 equal equal 0 logic to determine if i is even or odd and then assigning + or - sign before it
                    if (i % 2 == 0)
                    {
                        x = x - factorial(i) / (i + 1);
                    } // end of if(i % 2 == 0)
                    else               
                    {
                        x = x + factorial(i) / (i + 1);
                    
                    } // end of else                

                } // end of for loop i
            } // end of try

            // This block is executed when error occurs in the try block else not
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            } // end of catch

            // returning the result of the series to the calling function rounded upto 3 decimal places
            return Math.Round(x, 3);

        } // end of method getSeriesResult(int n)

        // This method finds the factorial of n numbers. n is taken as an argument from the calling function and factorial is returned to the calling function
        public static double factorial(int n)
        {
            double fact = 1;
            try
            {
                // for loop to calculate the factorial of n numbers
                for (int i  = 1; i <= n; i++)
                {
                    fact = fact * i;
                } // end of for loop i
            } // end of try

            // This block is executed when error occurs in the try block else not
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            } // end of catch

            // return the calculated factorial value to the calling function
            return fact;

        } // end of factorial(int n)

        // this method converts decimal to binary and returns the result to the calling function
        public static long decimalToBinary(long n)
        {
            // initializing result variable s to 0
            long s = 0;
            // start of try block
            try
            {
                // setting counter to 0
                int count = 0;
                // while loop to run till n > 0
                while (n > 0)
                {
                    long mod = n % 2; // getting the modulus of 2
                    long prod = (long)Math.Pow(10, count) * mod; // multiplying the last character to 10^0, 10^1, respectively for each iteration. hence the counter 
                    s = s + prod; // adding all the products and storing the sum in s

                    count++; // incrementing the counter
                    n = n / 2; // dividing n by 2
                } // end of while
            } // end of try

            // This block is executed when error occurs in the try block else not
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            } // end of catch
            
            // return the result to the calling function
            return s;
        }


        // this method converts binary to decimal and returns the result to the calling function
        public static long binaryToDecimal(long n)
        {
            // initializing the result variable s to 0
            long s = 0;
            // start of try block
            try
            {
                // setting counter to 0
                int count = 0;
                // while loop to run till n > 0. So runs as many times as there are characters in n
                while(n > 0)
                {                    
                    long charAtLastPosition = n % 10; // getting the last character of the number n
                    long prod = (long)Math.Pow(2, count) * charAtLastPosition; // multiplying the last character to 2^0, 2^1, respectively for each iteration. hence the counter 
                    s = s + prod; // adding all the products and storing the sum in s
                    n = n / 10; // dropping the last character by dividing n by 10
                    count++; // incrementing the counter
                } // end of while 
            } // end of try

            // This block is executed when error occurs in the try block else not
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            } // end of catch

            // returning the result to the calling function
            return s;
        }


        // method to print star pattern. Number of rows in the pattern is sent from the called method as the argument. Nothing is returned to the called method
        public static void printTriangle(int n)
        {
            try
            {
                // for loop of i till n, rows in a matrix
                for (int i = 1; i <= n; i++)
                {
                    // for loop of j till n, columns in a matrix
                    for (int j = 1; j <= n; j++)
                    {
                        // the whole patern is divided vertcally into two pattern, one 4*4 and other 4*3 
                        // considering the 4*4 matrix. using their position to find a condition to print or not print the star
                        if (i + j <= n)
                        {
                            Console.Write(" ");

                        } // end of if
                        else
                        {
                            Console.Write("*");
                        } // end of else

                    } // end of for loop j

                    // considering the second 4*3 matrix and using position number to find a condition to print a star or not
                    for (int k = 1; k < i; k++)
                    {
                        Console.Write("*");

                    } // end of for loop k

                    // printing new line in the pattern as we increment the rows or i
                    Console.WriteLine("\n");

                } //end of for loop i
            } // end of try

            // This block is executed when error occurs in the try block else not
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            } // end of catch

        } // end of method printTriangle(int n)

        // method to calculate the frequency of numbers. array arr is taken as arguement from the calling function
        public static void computeFrequency(int[] a)
        {
            try
            {
                Console.WriteLine("Number\tFrequency");

                // finding unique array elements of array a using Distinct() function present in System.Linq
                int[] uniqueArray = a.Distinct().ToArray();

                // for loop to get each element of uniquearray
                for (int i = 0; i < uniqueArray.Length; i++)
                {
                    // setting counter to 0
                    int count = 0;

                    // for loop to match each element of uniquearray with array a and incrementing counter if match happens
                    for (int j =0; j < a.Length; j++)
                    {
                        if (a[j] == uniqueArray[i])
                        {
                            count++;

                        } // end of if

                    } // end of for loop j
                    
                    // Displaying the result
                    Console.WriteLine(uniqueArray[i] + "\t" + count);

                } // end of for loop i
            } // end of try
            // This block is executed when error occurs in the try block else not
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            } // end of catch
        } // end of computeFrequency(int[] a)

    } // end of class
} // end of namespace
