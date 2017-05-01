namespace Ejercicio_6
{
    partial class FormAlumnos
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
            this.btnAluCur = new System.Windows.Forms.Button();
            this.btnDatNom = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnLisAlu = new System.Windows.Forms.Button();
            this.btnEliAlu = new System.Windows.Forms.Button();
            this.btnIntAlu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMediaMenor = new System.Windows.Forms.Button();
            this.btnMediaMayor = new System.Windows.Forms.Button();
            this.btnEliNot = new System.Windows.Forms.Button();
            this.btnNotAlu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAluCur);
            this.groupBox1.Controls.Add(this.btnDatNom);
            this.groupBox1.Controls.Add(this.btnOrdenar);
            this.groupBox1.Controls.Add(this.btnLisAlu);
            this.groupBox1.Controls.Add(this.btnEliAlu);
            this.groupBox1.Controls.Add(this.btnIntAlu);
            this.groupBox1.Location = new System.Drawing.Point(25, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumnos";
            // 
            // btnAluCur
            // 
            this.btnAluCur.Location = new System.Drawing.Point(23, 318);
            this.btnAluCur.Name = "btnAluCur";
            this.btnAluCur.Size = new System.Drawing.Size(214, 32);
            this.btnAluCur.TabIndex = 5;
            this.btnAluCur.Text = "Mostrar Alumnos de un Curso";
            this.btnAluCur.UseVisualStyleBackColor = true;
            this.btnAluCur.Click += new System.EventHandler(this.btnAluCur_Click);
            // 
            // btnDatNom
            // 
            this.btnDatNom.Location = new System.Drawing.Point(23, 263);
            this.btnDatNom.Name = "btnDatNom";
            this.btnDatNom.Size = new System.Drawing.Size(214, 32);
            this.btnDatNom.TabIndex = 4;
            this.btnDatNom.Text = "Mostrar Datos de Alumno por Nombre";
            this.btnDatNom.UseVisualStyleBackColor = true;
            this.btnDatNom.Click += new System.EventHandler(this.btnDatNom_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(23, 205);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(214, 32);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar por orden alfabético";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnLisAlu
            // 
            this.btnLisAlu.Location = new System.Drawing.Point(23, 148);
            this.btnLisAlu.Name = "btnLisAlu";
            this.btnLisAlu.Size = new System.Drawing.Size(214, 32);
            this.btnLisAlu.TabIndex = 2;
            this.btnLisAlu.Text = "Mostrar Lista de Alumnos";
            this.btnLisAlu.UseVisualStyleBackColor = true;
            this.btnLisAlu.Click += new System.EventHandler(this.btnLisAlu_Click);
            // 
            // btnEliAlu
            // 
            this.btnEliAlu.Location = new System.Drawing.Point(23, 94);
            this.btnEliAlu.Name = "btnEliAlu";
            this.btnEliAlu.Size = new System.Drawing.Size(214, 32);
            this.btnEliAlu.TabIndex = 1;
            this.btnEliAlu.Text = "Eliminar Alumno";
            this.btnEliAlu.UseVisualStyleBackColor = true;
            this.btnEliAlu.Click += new System.EventHandler(this.btnEliAlu_Click);
            // 
            // btnIntAlu
            // 
            this.btnIntAlu.Location = new System.Drawing.Point(23, 36);
            this.btnIntAlu.Name = "btnIntAlu";
            this.btnIntAlu.Size = new System.Drawing.Size(214, 32);
            this.btnIntAlu.TabIndex = 0;
            this.btnIntAlu.Text = "Introducir Alumno";
            this.btnIntAlu.UseVisualStyleBackColor = true;
            this.btnIntAlu.Click += new System.EventHandler(this.btnIntAlu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMediaMenor);
            this.groupBox2.Controls.Add(this.btnMediaMayor);
            this.groupBox2.Controls.Add(this.btnEliNot);
            this.groupBox2.Controls.Add(this.btnNotAlu);
            this.groupBox2.Location = new System.Drawing.Point(344, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 379);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notas";
            // 
            // btnMediaMenor
            // 
            this.btnMediaMenor.Location = new System.Drawing.Point(35, 205);
            this.btnMediaMenor.Name = "btnMediaMenor";
            this.btnMediaMenor.Size = new System.Drawing.Size(206, 32);
            this.btnMediaMenor.TabIndex = 3;
            this.btnMediaMenor.Text = "Alumnos con media < 5";
            this.btnMediaMenor.UseVisualStyleBackColor = true;
            this.btnMediaMenor.Click += new System.EventHandler(this.btnMediaMenor_Click);
            // 
            // btnMediaMayor
            // 
            this.btnMediaMayor.Location = new System.Drawing.Point(35, 148);
            this.btnMediaMayor.Name = "btnMediaMayor";
            this.btnMediaMayor.Size = new System.Drawing.Size(206, 32);
            this.btnMediaMayor.TabIndex = 2;
            this.btnMediaMayor.Text = "Alumnos con media >= 5";
            this.btnMediaMayor.UseVisualStyleBackColor = true;
            this.btnMediaMayor.Click += new System.EventHandler(this.btnMediaMayor_Click);
            // 
            // btnEliNot
            // 
            this.btnEliNot.Location = new System.Drawing.Point(35, 94);
            this.btnEliNot.Name = "btnEliNot";
            this.btnEliNot.Size = new System.Drawing.Size(206, 32);
            this.btnEliNot.TabIndex = 1;
            this.btnEliNot.Text = "Eliminar notas de Alumno";
            this.btnEliNot.UseVisualStyleBackColor = true;
            this.btnEliNot.Click += new System.EventHandler(this.btnEliNot_Click);
            // 
            // btnNotAlu
            // 
            this.btnNotAlu.Location = new System.Drawing.Point(35, 36);
            this.btnNotAlu.Name = "btnNotAlu";
            this.btnNotAlu.Size = new System.Drawing.Size(206, 32);
            this.btnNotAlu.TabIndex = 0;
            this.btnNotAlu.Text = "Añadir notas a Alumno";
            this.btnNotAlu.UseVisualStyleBackColor = true;
            this.btnNotAlu.Click += new System.EventHandler(this.btnNotAlu_Click);
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 404);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAlumnos";
            this.Text = "FormAlumnos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAluCur;
        private System.Windows.Forms.Button btnDatNom;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnLisAlu;
        private System.Windows.Forms.Button btnEliAlu;
        private System.Windows.Forms.Button btnIntAlu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMediaMenor;
        private System.Windows.Forms.Button btnMediaMayor;
        private System.Windows.Forms.Button btnEliNot;
        private System.Windows.Forms.Button btnNotAlu;
    }
}