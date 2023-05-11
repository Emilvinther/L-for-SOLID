using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_for_SOLID
{
    public class Duck : Bird, IFly, ISwim
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Duck");
        }

        public void ICanSwim()
        {
            Console.WriteLine("I can swim pretty fast");
        }

        public void SetAltitude(double altitude)
        {
            Console.WriteLine($"Flying altitidue is {altitude}");
        }
    }
}
