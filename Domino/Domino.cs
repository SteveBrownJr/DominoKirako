using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class Domino
    {
        int first;
        int second;
        bool felhasznalva;
        public int First { get => first; set => first = value; }
        public int Second { get => second; set => second = value; }
        public bool Felhasznalva { get => felhasznalva; set => felhasznalva = value; }
        public void Rotate()
        {
            int s = First;
            First = second;
            second = s;
        }

        public Domino(int first, int second)
        {
            First = first;
            Second = second;
            felhasznalva = false;
        }
        public Domino GetCopy()
        {
            return new Domino(First, Second);
        }
    }
}
