using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                // the value of x and y
                int x = 5; int y = 15;

                // Calling the method that finds all prime numbers between x and y
                Console.WriteLine("The prime numbers are: ");
                printPrimeNumbers(x, y);
                Console.WriteLine("\n\n");

                // value of n
                int n = 5;

                // calling the method to print the star pattern
                printTriangle(n);
                
                // Displaying exit message and taking user input to exit application
                Console.WriteLine("\nPress any key to exit ");
                Console.ReadKey(true);
            } // end of try

            // this block is executed if errors in try block, else it is not executed 
            catch
            {
                // This block is executed if any error occurs in try block, else not it is not executed
                Console.WriteLine("Please enter a valid input next time");
                Console.WriteLine("Press any key to exit the application");
                Console.ReadKey(true);
            } // end of catch

        } // end of main

        // Method for printing prime numbers between range x and y. X and Y are sent as parameters from the main method to this method. Nothing is returned back to main method
        public static void printPrimeNumbers(int x, int y)
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

        }  // end of Printprimenumber method

        // method to print star pattern. Number of rpws in the pattern is sent from the main method as the argument. Nothing is returned to the main method
        public static void printTriangle(int n)
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

        } // end of method printTriangle(int n)

    } // end of class
} // end of namespace
