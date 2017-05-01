using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class EnemTipo3:Enemigo
    {
        public EnemTipo3() : base ()
        {
            x = 260;
            imagen = "||";
        }
        public EnemTipo3(int posX, int posY) : base (posX, posY)
        {
            imagen = "||";
        }
        public override void Dibujar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Dibujar();
        }
    }
}
