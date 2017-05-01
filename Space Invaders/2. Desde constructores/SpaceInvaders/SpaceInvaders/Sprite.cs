using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Sprite
    {
        protected int x;
        protected int y;
        public void MoverA(int nuevaX, int nuevaY)
        {
            x = nuevaX/12;
            y = nuevaY/30;
        }
        //Método abstracto.
        public void Dibujar()
        {
        }
    }
}
