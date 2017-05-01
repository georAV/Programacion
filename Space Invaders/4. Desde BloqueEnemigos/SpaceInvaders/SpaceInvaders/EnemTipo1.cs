using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class EnemTipo1 : Enemigo
    {
        public EnemTipo1() : base ()
        {
        }

        public EnemTipo1 (int posX , int posY) : base (posX, posY)
        {
        }
        public override void Dibujar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.Dibujar();
        }
    }
}
