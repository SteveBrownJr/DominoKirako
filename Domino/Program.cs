using System;
using System.IO;

namespace Domino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberofDominos=int.Parse(Console.ReadLine());
            Domino[] Dominok = new Domino[numberofDominos];
            for (int i = 0; i < numberofDominos; i++)
            {
                string[] line = Console.ReadLine().Split('|');
                Dominok[i] = new Domino(int.Parse(line[0]), int.Parse(line[1]));
            }
            DominoKirako DK = new DominoKirako(Dominok, numberofDominos);
            if (DK.Kirak())
            {
                Console.WriteLine("Y");
            }
            else
            {
                Console.WriteLine("N");
            }
        }
    }
}
