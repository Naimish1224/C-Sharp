﻿using System;

namespace MyFirstCSharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 1; i < 30; i++)
            {
                if ((i % 3) == 0 && (i % 5) == 0)
                {
                    Console.WriteLine(i + " is FizzBuzz ");
                }
                else if ((i % 3) == 0)
                {
                    Console.WriteLine(i + " is Fizz ");
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine(i + " is Buzz ");
                }
            }
        }
    }
}
