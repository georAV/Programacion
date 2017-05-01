using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public class Cursos
    {
        private ArrayList listaCursos;
        public Cursos()
        {
            listaCursos = new ArrayList();
        }

        /* AGREGAR CURSO.
         * Se piden parámetros nombre y código.
         * Llama a la función BuscarCursos para comprobar que no existe, y en ese caso lo añade a la listaCursos.
         * Devuelve true o false según se haya agregado o no, para poder dar el mensaje conveniente.
         */
        public bool AgregarCurso (string nombre, string codigo)
        {
            bool agregado;
            int posicion = BuscarCurso(nombre);
            if(posicion == -1)
            {
                Curso nuevoCurso = new Curso();
                nuevoCurso.Nombre = nombre;
                nuevoCurso.Codigo = codigo;
                listaCursos.Add(nuevoCurso);
                agregado = true ;
            }
            else
            {
                agregado = false ;
            }
            return agregado;

        }

        /* BUSCAR CURSO.
         * Función privada que se utiliza para buscar un curso en la lista de cursos.
         * Devuelve la posición del curso si se ha encontrado, o -1 si no existe.
         */
        private int BuscarCurso (string nombre)
        {
            int posicion = -1;
            Curso cur = new Curso();
            for (int i= 0; i<listaCursos.Count; i++)
            {
                cur = (Curso)listaCursos[i];
                if(cur.Nombre == nombre)
                {
                    posicion = i;
                }
            }
            return posicion;
        }

        /* DEVOLVER CÓDIGO.
         * Función que devuelve el código de un curso al pasar como parámetro su nombre.
         * Ésta función se utiliza para dar valor al campo código del objeto Alumno.
         */
        public string DevolverCodigo(string nombre)
        {
            string codigo;
            Curso cur = new Curso();
            int posicion = BuscarCurso(nombre);
            if (posicion !=-1)
            {
                cur = (Curso)listaCursos[posicion];
                codigo = cur.Codigo;
            }
            else
            {
                codigo = "";
            }
            return codigo;
        }

        /* ELIMINAR CURSO.
         * Función que elimina un curso en función a su nombre, después de buscar si el curso existe.
         * Devuelve true o false para poder manejar el mensaje conveniente en el formulario.
         */
        public bool EliminarCurso (string nombre)
        {
            bool borrado;
            int posicion = BuscarCurso(nombre);
            if (posicion!=-1)
            {
                listaCursos.RemoveAt(posicion);
                borrado = true;
            }
            else
            {
                borrado = false;
            }
            return borrado;
        }

        /* MOSTRAR TODOS LOS CURSOS.
         * Función que muestra los datos de todos los cursos al recorrer la lista de Cursos.
         * En cada iteración del bucle llama a la función MostrarDatos() del objeto Curso en particular.
         * Devuelve un string con la información.
         */
        public string MostrarTodosCursos()
        {
            string cadena = "Lista de Cursos: \n\n";
            Curso cur = new Curso();
            for (int i=0; i<listaCursos.Count;i++)
            {
                cur = (Curso)listaCursos[i];
                cadena += "Curso " + (i+1) + ":\n" + cur.MostrarCurso();
            }
            return cadena;
        }
    }
}
