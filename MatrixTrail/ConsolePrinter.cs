﻿using MatrixTrail.Interfaces;
using System;
using System.Threading;

namespace MatrixTrailCalculator
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(int[,] matrixArray)
        {
            for (int i = 0; i < matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrixArray.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Thread.Sleep(50);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(string.Format("{0} ", matrixArray[i, j]));
                        Console.ResetColor();
                    }
                    else
                    {
                        Thread.Sleep(50);
                        Console.Write(string.Format("{0} ", matrixArray[i, j]));
                    }
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        public void Print(int matrixTrail)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Sum of values of main diagonal is: {matrixTrail}");
            Console.ReadLine();
        }
    }
}
