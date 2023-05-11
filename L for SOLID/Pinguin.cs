using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_for_SOLID
{
    internal class Pinguin : Bird, ISwim
    {
        
        public override void Draw()
        {
            Console.WriteLine("Draw Pinguin");
        }

        public void ICanSwim()
        {
            Console.WriteLine("I can swim, much speed");
        }
    }
}
