using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class BloqueDeEnemigos
    {
        private const int numEnem = 11;
        private int posicionX = 80;
        private int posicionY = 100;
        Enemigo[,] misEnemigos = new Enemigo[3, numEnem];

        public void Dibujar()
        {
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
        }
    }
}
