using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy.Strategies
{
    internal class Broom : IWeapon
    {
        void IWeapon.Shoot()
        {
            Console.WriteLine("attacks with a broom");
        }
    }
}
