﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("Latihan Polymorphism Aryo Bimo/21.11.4311/21-IF-07");
            Console.WriteLine("Pilih printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Nomor printer [1-3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
            {
                printer = new Epson();
            }
            else if (nomorPrinter == 2)
            {
                printer = new Canon();
            }
            else
            {
                printer = new LaserJet();
            }

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}