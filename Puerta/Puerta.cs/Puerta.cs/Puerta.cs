using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puerta.cs
{
    class Puerta
    {
        protected int ancho; // Ancho en centímetros 
        protected int alto; // Alto en centímetros 
        protected int color; // Color en formato RGB 
        protected bool abierta; // Abierta o cerrada
        public Puerta()
        {
            ancho = 100;
            alto = 200;
            color = 0xFFFFFF;
            abierta = false;
        }

        public Puerta(int an, int al)
        {
            ancho = an;
            alto = al;
            color = 0xFFFFFF;
            abierta = false;
        }
        public int Ancho
        {
            get
            {
                return ancho;
            }

            set
            {
                ancho = value;
            }
        }

        public void Abrir() { abierta = true; }
        public void Cerrar() { abierta = false; }
        public void MostrarEstado()
        {
            Console.WriteLine("Ancho: {0}", Ancho); Console.WriteLine("Alto: {0}", alto);
            Console.WriteLine("Color: {0}", color); Console.WriteLine("Abierta: {0}", abierta);
        }
    }
}
