using System;

namespace PrimeNumber1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 5, b = 15;  // declaring 2 variables
            Console.WriteLine("Prime numbers between " + a + " and " + b + ": ");
            printPrimeNumbers(a, b);  // calling function prime numbers

            int n1 = 5;
            double r1 = getSeriesResult(n1);  // calling getSeriesResult function
            Console.WriteLine("The sum of the series is: " + r1);

            long n2 = 15;
            long r2 = decimalToBinary(n2); // Calling decimal to binary conversion
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);

            long n3 = 1111;
            long r3 = binaryToDecimal(n3);  // calling binary to decimal conversion
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);

            int n4 = 5;
            printTriangle(n4);  // calling the print triangle

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            ComputeFrequency(arr);  // calling the compute frequency method

            Console.WriteLine("  \n");
            Console.ReadLine();
        }

        //This method computes the frequency of each element in the array    
        public static double getSeriesResult(int n)
        {
            double seriestotal = 0;
            double denom;
            double numer;
            double frac;

            for (int i = 1; i <= n; i++)
            {
                numer = factorial(i);  //get the value of factorial
                denom = i + 1;

                if (i % 2 == 0)
                {
                    frac = -1 * (numer / denom);   // compute the numerator and denominator
                }
                else
                {
                    frac = (numer / denom);
                }
                seriestotal += frac;  // add the series total with fraction output
            }
            return Math.Round(seriestotal, 3);  // return the result with rounded value
        }

        // This method prints all the prime numbers between x and y
        public static void printPrimeNumbers(int a, int b)
        {
            for (int x = a; x <= b; x++)  //start outer loop
            {

                for (int y = 2; y <= x; y++)  // start of inner loop
                {
                    if (x % y != 0)  // checking the condition for prime number
                        continue;
                    else if (x != y)
                        break;
                    else
                        Console.Write(x + " ");  // print the prime number here
                }
            }
            Console.WriteLine();

        }
        //This Method prints a traingle using 
        public static void printTriangle(int n)
        {
            int i, j;
            for (i = 1; i <= n; i++) // start of outer loop
            {
                for (j = i; j < n; j++)
                {
                    Console.Write(" "); // give spaces before the stars in the line
                }
                for (j = 0; j < 2 * i - 1; j++) // compute the number of stars for the line
                {
                    Console.Write("*");
                }
                Console.WriteLine();  // go to new line
            }
        }
        //This Method prints a factorial 
        public static int factorial(int n)
        {
            int z = 1;
            for (int k = n; k >= 1; k--)
            {
                z *= k;  // factorial computation
            }
            return z;
        }

        //This Method prints a decim
        public static long decimalToBinary(long n2)
        {
            long newnumber = 0;
            long number = n2;
            long remainder = 0;
            string newresult = string.Empty;
            try
            {
                while (n2 > 0)
                {
                    remainder = (n2 % 2);  // compute the value of remainder
                    n2 /= 2;  // divide the number by 2
                    newresult = remainder.ToString() + newresult;  // add the result to string
                }
                newnumber = Convert.ToInt64(Convert.ToDecimal(newresult)); // conversion to long
            }
            catch
            {
                Console.WriteLine("Error in decimalToBinary");
            }
            return newnumber;   // Return the result
        }
        public static long binaryToDecimal(long n)
        {
            long remainder = 0;
            long decimal1 = 0;
            int i = 0; // to get the position of digit
            try
            {
                while (n > 0)
                {
                    remainder = n % 10;   //get the remainder
                    if (remainder == 1)
                    {
                        decimal1 = decimal1 + power(i);   // use the user defined power method to get the value
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                    n = n / 10;         // removing the digit which is computed
                }
            }
            catch
            {
                Console.WriteLine("Exception in binary to decimal");
            }
            return decimal1;
        }
        public static long power(long n)
        {
            long number = 1;
            for (int i = 0; i < n; i++)
            {
                number = number * 2;  // performing the power of function
            }
            return number;
        }

        public static void ComputeFrequency(int[] a)
        {
            int[] newnum = new int[a.Length];
            Console.WriteLine("Number\tFrequency");
            try
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (!CheckNumber(newnum, a[i]))
                    {
                        int k = 1;
                        for (int j = i + 1; j < a.Length - 1; j++)
                        {
                            if (a[i] == a[j])   //comparision
                            {
                                newnum[i] = a[i];
                                k = k + 1;
                            }
                        }
                        Console.WriteLine(a[i] + "\t" + k);  //print the number and its frequency
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error in computeFrequency method");
            }
        }
        public static bool CheckNumber(int[] num, int num2)
        {
            foreach (int a in num)
            {
                if (a == num2)  // checking condition for repetitive number
                {
                    return true;
                }
            }
            return false;
        }

    }
}