﻿using System;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (var i = 1; i < 101; i++)
            {
                if ( (i % 3 == 0) && (i % 5 == 0) )
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.Read();
        }
    }
}
