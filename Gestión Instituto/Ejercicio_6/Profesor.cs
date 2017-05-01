using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_6
{
    class Profesor
    {
        private string nombre;
        private string dni;
        private string telefono;
        private ArrayList listaAsignaturas;
        private string codigoCursoTutor;

        public Profesor()
        {
            nombre = "";
            dni = "";
            telefono = "";
            listaAsignaturas = new ArrayList();
            codigoCursoTutor = "";
        }

        public Profesor(string nombre, string dni, string telefono)
        {
            Nombre = nombre;
            Dni = dni;
            Telefono = Telefono;
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public ArrayList ListaAsignaturas
        {
            get
            {
                return listaAsignaturas;
            }

            set
            {
                listaAsignaturas = value;
            }
        }

        public string CodigoCursoTutor
        {
            get
            {
                return codigoCursoTutor;
            }

            set
            {
                codigoCursoTutor = value;
            }
        }

        public string MostrarProfesor()
        {
            string cadena = "Nombre: " + nombre + "\nDNI: " + dni + "\nTeléfono: " + telefono +
                "\nCódigo Curso: " + CodigoCursoTutor + "\nAsignaturas: ";
            for (int i = 0; i < listaAsignaturas.Count; i++)
            {
                cadena += listaAsignaturas[i] + ",";
            }
            cadena += "\n------------\n\n";
            return cadena;
        }

    }
}
