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
        protected string imagen;

        public Sprite (int posX , int posY)
        {
            x = posX;
            y = posY;
        }
        public Sprite ()
        {
            x = 0;
            y = 0;
        }
        public void MoverA(int nuevaX, int nuevaY)
        {
            x = nuevaX / 12;
            y = nuevaY / 30;
        }
        public virtual void Dibujar()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(imagen);
        }
    }
}
