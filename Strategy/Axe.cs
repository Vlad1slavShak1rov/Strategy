using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Axe : IWeapon
    {
        public string UseWeapon()
        {
            return "нанёс урон топором";
        }
    }
}
