using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class DominoKirako
    {
        int numberOfDominos;
        Domino[] dominos;
        public DominoKirako(Domino[] dominos, int numberOfDominos)
        {
            this.numberOfDominos = numberOfDominos;
            this.dominos = dominos;
        }
        public bool Kirak()
        {
            for (int i = 0; i < dominos.Length; i++)
            {
                dominos[i].Felhasznalva = true;
                if (Kirak(i))
                {
                    return true;
                }
                DominoArrayReset();
            }
            return false;

        }
        private bool Kirak(int previous)
        {
            bool kesz = true;
            for (int i = 0; i < dominos.Length; i++)
            {
                if (!dominos[i].Felhasznalva)
                {
                    kesz = false;
                    break;
                }
            }
            if (kesz)
            {
                return true;
            }
            for (int i = 0; i < dominos.Length; i++)
            {
                if (!dominos[i].Felhasznalva)
                {
                    if (dominos[i].First==dominos[previous].Second)
                    {
                        dominos[i].Felhasznalva = true;
                        return Kirak(i);
                    }
                    else
                    {
                        if (dominos[i].Second==dominos[previous].Second)
                        {
                            dominos[i].Rotate();
                            dominos[i].Felhasznalva = true;
                            return Kirak(i);
                        }
                    }
                }
            }
            return false;
        }
        private void DominoArrayReset()
        {
            for (int i = 0; i < dominos.Length; i++)
            {
                dominos[i].Felhasznalva = false;
            }
        }
    }
}
