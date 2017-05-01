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

        public new void Dibujar()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(imagen);
        }
    }
}
