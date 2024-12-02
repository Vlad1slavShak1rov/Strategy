using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Bow : IWeapon
    {
        public string UseWeapon()
        {
            return "нанёс урон луком";
        }
    }
}
