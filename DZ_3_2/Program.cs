﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            float result;
            float course;

            Console.WriteLine("Таблица перевода USD в UAH");
            Console.WriteLine("Введите курс доллара:");
            course = float.Parse(Console.ReadLine().Replace(",", "."));
            Console.WriteLine("---------------------------------------------------");

            for (int i = 1; i <= 20; i++)
            {
                result = i * course;
                Console.WriteLine($"{i} USD = {result} UAH");
            }

            Console.ReadLine();
        }
    }
}
