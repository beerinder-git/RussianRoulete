using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoulete
{
    public class ShootingClass
    {
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
    }
}
