using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace Ejercicio_6
{
    class Alumno
    {
        private string nombre;
        private string dni;
        private string telefono;
        private ArrayList notas;
        private string codigoCurso;

        public Alumno()
        {
            nombre = "";
            dni = "";
            telefono = "";
            Notas = new ArrayList();
            codigoCurso = "";
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
        public string Codigo
        {
            get
            {
                return codigoCurso;
            }
            set
            {
                codigoCurso = value;
            }
        }

        public ArrayList Notas
        {
            get
            {
                return notas;
            }

            set
            {
                notas = value;
            }
        }

        public float Media()
        {
            float media=0;
            for (int i=0;i<notas.Count;i++)
            {
                media += (float)notas[i];
            }
            media /= notas.Count - 1;
            return media;
        }
        public string MostrarAlumno()
        {
            string cadena = "Nombre: " + nombre + "\nDNI: "+ dni + "\nTeléfono: " + telefono +
                "\nCódigo Curso: " + codigoCurso + "\nNotas: ";
            for (int i = 0; i<Notas.Count;i++)
            {
                cadena += Notas[i] + ",";
            }
            cadena += "\n------------\n\n";
            return cadena;
        }
    }
}
