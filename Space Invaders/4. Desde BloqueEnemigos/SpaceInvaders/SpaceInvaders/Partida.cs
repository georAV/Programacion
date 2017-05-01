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
            //Nave
            Nave nave = new Nave(500, 600);
            nave.MoverA(500, 600);
            nave.Dibujar();

            //Enemigos
            BloqueDeEnemigos miBloque = new BloqueDeEnemigos();
            miBloque.Mover();

            //Interacción con el usuario.
            ConsoleKeyInfo tecla;
            do
            {
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    nave.MoverIzquierda();
                    nave.Dibujar();
                    miBloque.Mover(); 
                }
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    nave.MoverDerecha();
                    nave.Dibujar();
                    miBloque.Mover();
                }
            } while (tecla.Key != ConsoleKey.Escape);
        }
    }
}
