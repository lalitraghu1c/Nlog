﻿using System;
namespace NLogProject
{
    public class NLogProject
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition Problem \n Enter a & b values");
            AddNumbers add = new AddNumbers();
            Console.WriteLine("Result is : " + " " + add.Sum(0,1));
        }
    }
}