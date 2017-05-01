using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Nave : Sprite
    {
        public Nave(int posX, int posY)
        {
            x = posX;
            y = posY;
            imagen = "/\\";
        }
        public Nave()
        {
            x = 500;
            y = 600;
            imagen = "/\\";
        }
        /*Constructor sin parámetros que coge de base constructor con parámetros de la superclase.
         * public Nave() : this (500 ,600)
          {
              imagen = "/\\";
          }
         */
        public void MoverDerecha()
        {
            x += 10;
        }
        public void MoverIzquierda()
        {
            x -= 10;
        }
        public override void Dibujar()
        {
            Console.ForegroundColor = ConsoleColor.White;
            base.Dibujar();
        }

    }
}
