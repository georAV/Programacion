using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class BloqueDeEnemigos
    {
        private const int numEnem = 2;
        private int posicionX ;
        private int posicionY;

        private Enemigo[,] misEnemigos;
        public BloqueDeEnemigos()
        {
            posicionX = 80;
            posicionY = 100;
            misEnemigos = new Enemigo[3, numEnem];
            for (int i = 0; i < numEnem; i++)
            {
                misEnemigos[0, i] = new EnemTipo1();
                misEnemigos[1, i] = new EnemTipo2();
                misEnemigos[2, i] = new EnemTipo3();
            }
        }
        public void Dibujar(int posX)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < numEnem; j++)
                {
                    misEnemigos[i, j].MoverA(posicionX, posicionY);
                    misEnemigos[i, j].Dibujar();
                    posicionX += 80;
                }
                posicionX = posX;
                posicionY += 60;
            }
        }
        public void Mover()
        {
            if (posicionX == 80 && posicionY == 280)
            {
                posicionX = 70;
                posicionY = 90;
                Dibujar(posicionX);
            }
            else
            {
                posicionX = 80;
                posicionY = 100;
                Dibujar(posicionX);
            }
        }
    }
}
