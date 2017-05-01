using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Juego
    {
        public void Lanzar()
        {
            Bienvenida bie = new Bienvenida();
            Partida par = new Partida();
            bie.Lanzar();
            if (bie.Salir==false)
            {
                Console.Clear();
                par.Lanzar();
            }
            else
            {
                Environment.Exit(0);
            }
            Console.ReadLine();
        }
    }
}
