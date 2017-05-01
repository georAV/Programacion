namespace Ejercicio_6
{
    partial class FormProfesores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIntPro = new System.Windows.Forms.Button();
            this.btnDatosProf = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.btnEliPro = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMostrarProfAsig = new System.Windows.Forms.Button();
            this.btnElimAsig = new System.Windows.Forms.Button();
            this.btnAgregarAsig = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIntPro);
            this.groupBox1.Controls.Add(this.btnDatosProf);
            this.groupBox1.Controls.Add(this.btnOrdenar);
            this.groupBox1.Controls.Add(this.btnMostrarLista);
            this.groupBox1.Controls.Add(this.btnEliPro);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profesores";
            // 
            // btnIntPro
            // 
            this.btnIntPro.Location = new System.Drawing.Point(30, 48);
            this.btnIntPro.Name = "btnIntPro";
            this.btnIntPro.Size = new System.Drawing.Size(224, 34);
            this.btnIntPro.TabIndex = 5;
            this.btnIntPro.Text = "Introducir Profesor";
            this.btnIntPro.UseVisualStyleBackColor = true;
            this.btnIntPro.Click += new System.EventHandler(this.btnIntPro_Click);
            // 
            // btnDatosProf
            // 
            this.btnDatosProf.Location = new System.Drawing.Point(30, 266);
            this.btnDatosProf.Name = "btnDatosProf";
            this.btnDatosProf.Size = new System.Drawing.Size(224, 36);
            this.btnDatosProf.TabIndex = 4;
            this.btnDatosProf.Text = "Mostrar datos de Profesor";
            this.btnDatosProf.UseVisualStyleBackColor = true;
            this.btnDatosProf.Click += new System.EventHandler(this.btnDatosProf_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(30, 211);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(224, 36);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar Profesores";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(30, 156);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(224, 36);
            this.btnMostrarLista.TabIndex = 2;
            this.btnMostrarLista.Text = "Mostrar Lista Profesores";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrarLista_Click);
            // 
            // btnEliPro
            // 
            this.btnEliPro.Location = new System.Drawing.Point(30, 101);
            this.btnEliPro.Name = "btnEliPro";
            this.btnEliPro.Size = new System.Drawing.Size(224, 36);
            this.btnEliPro.TabIndex = 1;
            this.btnEliPro.Text = "Eliminar Profesor";
            this.btnEliPro.UseVisualStyleBackColor = true;
            this.btnEliPro.Click += new System.EventHandler(this.btnEliPro_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMostrarProfAsig);
            this.groupBox2.Controls.Add(this.btnElimAsig);
            this.groupBox2.Controls.Add(this.btnAgregarAsig);
            this.groupBox2.Location = new System.Drawing.Point(344, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 341);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignaturas";
            // 
            // btnMostrarProfAsig
            // 
            this.btnMostrarProfAsig.Location = new System.Drawing.Point(35, 158);
            this.btnMostrarProfAsig.Name = "btnMostrarProfAsig";
            this.btnMostrarProfAsig.Size = new System.Drawing.Size(224, 34);
            this.btnMostrarProfAsig.TabIndex = 2;
            this.btnMostrarProfAsig.Text = "Mostrar Profesores de una Asignatura";
            this.btnMostrarProfAsig.UseVisualStyleBackColor = true;
            this.btnMostrarProfAsig.Click += new System.EventHandler(this.btnMostrarProfAsig_Click);
            // 
            // btnElimAsig
            // 
            this.btnElimAsig.Location = new System.Drawing.Point(35, 101);
            this.btnElimAsig.Name = "btnElimAsig";
            this.btnElimAsig.Size = new System.Drawing.Size(224, 34);
            this.btnElimAsig.TabIndex = 1;
            this.btnElimAsig.Text = "Eliminar Asignatura de Profesor";
            this.btnElimAsig.UseVisualStyleBackColor = true;
            this.btnElimAsig.Click += new System.EventHandler(this.btnElimAsig_Click);
            // 
            // btnAgregarAsig
            // 
            this.btnAgregarAsig.Location = new System.Drawing.Point(35, 48);
            this.btnAgregarAsig.Name = "btnAgregarAsig";
            this.btnAgregarAsig.Size = new System.Drawing.Size(224, 34);
            this.btnAgregarAsig.TabIndex = 0;
            this.btnAgregarAsig.Text = "Añadir Asignatura a Profesor";
            this.btnAgregarAsig.UseVisualStyleBackColor = true;
            this.btnAgregarAsig.Click += new System.EventHandler(this.btnAgregarAsig_Click);
            // 
            // FormProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 365);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProfesores";
            this.Text = "FormProfesores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDatosProf;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnMostrarLista;
        private System.Windows.Forms.Button btnEliPro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMostrarProfAsig;
        private System.Windows.Forms.Button btnElimAsig;
        private System.Windows.Forms.Button btnAgregarAsig;
        private System.Windows.Forms.Button btnIntPro;
    }
}