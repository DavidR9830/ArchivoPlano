
namespace ArchivosPlanos
{
    partial class Archivosplanos
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
            this.txtvisual = new System.Windows.Forms.TextBox();
            this.btnabrir = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtvisual
            // 
            this.txtvisual.Location = new System.Drawing.Point(13, 12);
            this.txtvisual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtvisual.Multiline = true;
            this.txtvisual.Name = "txtvisual";
            this.txtvisual.Size = new System.Drawing.Size(703, 444);
            this.txtvisual.TabIndex = 0;
            // 
            // btnabrir
            // 
            this.btnabrir.Location = new System.Drawing.Point(757, 156);
            this.btnabrir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(138, 46);
            this.btnabrir.TabIndex = 1;
            this.btnabrir.Text = "Abrir";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(757, 226);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(138, 46);
            this.btnmodificar.TabIndex = 2;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(757, 378);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(138, 45);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Archivosplanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.txtvisual);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Archivosplanos";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvisual;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

