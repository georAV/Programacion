using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public partial class FormAlumnos : Form
    {
        public FormAlumnos()
        {
            InitializeComponent();
        }
        public static string InputBox(string texto)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = texto;
            ib.DefaultValue = "";
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }
        public Cursos listaCursos;
        public Alumnos listaAlumnos;
        private void btnIntAlu_Click(object sender, EventArgs e)
        {
            string nombre = InputBox("Introduce el nombre del Alumno: ");
            string dni = InputBox("Introduce el dni: ");
            string telefono = InputBox("Introduce el teléfono: ");
            string curso = InputBox("Introduce el nombre del curso: ");

            //Además de los parámetros a agregar, paso la lista de cursos para comprobar si el curso existe
            bool resultado = listaAlumnos.AgregarAlumno(nombre, dni, telefono, curso, listaCursos);
            if(resultado)
            {
                MessageBox.Show("Alumno añadido.");
            }
            else
            {
                MessageBox.Show("Error al añadir el alumno.");
            }
        }

        private void btnEliAlu_Click(object sender, EventArgs e)
        {
            string nombre = InputBox("Introduce el nombre del Alumno");
            if (listaAlumnos.BorrarAlumno(nombre))
            {
                MessageBox.Show("Alumno Borrado.");
            }
            else
            {
                MessageBox.Show("No se ha encontrado el alumno.");
            }
        }

        private void btnLisAlu_Click(object sender, EventArgs e)
        {
            string lista = listaAlumnos.MostrarLista();
            MessageBox.Show(lista);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            listaAlumnos.OrdenarAlumnos();
            MessageBox.Show("La lista se ha ordenado.");
        }

        private void btnDatNom_Click(object sender, EventArgs e)
        {
            string nombre = InputBox("Introduce el nombre del alumno: ");
            string resultado = listaAlumnos.MostrarAlumno(nombre);
            MessageBox.Show(resultado);
        }

        private void btnAluCur_Click(object sender, EventArgs e)
        {
            string nombre = InputBox("Introduce el nombre del curso: ");
            string resultado = listaAlumnos.MostrarAlumnosDeCurso(nombre, listaCursos);
            MessageBox.Show(resultado);
        }

        private void btnNotAlu_Click(object sender, EventArgs e)
        {
            string nombre = InputBox("Introduce el nombre del alumno");
            DialogResult mas;
            float nota;
            do
            {
                nota = float.Parse(InputBox("Introduce la nota: "));
                if (!listaAlumnos.AgregarNota(nombre, nota))
                {
                    mas = DialogResult.No;
                    MessageBox.Show("El alumno no existe");
                }
                else
                {
                    mas = MessageBox.Show("¿Quiere introducir otra nota?", "Valor", MessageBoxButtons.YesNo);
                }
            } while (mas == DialogResult.Yes);
        }

        private void btnEliNot_Click(object sender, EventArgs e)
        {
            string nombre = InputBox("Introduce el nombre del alumno: ");
            bool resultado = listaAlumnos.EliminarNotas(nombre);
            if(resultado)
            {
                MessageBox.Show("Notas eliminadas.");
            }
            else
            {
                MessageBox.Show("El alumno no existe.");
            }
        }

        private void btnMediaMayor_Click(object sender, EventArgs e)
        {
            string resultado = listaAlumnos.MostrarAlumnosMediaMayor();
            MessageBox.Show(resultado);
        }

        private void btnMediaMenor_Click(object sender, EventArgs e)
        {
            string resultado = listaAlumnos.MostrarAlumnosMediaMenor();
            MessageBox.Show(resultado);
        }
    }
}
