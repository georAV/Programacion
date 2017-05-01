using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class EnemTipo2:Enemigo
    {
        public EnemTipo2() : base ()
        {
            x = 180;
            imagen = "}{";
        }
        public EnemTipo2(int posX, int posY) : base (posX, posY)
        {
            imagen = "}{";
        }
        public override void Dibujar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Dibujar();
        }
    }
}
