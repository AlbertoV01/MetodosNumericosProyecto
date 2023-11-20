namespace Métodos_Numéricos_401
{
    partial class Formulario_Punto_Fijo
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
            this.dgv_PuntoFijo = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_xi = new System.Windows.Forms.TextBox();
            this.tb_Funcion = new System.Windows.Forms.TextBox();
            this.tb_Es = new System.Windows.Forms.TextBox();
            this.tb_P = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Calcular_PuntoFijo = new System.Windows.Forms.Button();
            this.tb_xianterior = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PuntoFijo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PuntoFijo
            // 
            this.dgv_PuntoFijo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PuntoFijo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_PuntoFijo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PuntoFijo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.xi,
            this.erp,
            this.ea});
            this.dgv_PuntoFijo.Location = new System.Drawing.Point(12, 126);
            this.dgv_PuntoFijo.Name = "dgv_PuntoFijo";
            this.dgv_PuntoFijo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_PuntoFijo.RowHeadersVisible = false;
            this.dgv_PuntoFijo.Size = new System.Drawing.Size(837, 330);
            this.dgv_PuntoFijo.TabIndex = 0;
            this.dgv_PuntoFijo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PuntoFijo_CellContentClick);
            // 
            // iteracion
            // 
            this.iteracion.HeaderText = "i";
            this.iteracion.Name = "iteracion";
            // 
            // xi
            // 
            this.xi.HeaderText = "xi+1";
            this.xi.Name = "xi";
            // 
            // erp
            // 
            this.erp.HeaderText = "erp";
            this.erp.Name = "erp";
            // 
            // ea
            // 
            this.ea.HeaderText = "ea";
            this.ea.Name = "ea";
            // 
            // tb_xi
            // 
            this.tb_xi.Location = new System.Drawing.Point(12, 97);
            this.tb_xi.Name = "tb_xi";
            this.tb_xi.Size = new System.Drawing.Size(100, 20);
            this.tb_xi.TabIndex = 1;
            this.tb_xi.Text = "0";
            this.tb_xi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_xi_KeyPress);
            // 
            // tb_Funcion
            // 
            this.tb_Funcion.Location = new System.Drawing.Point(343, 25);
            this.tb_Funcion.Name = "tb_Funcion";
            this.tb_Funcion.Size = new System.Drawing.Size(232, 20);
            this.tb_Funcion.TabIndex = 2;
            this.tb_Funcion.Text = "EXP(-X)";
            this.tb_Funcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Es
            // 
            this.tb_Es.Location = new System.Drawing.Point(118, 97);
            this.tb_Es.Name = "tb_Es";
            this.tb_Es.Size = new System.Drawing.Size(100, 20);
            this.tb_Es.TabIndex = 3;
            this.tb_Es.Text = "0.5";
            this.tb_Es.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Es_KeyPress);
            // 
            // tb_P
            // 
            this.tb_P.Location = new System.Drawing.Point(224, 97);
            this.tb_P.Name = "tb_P";
            this.tb_P.Size = new System.Drawing.Size(100, 20);
            this.tb_P.TabIndex = 4;
            this.tb_P.Text = "0.56714329";
            this.tb_P.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_P_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "FUNCIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "XI + 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Es";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "P";
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(784, 97);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(65, 23);
            this.btn_Volver.TabIndex = 18;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(713, 97);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(65, 23);
            this.btn_Limpiar.TabIndex = 17;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Calcular_PuntoFijo
            // 
            this.btn_Calcular_PuntoFijo.Location = new System.Drawing.Point(642, 97);
            this.btn_Calcular_PuntoFijo.Name = "btn_Calcular_PuntoFijo";
            this.btn_Calcular_PuntoFijo.Size = new System.Drawing.Size(65, 23);
            this.btn_Calcular_PuntoFijo.TabIndex = 16;
            this.btn_Calcular_PuntoFijo.Text = "Calcular";
            this.btn_Calcular_PuntoFijo.UseVisualStyleBackColor = true;
            this.btn_Calcular_PuntoFijo.Click += new System.EventHandler(this.btn_Calcular_PuntoFijo_Click);
            // 
            // tb_xianterior
            // 
            this.tb_xianterior.Location = new System.Drawing.Point(15, 25);
            this.tb_xianterior.Name = "tb_xianterior";
            this.tb_xianterior.Size = new System.Drawing.Size(100, 20);
            this.tb_xianterior.TabIndex = 19;
            this.tb_xianterior.Text = "0";
            this.tb_xianterior.Visible = false;
            // 
            // Formulario_Punto_Fijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 629);
            this.Controls.Add(this.tb_xianterior);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Calcular_PuntoFijo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_P);
            this.Controls.Add(this.tb_Es);
            this.Controls.Add(this.tb_Funcion);
            this.Controls.Add(this.tb_xi);
            this.Controls.Add(this.dgv_PuntoFijo);
            this.Name = "Formulario_Punto_Fijo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario_Punto_Fijo";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PuntoFijo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PuntoFijo;
        private System.Windows.Forms.TextBox tb_xi;
        private System.Windows.Forms.TextBox tb_Funcion;
        private System.Windows.Forms.TextBox tb_Es;
        private System.Windows.Forms.TextBox tb_P;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Calcular_PuntoFijo;
        private System.Windows.Forms.TextBox tb_xianterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn erp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ea;
    }
}