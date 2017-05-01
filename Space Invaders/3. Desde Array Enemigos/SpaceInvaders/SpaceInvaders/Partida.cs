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

            BloqueDeEnemigos miBlque = new BloqueDeEnemigos();
            //Enemigos
            const int numEnem = 11;
            int posicionX = 80;
            int posicionY = 100;
            Enemigo[,] misEnemigos = new Enemigo[3, numEnem];
            for (int i = 0; i < numEnem; i++)
            {
                misEnemigos[0, i] = new EnemTipo1();
                misEnemigos[1, i] = new EnemTipo2();
                misEnemigos[2, i] = new EnemTipo3();
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < numEnem; j++)
                {
                    misEnemigos[i, j].MoverA(posicionX, posicionY);
                    misEnemigos[i, j].Dibujar();
                    posicionX += 80;
                }
                posicionX = 80;
                posicionY += 60;
            }

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
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < numEnem; j++)
                        {
                            misEnemigos[i, j].Dibujar();
                        }
                    }
                }
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    nave.MoverDerecha();
                    nave.Dibujar();
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < numEnem; j++)
                        {
                            misEnemigos[i, j].Dibujar();
                        }
                    }
                }
            } while (tecla.Key != ConsoleKey.Escape);
        }
    }
}
