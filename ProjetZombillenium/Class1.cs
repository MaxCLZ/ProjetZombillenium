using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetZombillenium
{
    class Class1
    {

        private int aa;
        private int bb;

        public int Aa { get => aa; set => aa = value; }         // faire attention sur les proprietes attention au set
        public int Bb { get => bb; set => bb = value; }

        public Class1(int aa, int bb)
        {
            this.aa = aa;
            this.Bb = bb;
        }

        public override string ToString()
        {
            return base.ToString()+ aa + bb ;
        }

        public Class1(int aa): this (aa,-1)
        {
            
        }
    }
}
