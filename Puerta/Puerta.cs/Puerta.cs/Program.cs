using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puerta.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Puerta p = new Puerta();
            Console.WriteLine("Valores iniciales...");
            p.MostrarEstado();
            Console.WriteLine();
            Console.WriteLine("Vamos a abrir...");
            p.Abrir();
            p.Ancho=80;
            p.MostrarEstado();
            Console.WriteLine();
            Console.WriteLine("Ahora el portón...");
            Porton p2 = new Porton();
            p2.Ancho = 300 ;
            p2.Bloquear();
            p2.MostrarEstado();

            Console.ReadLine();
        }
    }
}
