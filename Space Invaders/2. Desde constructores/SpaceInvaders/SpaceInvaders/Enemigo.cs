using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Enemigo : Sprite
    {
        private string imagen = "][";

        public Enemigo()
        {
            x = 100;
            y = 80;
        }
        public Enemigo (int posX, int posY)
        {
            x = posX;
            y = posY;
        }
        public new void Dibujar()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(imagen);
        }
    }
}
