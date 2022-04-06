using System;
using System.IO;

namespace Domino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            int numberofDominos=int.Parse(sr.ReadLine());
            Domino[] Dominok=new Domino[numberofDominos];
            int idx = 0;
            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split('|');
                Dominok[idx] = new Domino(int.Parse(line[0]),int.Parse(line[1]));
                idx++;
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
            Console.ReadKey();
        }
    }
}
