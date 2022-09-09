
namespace ArchivosPlanos
{
    partial class frmXml
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
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.btnLeerXML = new System.Windows.Forms.Button();
            this.btnModificarXML = new System.Windows.Forms.Button();
            this.btnEliminarXML = new System.Windows.Forms.Button();
            this.btnCrearXML = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(13, 12);
            this.txtArchivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtArchivo.Multiline = true;
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(703, 444);
            this.txtArchivo.TabIndex = 0;
            // 
            // btnLeerXML
            // 
            this.btnLeerXML.Location = new System.Drawing.Point(757, 156);
            this.btnLeerXML.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLeerXML.Name = "btnLeerXML";
            this.btnLeerXML.Size = new System.Drawing.Size(138, 46);
            this.btnLeerXML.TabIndex = 1;
            this.btnLeerXML.Text = "Leer";
            this.btnLeerXML.UseVisualStyleBackColor = true;
            this.btnLeerXML.Click += new System.EventHandler(this.btnLeerXML_Click);
            // 
            // btnModificarXML
            // 
            this.btnModificarXML.Location = new System.Drawing.Point(757, 226);
            this.btnModificarXML.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificarXML.Name = "btnModificarXML";
            this.btnModificarXML.Size = new System.Drawing.Size(138, 46);
            this.btnModificarXML.TabIndex = 2;
            this.btnModificarXML.Text = "Modificar";
            this.btnModificarXML.UseVisualStyleBackColor = true;
            this.btnModificarXML.Click += new System.EventHandler(this.btnModificarXML_Click);
            // 
            // btnEliminarXML
            // 
            this.btnEliminarXML.Location = new System.Drawing.Point(757, 300);
            this.btnEliminarXML.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminarXML.Name = "btnEliminarXML";
            this.btnEliminarXML.Size = new System.Drawing.Size(138, 45);
            this.btnEliminarXML.TabIndex = 3;
            this.btnEliminarXML.Text = "Eliminar";
            this.btnEliminarXML.UseVisualStyleBackColor = true;
            this.btnEliminarXML.Click += new System.EventHandler(this.btnEliminarXML_Click);
            // 
            // btnCrearXML
            // 
            this.btnCrearXML.Location = new System.Drawing.Point(757, 89);
            this.btnCrearXML.Name = "btnCrearXML";
            this.btnCrearXML.Size = new System.Drawing.Size(138, 49);
            this.btnCrearXML.TabIndex = 4;
            this.btnCrearXML.Text = "Crear";
            this.btnCrearXML.UseVisualStyleBackColor = true;
            this.btnCrearXML.Click += new System.EventHandler(this.btnCrearXML_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(757, 365);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(138, 45);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCrearXML);
            this.Controls.Add(this.btnEliminarXML);
            this.Controls.Add(this.btnModificarXML);
            this.Controls.Add(this.btnLeerXML);
            this.Controls.Add(this.txtArchivo);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmXml";
            this.Text = "Archivos XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button btnLeerXML;
        private System.Windows.Forms.Button btnModificarXML;
        private System.Windows.Forms.Button btnEliminarXML;
        private Button btnCrearXML;
        private Button btnVolver;
    }
}

