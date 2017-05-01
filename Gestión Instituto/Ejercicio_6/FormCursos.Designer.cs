namespace Ejercicio_6
{
    partial class FormCursos
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
            this.btnAgrCur = new System.Windows.Forms.Button();
            this.btnEliCur = new System.Windows.Forms.Button();
            this.btnMosCur = new System.Windows.Forms.Button();
            this.btnMosAluCur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgrCur
            // 
            this.btnAgrCur.Location = new System.Drawing.Point(57, 24);
            this.btnAgrCur.Name = "btnAgrCur";
            this.btnAgrCur.Size = new System.Drawing.Size(168, 34);
            this.btnAgrCur.TabIndex = 0;
            this.btnAgrCur.Text = "Añadir Curso";
            this.btnAgrCur.UseVisualStyleBackColor = true;
            this.btnAgrCur.Click += new System.EventHandler(this.btnAgrCur_Click);
            // 
            // btnEliCur
            // 
            this.btnEliCur.Location = new System.Drawing.Point(57, 80);
            this.btnEliCur.Name = "btnEliCur";
            this.btnEliCur.Size = new System.Drawing.Size(168, 34);
            this.btnEliCur.TabIndex = 1;
            this.btnEliCur.Text = "Eliminar Curso";
            this.btnEliCur.UseVisualStyleBackColor = true;
            this.btnEliCur.Click += new System.EventHandler(this.btnEliCur_Click);
            // 
            // btnMosCur
            // 
            this.btnMosCur.Location = new System.Drawing.Point(57, 136);
            this.btnMosCur.Name = "btnMosCur";
            this.btnMosCur.Size = new System.Drawing.Size(168, 34);
            this.btnMosCur.TabIndex = 2;
            this.btnMosCur.Text = "Mostrar Cursos";
            this.btnMosCur.UseVisualStyleBackColor = true;
            this.btnMosCur.Click += new System.EventHandler(this.btnMosCur_Click);
            // 
            // btnMosAluCur
            // 
            this.btnMosAluCur.Location = new System.Drawing.Point(57, 195);
            this.btnMosAluCur.Name = "btnMosAluCur";
            this.btnMosAluCur.Size = new System.Drawing.Size(168, 34);
            this.btnMosAluCur.TabIndex = 3;
            this.btnMosAluCur.Text = "Mostrar Alumnos de un Curso";
            this.btnMosAluCur.UseVisualStyleBackColor = true;
            this.btnMosAluCur.Click += new System.EventHandler(this.btnMosAluCur_Click);
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnMosAluCur);
            this.Controls.Add(this.btnMosCur);
            this.Controls.Add(this.btnEliCur);
            this.Controls.Add(this.btnAgrCur);
            this.Name = "FormCursos";
            this.Text = "FormCursos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgrCur;
        private System.Windows.Forms.Button btnEliCur;
        private System.Windows.Forms.Button btnMosCur;
        private System.Windows.Forms.Button btnMosAluCur;
    }
}