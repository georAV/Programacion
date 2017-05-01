namespace Ejercicio_6
{
    partial class FormInicial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGesCur = new System.Windows.Forms.Button();
            this.btnGesAlu = new System.Windows.Forms.Button();
            this.btnGesPro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGesCur
            // 
            this.btnGesCur.Location = new System.Drawing.Point(105, 55);
            this.btnGesCur.Name = "btnGesCur";
            this.btnGesCur.Size = new System.Drawing.Size(145, 45);
            this.btnGesCur.TabIndex = 0;
            this.btnGesCur.Text = "Gestión Cursos";
            this.btnGesCur.UseVisualStyleBackColor = true;
            this.btnGesCur.Click += new System.EventHandler(this.btnGesCur_Click);
            // 
            // btnGesAlu
            // 
            this.btnGesAlu.Location = new System.Drawing.Point(105, 122);
            this.btnGesAlu.Name = "btnGesAlu";
            this.btnGesAlu.Size = new System.Drawing.Size(145, 45);
            this.btnGesAlu.TabIndex = 1;
            this.btnGesAlu.Text = "Gestión Alumnos";
            this.btnGesAlu.UseVisualStyleBackColor = true;
            this.btnGesAlu.Click += new System.EventHandler(this.btnGesAlu_Click);
            // 
            // btnGesPro
            // 
            this.btnGesPro.Location = new System.Drawing.Point(105, 192);
            this.btnGesPro.Name = "btnGesPro";
            this.btnGesPro.Size = new System.Drawing.Size(145, 45);
            this.btnGesPro.TabIndex = 2;
            this.btnGesPro.Text = "Gestión Profesores";
            this.btnGesPro.UseVisualStyleBackColor = true;
            this.btnGesPro.Click += new System.EventHandler(this.btnGesPro_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 296);
            this.Controls.Add(this.btnGesPro);
            this.Controls.Add(this.btnGesAlu);
            this.Controls.Add(this.btnGesCur);
            this.Name = "FormInicial";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGesCur;
        private System.Windows.Forms.Button btnGesAlu;
        private System.Windows.Forms.Button btnGesPro;
    }
}

