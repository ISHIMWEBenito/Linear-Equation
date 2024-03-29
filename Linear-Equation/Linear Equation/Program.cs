﻿using System;

namespace Linear_Equation
{
    internal class Program
    {
        internal static MatrixClass Matrix { get; private set; }

        private static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            MainProgram();
            void MainProgram()
            {
                Console.WriteLine("Type linear equations in augmented matrix notation: a1 a2... aN  d,\n where a1..N are coefficients and D is constant\n Type 'END' or 'end' or 'done'when you finish typing the equation");
                int index = 1;

                Matrix = new MatrixClass();
                try
                {
                    while (true)
                    {
                        Console.Write($"Eq #{index++}: ");

                        String input = Console.ReadLine();

                        if (input.Trim() == "END" || input.Trim() == "end" || input.Trim() == "done")
                            break;

                        Matrix.JoinEquation(new LinearEquationClass(input));
                    }

                    Console.WriteLine("You have entered following equations:");

                    for (int i = 0; i < Matrix.Length; i++)
                        Console.Write($"Eq #{i}: {Matrix.RecieveEquation(i)}\n");

                    Console.WriteLine("Result is:");
                    Matrix.ShowResults();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error occured: " + e.Message);
                }
                LoopOfMainProgram();
            }
            void LoopOfMainProgram()
            {
                while (true)
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Do you want to calculate another Equation? \n Type 'yes' or 'no'");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        Console.Clear();
                        MainProgram();
                        break;
                    }
                    else if (answer == "no")
                    {
                        Environment.Exit(0);
                        break;
                    }
                    else Console.WriteLine("Wrong answer");
                }
            }
        }
    }
}

