﻿using System;

namespace Hetmany
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string userN = args.Length > 0 ? args[0] : null;
            if (!int.TryParse(userN, out n))
            {
                n = 8; // domyslnie szachownica 8x8
            }

            Solution simAnnealSolution = SimulatedAnnealing.Execute(n);
            simAnnealSolution.Rysuj();
            Console.ReadLine();
        }
    }
}
