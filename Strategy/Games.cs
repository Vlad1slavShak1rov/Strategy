using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Games
    {   
        private Player _player;
        public Games(Player player)
        {
            _player = player;
        }

        public void SelectWeapon(IWeapon weapon)
        {
            _player.Weapon = weapon;
        }
    }
}
