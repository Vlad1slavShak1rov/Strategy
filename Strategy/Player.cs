using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Player
    {
        public string Name { get; }
        public IWeapon Weapon { get; set; }

        public Player(string name, IWeapon weapon)
        {
            Name = name;
            Weapon = weapon;
        }

        public void Attack()
        {
            Console.WriteLine($"{this.Name} {Weapon.UseWeapon()}"); 
        }
    }
}
