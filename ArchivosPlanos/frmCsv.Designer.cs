
namespace ArchivosPlanos
{
    partial class frmCsv
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
            this.btnLeerCSV = new System.Windows.Forms.Button();
            this.btnModificarCSV = new System.Windows.Forms.Button();
            this.dgdCSV = new System.Windows.Forms.DataGridView();
            this.btnCrearCSV = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeerCSV
            // 
            this.btnLeerCSV.Location = new System.Drawing.Point(1152, 328);
            this.btnLeerCSV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLeerCSV.Name = "btnLeerCSV";
            this.btnLeerCSV.Size = new System.Drawing.Size(88, 27);
            this.btnLeerCSV.TabIndex = 2;
            this.btnLeerCSV.Text = "Leer";
            this.btnLeerCSV.UseVisualStyleBackColor = true;
            this.btnLeerCSV.Click += new System.EventHandler(this.BtnLeerCSV_Click);
            // 
            // btnModificarCSV
            // 
            this.btnModificarCSV.Location = new System.Drawing.Point(1152, 422);
            this.btnModificarCSV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificarCSV.Name = "btnModificarCSV";
            this.btnModificarCSV.Size = new System.Drawing.Size(88, 27);
            this.btnModificarCSV.TabIndex = 3;
            this.btnModificarCSV.Text = "Modificar";
            this.btnModificarCSV.UseVisualStyleBackColor = true;
            this.btnModificarCSV.Click += new System.EventHandler(this.btnModificarCSV_Click);
            // 
            // dgdCSV
            // 
            this.dgdCSV.AllowUserToDeleteRows = false;
            this.dgdCSV.AllowUserToOrderColumns = true;
            this.dgdCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdCSV.Location = new System.Drawing.Point(464, 15);
            this.dgdCSV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgdCSV.Name = "dgdCSV";
            this.dgdCSV.ReadOnly = true;
            this.dgdCSV.Size = new System.Drawing.Size(622, 583);
            this.dgdCSV.TabIndex = 5;
            // 
            // btnCrearCSV
            // 
            this.btnCrearCSV.Location = new System.Drawing.Point(1152, 241);
            this.btnCrearCSV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCrearCSV.Name = "btnCrearCSV";
            this.btnCrearCSV.Size = new System.Drawing.Size(88, 27);
            this.btnCrearCSV.TabIndex = 1;
            this.btnCrearCSV.Text = "Crear";
            this.btnCrearCSV.UseVisualStyleBackColor = true;
            this.btnCrearCSV.Click += new System.EventHandler(this.btnCrearCSV_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1152, 510);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 27);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(14, 14);
            this.txtArchivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtArchivo.Multiline = true;
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(443, 583);
            this.txtArchivo.TabIndex = 6;
            // 
            // frmCsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 612);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrearCSV);
            this.Controls.Add(this.dgdCSV);
            this.Controls.Add(this.btnModificarCSV);
            this.Controls.Add(this.btnLeerCSV);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmCsv";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgdCSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLeerCSV;
        private System.Windows.Forms.Button btnModificarCSV;
        private System.Windows.Forms.DataGridView dgdCSV;
        private System.Windows.Forms.Button btnCrearCSV;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtArchivo;
    }
}

