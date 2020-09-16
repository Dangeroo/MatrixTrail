﻿using System;

namespace MatrixTrail
{
    public class UserInputValidator
    {
        int rowsInput = 0;
        int colsInput = 0;

        public int RowsInput { get => rowsInput; set => rowsInput = value; }
        public int ColsInput { get => colsInput; set => colsInput = value; }

        public void ValidRowInput()
        {
            Console.WriteLine("Let's create new matrix.");
            Console.Write("Enter number of rows: ");
            
            while (!Int32.TryParse(Console.ReadLine(), out rowsInput))
            {
                Console.WriteLine("Please enter valid number");
            }

        }

        public void ValidColInput()
        {
            Console.Write("Now enter number of columns: ");

            while (!Int32.TryParse(Console.ReadLine(), out colsInput))
            {
                Console.WriteLine("Please enter valid number");
            }

            Console.WriteLine();

        }


    }
}
