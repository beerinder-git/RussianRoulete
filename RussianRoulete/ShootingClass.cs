using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoulete
{
    public class ShootingClass
    {
        int ShootingAwayChances = 2;
        int ShootingChances = 4;
        int Bullet = 0;

        public void LoadBullet()
        {
            Bullet = 3;
        }

        public int SpinChamber()
        {
            Random rand = new Random();
            Bullet = rand.Next(1, 7);
            return Bullet;
        }

        public int Shooting()
        {
            //decrease the shooting chances
            //decrease the bullet number (in other words the bullet will go to other place in the chamber)
            return ShootingChances;
        }

        public int ShootingAway()
        {
            //decrease the shooting away chances
            //decrease the bullet number (in other words the bullet will go to other place in the chamber)
            return ShootingAwayChances;
        }
    }
}
