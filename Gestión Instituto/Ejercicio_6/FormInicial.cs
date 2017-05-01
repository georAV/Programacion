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
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }
        Cursos nuevaListaCursos = new Cursos();
        Alumnos nuevaListaAlumnos = new Alumnos();
        Profesores nuevaListaProfesores = new Profesores();
        private void btnGesCur_Click(object sender, EventArgs e)
        {
            FormCursos fCur = new FormCursos();
            fCur.listaCursos = nuevaListaCursos;
            fCur.listaAlumnos = nuevaListaAlumnos;
            fCur.ShowDialog();
        }

        private void btnGesAlu_Click(object sender, EventArgs e)
        {
            FormAlumnos fAlu = new FormAlumnos();
            fAlu.listaAlumnos = nuevaListaAlumnos;
            fAlu.listaCursos = nuevaListaCursos;
            fAlu.ShowDialog();
        }

        private void btnGesPro_Click(object sender, EventArgs e)
        {
            FormProfesores fProf = new FormProfesores();
            fProf.listaProfesores = nuevaListaProfesores;
            fProf.listaCursos = nuevaListaCursos;
            fProf.ShowDialog();
        }
    }
}
