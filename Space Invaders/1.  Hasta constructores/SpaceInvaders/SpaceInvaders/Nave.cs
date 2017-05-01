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
