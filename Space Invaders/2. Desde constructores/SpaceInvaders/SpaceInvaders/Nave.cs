using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Nave : Sprite
    {
        private string imagen = "/\\";

        public Nave(int posX, int posY)
        {
            x = posX;
            y = posY;
        }
        public Nave()
        {
            x = 500;
            y = 600;
        }
        public new void Dibujar()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(imagen);
        }
        public void MoverDerecha()
        {
            x += 10;
        }
        public void MoverIzquierda()
        {
            x -= 10;
        }

    }
}
