namespace Métodos_Numéricos_401
{
    partial class Formulario_Evaluaciones
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Evaluacion1 = new System.Windows.Forms.Button();
            this.btn_Evaluacion2 = new System.Windows.Forms.Button();
            this.btn_Evaluacion3 = new System.Windows.Forms.Button();
            this.btn_Evaluacion4 = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Salir);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Evaluacion4);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Evaluacion3);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Evaluacion2);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Evaluacion1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Size = new System.Drawing.Size(872, 629);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_Evaluacion1
            // 
            this.btn_Evaluacion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Evaluacion1.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Evaluacion1.Location = new System.Drawing.Point(3, 26);
            this.btn_Evaluacion1.Name = "btn_Evaluacion1";
            this.btn_Evaluacion1.Size = new System.Drawing.Size(284, 23);
            this.btn_Evaluacion1.TabIndex = 0;
            this.btn_Evaluacion1.Text = "EVALUACION 1";
            this.btn_Evaluacion1.UseVisualStyleBackColor = true;
            this.btn_Evaluacion1.Click += new System.EventHandler(this.btn_Evaluacion1_Click);
            // 
            // btn_Evaluacion2
            // 
            this.btn_Evaluacion2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Evaluacion2.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Evaluacion2.Location = new System.Drawing.Point(3, 160);
            this.btn_Evaluacion2.Name = "btn_Evaluacion2";
            this.btn_Evaluacion2.Size = new System.Drawing.Size(284, 23);
            this.btn_Evaluacion2.TabIndex = 1;
            this.btn_Evaluacion2.Text = "EVALUACION 2";
            this.btn_Evaluacion2.UseVisualStyleBackColor = true;
            this.btn_Evaluacion2.Click += new System.EventHandler(this.btn_Evaluacion2_Click);
            // 
            // btn_Evaluacion3
            // 
            this.btn_Evaluacion3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Evaluacion3.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Evaluacion3.Location = new System.Drawing.Point(3, 330);
            this.btn_Evaluacion3.Name = "btn_Evaluacion3";
            this.btn_Evaluacion3.Size = new System.Drawing.Size(284, 23);
            this.btn_Evaluacion3.TabIndex = 2;
            this.btn_Evaluacion3.Text = "EVALUACION 3";
            this.btn_Evaluacion3.UseVisualStyleBackColor = true;
            this.btn_Evaluacion3.Click += new System.EventHandler(this.btn_Evaluacion3_Click);
            // 
            // btn_Evaluacion4
            // 
            this.btn_Evaluacion4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Evaluacion4.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Evaluacion4.Location = new System.Drawing.Point(3, 511);
            this.btn_Evaluacion4.Name = "btn_Evaluacion4";
            this.btn_Evaluacion4.Size = new System.Drawing.Size(284, 23);
            this.btn_Evaluacion4.TabIndex = 3;
            this.btn_Evaluacion4.Text = "EVALUACION 4";
            this.btn_Evaluacion4.UseVisualStyleBackColor = true;
            this.btn_Evaluacion4.Click += new System.EventHandler(this.btn_Evaluacion4_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Salir.Location = new System.Drawing.Point(3, 594);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(284, 23);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Formulario_Evaluaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(872, 629);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Formulario_Evaluaciones";
            this.Text = "Formulario_Evaluaciones";
            this.Load += new System.EventHandler(this.Formulario_Evaluaciones_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Evaluacion4;
        private System.Windows.Forms.Button btn_Evaluacion3;
        private System.Windows.Forms.Button btn_Evaluacion2;
        private System.Windows.Forms.Button btn_Evaluacion1;
        private System.Windows.Forms.Button btn_Salir;
    }
}