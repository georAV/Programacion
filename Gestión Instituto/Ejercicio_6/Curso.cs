using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Curso
    {
        private string nombre;
        private string codigo;

        public Curso (string nombre, string codigo)
        {
            this.nombre = nombre;
            this.codigo = codigo;
        }
        public Curso()
        {
            Nombre = "";
            Codigo = "";
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre= value;
            }
        }
        public string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        public string MostrarCurso()
        {
            string cadena = "Nombre: " + nombre + "\nCódigo: " + codigo + "\n---------------\n\n";

            return cadena;
        }
    }
}
