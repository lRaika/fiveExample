﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int startRange = 1;
            int endRange = 11;
            int size = 10;
            Square square = new Square(size);
            Random rnd = new Random();
            for (int i= 0; i < size; i++)
            {
                square[i] = rnd.Next(startRange, endRange);
                Console.Write("{0}\t",square[i]);
            }
            Console.ReadLine();
        }
    }
}
