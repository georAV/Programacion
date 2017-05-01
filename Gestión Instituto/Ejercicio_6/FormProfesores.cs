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
    public partial class FormProfesores : Form
    {
        public FormProfesores()
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

        public Profesores listaProfesores;
        public Cursos listaCursos;

        private void btnIntPro_Click(object sender, EventArgs e)
        {
            string nombre = InputBox("Introduce el nombre del profesor: ");
            string dni = InputBox("Introduce el DNI: ");
            string telefono = InputBox("Introduce el teléfono: ");
            string curso = InputBox("Introduce el curso del que es tutor, en caso de serlo: ");
            bool resultado = listaProfesores.AgregarProfesor(nombre, dni, telefono, curso, listaCursos);
            if(resultado)
            {
                MessageBox.Show("Profesor añadido.");
            }
            else
            {
                MessageBox.Show("El profesor ya existe.");
            }
        }

        private void btnEliPro_Click(object sender, EventArgs e)
        {
            string nombre = InputBox("Introduce el nombre del Profesor: ");
            bool resultado = listaProfesores.EliminarProfesor(nombre);
            if (resultado)
            {
                MessageBox.Show("Profesor eliminado.");
            }
            else
            {
                MessageBox.Show("El profesor no existe.");
            }
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            string resultado = listaProfesores.MostrarLista();
            MessageBox.Show(resultado);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            listaProfesores.OrdenarProfesores();
            MessageBox.Show("Lista de profesores ordenada.");
        }

        private void btnDatosProf_Click(object sender, EventArgs e)
        {
            string nombre = InputBox("Introduce el nombre del profesor: ");
            string resultado = listaProfesores.MostrarDatosProfesor(nombre);
            MessageBox.Show(resultado);
        }

        private void btnAgregarAsig_Click(object sender, EventArgs e)
        {
            string nombre = InputBox("Introduce el nombre del profesor");
            DialogResult mas;
            string asignatura;
            do
            {
                asignatura = InputBox("Introduce asignatura: ");
                if (!listaProfesores.AgregarAsignatura(nombre, asignatura))
                {
                    mas = DialogResult.No;
                    MessageBox.Show("El profesor no existe");
                }
                else
                {
                    mas = MessageBox.Show("¿Quiere introducir otra asignatura?", "Valor", MessageBoxButtons.YesNo);
                }
            } while (mas == DialogResult.Yes);
        }

        private void btnElimAsig_Click(object sender, EventArgs e)
        {
            string nombre = InputBox("Introduce el nombre del profesor");
            bool resultado = listaProfesores.EliminarAsignaturas(nombre);
            if (resultado)
            {
                MessageBox.Show("Asignaturas eliminadas.");
            }
            else
            {
                MessageBox.Show("El profesor no existe.");
            }
        }

        private void btnMostrarProfAsig_Click(object sender, EventArgs e)
        {
            string asignatura = InputBox("Introduce la asignatura");
            string resultado = listaProfesores.MostrarProfAsig(asignatura);
            MessageBox.Show(resultado);

        }
    }
}
