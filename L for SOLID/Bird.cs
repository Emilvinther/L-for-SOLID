using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_for_SOLID
{
    public abstract class Bird
    {

        public virtual void SetLocation(double longitude, double latitude)
        {
            Console.WriteLine($"longitude {longitude}");
            Console.WriteLine($"latitude {latitude}");
        }
        public abstract void Draw();

    }
}
