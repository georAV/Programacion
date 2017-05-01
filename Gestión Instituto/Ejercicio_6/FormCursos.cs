using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Ejercicio_6
{
    public partial class FormCursos : Form
    {
        public FormCursos()
        {
            InitializeComponent();
        }
        private static string InputBox(string texto)
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

        private void btnAgrCur_Click(object sender, EventArgs e)
        {
            string nombre = InputBox("Introduce el nombre del Curso: ");
            string codigo = InputBox("Introduce el código del Curso: ");
            if (listaCursos.AgregarCurso(nombre, codigo))
            {
                MessageBox.Show("Curso añadido.");
            }
            else
            {
                MessageBox.Show("El curso ya existe.");
            }
        }

        private void btnEliCur_Click(object sender, EventArgs e)
        {
            string nombre = InputBox("Nombre del Curso a Eliminar: ");
            if (listaCursos.EliminarCurso(nombre))
            {
                MessageBox.Show("Curso eliminado.");
            }
            else
            {
                MessageBox.Show("No se encuentra el curso.");
            }
        }

        private void btnMosCur_Click(object sender, EventArgs e)
        {
            string resultado = listaCursos.MostrarTodosCursos();
            MessageBox.Show(resultado);
        }

        private void btnMosAluCur_Click(object sender, EventArgs e)
        {
           string codigo = InputBox("Introduce el código del curso:");
           //listaAlumnos.MostrarAlumnos(codigo);
        }
    }
}
