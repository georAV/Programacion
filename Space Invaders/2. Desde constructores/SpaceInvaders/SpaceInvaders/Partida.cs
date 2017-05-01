using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Partida
    {
        public void Lanzar()
        {
            Nave nave = new Nave(500,600);
            nave.MoverA(500, 600);
            nave.Dibujar();
            Enemigo enemigo = new Enemigo();
            enemigo.MoverA(100, 80);
            enemigo.Dibujar();

            ConsoleKeyInfo tecla;
            do
            {
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    nave.MoverIzquierda();
                    nave.Dibujar();
                    enemigo.Dibujar();
                }
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    nave.MoverDerecha();
                    nave.Dibujar();
                    enemigo.Dibujar();
                }
            }
            while (tecla.Key != ConsoleKey.Escape);
        }
    }
}
