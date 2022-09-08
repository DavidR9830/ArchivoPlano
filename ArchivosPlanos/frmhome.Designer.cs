namespace ArchivosPlanos
{
    partial class frmhome
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
            this.btnTxt = new System.Windows.Forms.Button();
            this.btXml = new System.Windows.Forms.Button();
            this.btnCsv = new System.Windows.Forms.Button();
            this.btnRtf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTxt
            // 
            this.btnTxt.Location = new System.Drawing.Point(123, 173);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(75, 23);
            this.btnTxt.TabIndex = 0;
            this.btnTxt.Text = "TXT";
            this.btnTxt.UseVisualStyleBackColor = true;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // btXml
            // 
            this.btXml.Location = new System.Drawing.Point(273, 173);
            this.btXml.Name = "btXml";
            this.btXml.Size = new System.Drawing.Size(75, 23);
            this.btXml.TabIndex = 1;
            this.btXml.Text = "XML";
            this.btXml.UseVisualStyleBackColor = true;
            this.btXml.Click += new System.EventHandler(this.btXml_Click);
            // 
            // btnCsv
            // 
            this.btnCsv.Location = new System.Drawing.Point(394, 173);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(75, 23);
            this.btnCsv.TabIndex = 2;
            this.btnCsv.Text = "CSV";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // btnRtf
            // 
            this.btnRtf.Location = new System.Drawing.Point(558, 173);
            this.btnRtf.Name = "btnRtf";
            this.btnRtf.Size = new System.Drawing.Size(75, 23);
            this.btnRtf.TabIndex = 3;
            this.btnRtf.Text = "RTF";
            this.btnRtf.UseVisualStyleBackColor = true;
            this.btnRtf.Click += new System.EventHandler(this.btnRtf_Click);
            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRtf);
            this.Controls.Add(this.btnCsv);
            this.Controls.Add(this.btXml);
            this.Controls.Add(this.btnTxt);
            this.Name = "frmhome";
            this.Text = "frmInicio";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTxt;
        private Button btXml;
        private Button btnCsv;
        private Button btnRtf;
    }
}