using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public class Alumnos
    {
        private ArrayList listaAlumnos;
        public Alumnos()
        {
            listaAlumnos = new ArrayList();
        }

        /* AGREGAR ALUMNO.
         * Crea un objeto Alumno y lo añade a la lista de Alumnos.
         * Para obtener el código del curso en el que está matriculado el alumno
         * se pasa como parámetro la lista de cursos y se llama a la función DevolverCódigo,
         * que obtendrá el código del curso pasado como parámetro.
         * Devuelve true o false según se haya realizado o no la operación.
         */
        public bool AgregarAlumno(string nombre, string dni, string telefono, string nombreCurso, Cursos lista)
        {
            bool agregado;
            string codigoCurso = lista.DevolverCodigo(nombreCurso);
            if (codigoCurso != "")
            {
                Alumno alu = new Alumno();
                alu.Nombre = nombre;
                alu.Dni = dni;
                alu.Telefono = telefono;
                alu.Codigo = codigoCurso;
                listaAlumnos.Add(alu);
                agregado = true;
            }
            else
            {
                agregado = false;
            }
            return agregado;
        }
        /* BUSCAR ALUMNO.
         * Función privada que busca un alumno en la lista de alumnos y devuelve su posición.
         * Devuelve -1 si no se encuentra.
         */
        private int BuscarAlumno(string nombre)
        {
            int posicion = -1;
            Alumno alu = new Alumno();
            for (int i=0; i<listaAlumnos.Count;i++)
            {
                alu = (Alumno)listaAlumnos[i];
                if (alu.Nombre == nombre)
                {
                    posicion = i;
                }
            }
            return posicion;
        }
        /* BORRAR ALUMNO.
         * Función que busca el nombre del alumno, y si existe lo borra.
         * Devuelve true o false según se haya realizado o no la operación
         * para manejar el mensaje adecuado en el formulario.
         */
        public bool BorrarAlumno(string nombre)
        {
            bool borrado;
            int posicion = BuscarAlumno(nombre);
            if (posicion ==-1)
            {
                borrado = false;
            }
            else
            {
                listaAlumnos.RemoveAt(posicion);
                borrado = true;
            }
            return borrado;
        }

        /* MOSTRAR LISTA DE ALUMNOS.
         * Función que recorre la lista de alumnos y crea una cadena de texto con los datos de cada uno.
         * En cada iteración del bucle llama a la función MostrarDatos de la clase Alumno.
         * Devuelve un string con la información.
         */
        public string MostrarLista()
        {
            string cadena = "Lista de Alumnos:\n\n";
            Alumno alu = new Alumno();
            for (int i=0; i<listaAlumnos.Count;i++)
            {
                alu = (Alumno)listaAlumnos[i];
                cadena += alu.MostrarAlumno();
            }
            return cadena;
        }

        /* COMPARAR NOMBRES.
         * Función privada que compara alfabéticamente los nombres de dos instancias de Alumno.
         * Devuelve true o false según haya que intercambiar sus posiciones o no.
         */
        private bool CompararNombres (Alumno alu1, Alumno alu2)
        {
            bool cambiar = false;
            if (string.Compare(alu1.Nombre, alu2.Nombre) > 0)
            {
                cambiar = true;
            }
            return cambiar;
        }

        /* ORDENAR ALUMNOS ALFABÉTICAMENTE.
         * Llama a la función CompararNombres() pasando como parámetros 
         * dos instancias de Alumno, correspondientes a las posiciones i y j en cada iteración.
         * Si la función CompararNombres() devuelve true cambia sus posiciones en la lista.
         */
        public void OrdenarAlumnos()
        {
            for (int i = 0; i < listaAlumnos.Count - 1; i++)
            {
                for (int j = i + 1; j < listaAlumnos.Count; j++)
                {
                    if (CompararNombres((Alumno)listaAlumnos[i], (Alumno)listaAlumnos[j]))
                    {
                        Alumno aux = (Alumno)listaAlumnos[j];
                        listaAlumnos[j] = (Alumno)listaAlumnos[i];
                        listaAlumnos[i] = aux;
                    }
                }
            }
        }

        /* MOSTRAR DATOS DE ALUMNO POR NOMBRE
         * Llama a la función BuscarAlumno para encontrar su posición en la lista.
         * Devuelve un string con los datos del alumno si se encuentra, o con el mensaje de que no se encuentra.
         */
        public string MostrarAlumno (string nombre)
        {
            string datos;
            int posicion = BuscarAlumno(nombre);
            if (posicion !=-1)
            {
                Alumno alu = new Alumno();
                alu = (Alumno)listaAlumnos[posicion];
                datos = alu.MostrarAlumno();
            }
            else
            {
                datos = "No se encuentra el alumno.";
            }
            return datos;
        }

        /* MOSTRAR ALUMNOS PERTENECIENTES A UN CURSO.
         * Función que pide el nombre del curso, y obteniendo la lista de cursos como parámetro
         * busca el código correspondiente al curso con la función DevolverCodigo.
         * Compara el código devuelto con el código de cada objeto Alumno, y si coincide
         * lo añade al string.
         * Devuelve un string con los datos recuperados.
         */
        public string MostrarAlumnosDeCurso (string nombre, Cursos lista)
        {
            string codigoCurso = lista.DevolverCodigo(nombre);
            string cadena = "Alumnos del curso " + nombre + " : \n\n";
            Alumno alu = new Alumno();
            for (int i=0; i<listaAlumnos.Count;i++)
            {
                alu = (Alumno)listaAlumnos[i];
                if(alu.Codigo == codigoCurso)
                {
                    cadena += alu.MostrarAlumno();
                }
            }
            return cadena;
        }
        public bool AgregarNota(string nombre, float nota)
        {
            bool agregada;
            int posicion = BuscarAlumno(nombre);
            if(posicion==-1)
            {
                agregada = false;
            }
            else
            {
                Alumno alu = (Alumno)listaAlumnos[posicion];
                alu.Notas.Add(nota);
                agregada = true;
            }
            return agregada;
        }

        public bool EliminarNotas(string nombre)
        {
            bool eliminado;
            int posicion = BuscarAlumno(nombre);
            if (posicion!=-1)
            {
                Alumno alu = new Alumno();
                alu = (Alumno)listaAlumnos[posicion];
                alu.Notas.Clear();
                eliminado = true;
            }
            else
            {
                eliminado = false;
            }
            return eliminado;
        }
        
        public string MostrarAlumnosMediaMayor()
        {
            string cadena = "Lista de Alumnos: \n\n";
            Alumno alu = new Alumno();
            for (int i = 0;i<listaAlumnos.Count;i++)
            {
                alu = (Alumno)listaAlumnos[i];
                if (alu.Media()>=5)
                {
                    cadena += alu.MostrarAlumno();
                }
            }
            return cadena;
        }
        public string MostrarAlumnosMediaMenor()
        {
            string cadena = "Lista de Alumnos: \n\n";
            Alumno alu = new Alumno();
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                alu = (Alumno)listaAlumnos[i];
                if (alu.Media() < 5)
                {
                    cadena += alu.MostrarAlumno();
                }
            }
            return cadena;
        }
    }
}
