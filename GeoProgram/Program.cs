﻿using SinifKutup1;

namespace GeoProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nokta n1 = new Nokta(3, 4);
            Console.WriteLine("n1({0},{1}) Uzaklik = {2}", n1.X, n1.Y, n1.Uzaklik());
        }
    }
}
