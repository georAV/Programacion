using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_6
{
    public class Profesores
    {
        private ArrayList listaProfesores;
        public Profesores()
        {
            listaProfesores = new ArrayList();
        }
        private int BuscarProfesor(string nombre)
        {
            Profesor pro = new Profesor();
            int posicion = -1;
            for (int i = 0; i < listaProfesores.Count;i++)
            {
                pro = (Profesor)listaProfesores[i];
                if (pro.Nombre == nombre)
                {
                    posicion = i;
                }
            }
            return posicion;
        }
        public bool AgregarProfesor(string nombre, string dni, string telefono, string nombreCurso, Cursos lista)
        {
            bool agregado;
            if (BuscarProfesor(nombre)==-1)
            {
                Profesor prof = new Profesor();
                prof.Nombre = nombre;
                prof.Dni = dni;
                prof.Telefono = telefono;
                prof.CodigoCursoTutor = lista.DevolverCodigo(nombreCurso);
                listaProfesores.Add(prof);
                agregado = true;
            }
            else
            {
                agregado = false;
            }
            return agregado;
        }
        public bool EliminarProfesor(string nombre)
        {
            bool eliminado = false;
            int posicion = BuscarProfesor(nombre);
            if (posicion!=-1)
            {
                listaProfesores.RemoveAt(posicion);
                eliminado = true;
            }
            return eliminado;
        }

        public string MostrarLista()
        {
            string cadena = "Lista de Profesores: \n\n";
            Profesor prof = new Profesor();
            for (int i = 0; i<listaProfesores.Count;i++)
            {
                prof = (Profesor)listaProfesores[i];
                cadena += prof.MostrarProfesor();
            }
            return cadena;
        }

        private bool CompararNombres(Profesor prof1, Profesor prof2)
        {
            bool cambiar = false;
            if (string.Compare(prof1.Nombre, prof2.Nombre)>0)
            {
                cambiar = true;
            }
            return cambiar;
        }

        public void OrdenarProfesores()
        {
            for (int i = 0;i<listaProfesores.Count;i++)
            {
                for (int j=i+1; j<listaProfesores.Count;j++)
                {
                    if (CompararNombres((Profesor)listaProfesores[i], (Profesor)listaProfesores[j]))
                    {
                        Profesor aux = (Profesor)listaProfesores[j];
                        listaProfesores[j] = listaProfesores[i];
                        listaProfesores[i] = aux;
                    }
                }
            }
        }

        public string MostrarDatosProfesor(string nombre)
        {
            string cadena;
            int posicion = BuscarProfesor(nombre);
            if (posicion !=-1)
            {
                Profesor prof = (Profesor)listaProfesores[posicion];
                cadena = prof.MostrarProfesor();
            }
            else
            {
                cadena = ("El profesor no existe");
            }
            return cadena;
        }

        public bool AgregarAsignatura(string nombre, string asignatura)
        {
            bool agregada;
            int posicion = BuscarProfesor(nombre);
            if(posicion==-1)
            {
                agregada = false;
            }
            else
            {
                Profesor prof = (Profesor)listaProfesores[posicion];
                prof.ListaAsignaturas.Add(asignatura);
                agregada = true;
            }
            return agregada;
        }

        public bool EliminarAsignaturas(string nombre)
        {
            bool eliminadas = false;
            int posicion = BuscarProfesor(nombre);
            if(posicion != -1)
            {
                Profesor prof = new Profesor();
                prof = (Profesor)listaProfesores[posicion];
                prof.ListaAsignaturas.Clear();
                eliminadas = true;
            }
            return eliminadas;
        }

        public string MostrarProfAsig(string asignatura)
        {
            string cadena = "Lista de profesores de " + asignatura + ":\n\n";
            Profesor prof = new Profesor();
            for (int i=0; i<listaProfesores.Count;i++)
            {
                prof = (Profesor)listaProfesores[i];
                if (prof.ListaAsignaturas.Contains(asignatura))
                {
                    cadena += prof.MostrarProfesor();
                }
            }
            return cadena;
        }
    }
}
