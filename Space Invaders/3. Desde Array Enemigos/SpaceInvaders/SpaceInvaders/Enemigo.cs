using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Enemigo : Sprite
    {
        public Enemigo() : base()
        {
            x = 100;
            imagen = "][";
        }
        public Enemigo (int posX, int posY) : base (posX, posY)
        {
            imagen = "][";
        }
    }
}
