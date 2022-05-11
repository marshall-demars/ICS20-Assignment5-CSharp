// Created by: Marshall Demars
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program uses a loop to estimate the value of PI
        int integerOne;
        const int NUMERATOR = 4;
        int counter = 0;
        double total = 0;
        double denominator = 1;

        // input
        Console.WriteLine("This program uses a loop to estimate PI");
        Console.WriteLine("");
        Console.WriteLine("You will need to input one integer. Hint: the higher the number the closer the estimate will be to PI!");
        Console.WriteLine("");
        Console.WriteLine("Please input the integer:");
        integerOne = Convert.ToInt32(Console.ReadLine());

        // process
        if (integerOne < 0) {
          Console.WriteLine("Please input a positive integer!");
        }
        else
        {
            while (counter < integerOne)
            {
                if (counter % 2 == 0) {
                    denominator = counter * 2 + 1;
                    total += NUMERATOR / denominator;
                }
                else
                {
                    denominator = counter * 2 + 1;
                    total += - (NUMERATOR / denominator);
                }

                counter++;
            }
            // output 
            Console.WriteLine("The number is " + total);
            Console.WriteLine("");
        }
        Console.WriteLine("\nDone.");
    }
}
