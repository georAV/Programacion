using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Bienvenida
    {

        private bool salir;
        public void Lanzar()
        {
            Console.WriteLine("********************     BIENVENIDO A CONSOLE INVADERS     ********************");
            Console.WriteLine("         ***********        Pulsa intro para jugar       ***********");
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.Enter)
            {
                salir = false;
            }
            if (tecla.Key == ConsoleKey.Escape)
            {
                salir = true;
            }
        }
        public bool Salir
        {
            get
            {
                return salir;
            }
        }
    }
}
