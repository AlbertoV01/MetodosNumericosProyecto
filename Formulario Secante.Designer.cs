namespace Métodos_Numéricos_401
{
    partial class Secante
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_xianterior = new System.Windows.Forms.TextBox();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Calcular_Secante = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_P = new System.Windows.Forms.TextBox();
            this.tb_Es = new System.Windows.Forms.TextBox();
            this.tb_Funcion = new System.Windows.Forms.TextBox();
            this.tb_ximenos1 = new System.Windows.Forms.TextBox();
            this.dgv_Secante = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ximenos1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxi11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_xi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Secante)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "xi-1";
            // 
            // tb_xianterior
            // 
            this.tb_xianterior.Location = new System.Drawing.Point(253, 21);
            this.tb_xianterior.Name = "tb_xianterior";
            this.tb_xianterior.Size = new System.Drawing.Size(100, 20);
            this.tb_xianterior.TabIndex = 46;
            this.tb_xianterior.Text = "0";
            this.tb_xianterior.Visible = false;
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(760, 74);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(100, 23);
            this.btn_Volver.TabIndex = 45;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(760, 103);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(100, 23);
            this.btn_Limpiar.TabIndex = 44;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Calcular_Secante
            // 
            this.btn_Calcular_Secante.Location = new System.Drawing.Point(760, 132);
            this.btn_Calcular_Secante.Name = "btn_Calcular_Secante";
            this.btn_Calcular_Secante.Size = new System.Drawing.Size(100, 23);
            this.btn_Calcular_Secante.TabIndex = 43;
            this.btn_Calcular_Secante.Text = "Calcular";
            this.btn_Calcular_Secante.UseVisualStyleBackColor = true;
            this.btn_Calcular_Secante.Click += new System.EventHandler(this.btn_Calcular_Secante_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "P";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Es";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "FUNCIÓN";
            // 
            // tb_P
            // 
            this.tb_P.Location = new System.Drawing.Point(233, 132);
            this.tb_P.Name = "tb_P";
            this.tb_P.Size = new System.Drawing.Size(100, 20);
            this.tb_P.TabIndex = 39;
            this.tb_P.Text = "1.309799";
            this.tb_P.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_P_KeyPress);
            // 
            // tb_Es
            // 
            this.tb_Es.Location = new System.Drawing.Point(127, 132);
            this.tb_Es.Name = "tb_Es";
            this.tb_Es.Size = new System.Drawing.Size(100, 20);
            this.tb_Es.TabIndex = 38;
            this.tb_Es.Text = "1";
            this.tb_Es.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Es_KeyPress);
            // 
            // tb_Funcion
            // 
            this.tb_Funcion.Location = new System.Drawing.Point(359, 21);
            this.tb_Funcion.Name = "tb_Funcion";
            this.tb_Funcion.Size = new System.Drawing.Size(232, 20);
            this.tb_Funcion.TabIndex = 37;
            this.tb_Funcion.Text = "EXP(-X)-LOG(X)";
            this.tb_Funcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ximenos1
            // 
            this.tb_ximenos1.Location = new System.Drawing.Point(24, 93);
            this.tb_ximenos1.Name = "tb_ximenos1";
            this.tb_ximenos1.Size = new System.Drawing.Size(100, 20);
            this.tb_ximenos1.TabIndex = 36;
            this.tb_ximenos1.Text = "1";
            this.tb_ximenos1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ximenos1_KeyPress);
            // 
            // dgv_Secante
            // 
            this.dgv_Secante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Secante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Secante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.ximenos1,
            this.xi,
            this.fxi,
            this.fxi11,
            this.erp,
            this.ea});
            this.dgv_Secante.Location = new System.Drawing.Point(12, 179);
            this.dgv_Secante.Name = "dgv_Secante";
            this.dgv_Secante.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_Secante.RowHeadersVisible = false;
            this.dgv_Secante.Size = new System.Drawing.Size(848, 236);
            this.dgv_Secante.TabIndex = 35;
            // 
            // iteracion
            // 
            this.iteracion.HeaderText = "i";
            this.iteracion.Name = "iteracion";
            // 
            // ximenos1
            // 
            this.ximenos1.HeaderText = "xi-1";
            this.ximenos1.Name = "ximenos1";
            // 
            // xi
            // 
            this.xi.HeaderText = "xi";
            this.xi.Name = "xi";
            // 
            // fxi
            // 
            this.fxi.HeaderText = "fxi-1";
            this.fxi.Name = "fxi";
            // 
            // fxi11
            // 
            this.fxi11.HeaderText = "f(xi )";
            this.fxi11.Name = "fxi11";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "xi";
            // 
            // tb_xi
            // 
            this.tb_xi.Location = new System.Drawing.Point(24, 132);
            this.tb_xi.Name = "tb_xi";
            this.tb_xi.Size = new System.Drawing.Size(100, 20);
            this.tb_xi.TabIndex = 48;
            this.tb_xi.Text = "1.5";
            this.tb_xi.TextChanged += new System.EventHandler(this.tb_xi_TextChanged);
            this.tb_xi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_xi_KeyPress);
            // 
            // Secante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 629);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_xi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_xianterior);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Calcular_Secante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_P);
            this.Controls.Add(this.tb_Es);
            this.Controls.Add(this.tb_Funcion);
            this.Controls.Add(this.tb_ximenos1);
            this.Controls.Add(this.dgv_Secante);
            this.Name = "Secante";
            this.Text = "Secante";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Secante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_xianterior;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Calcular_Secante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_P;
        private System.Windows.Forms.TextBox tb_Es;
        private System.Windows.Forms.TextBox tb_Funcion;
        private System.Windows.Forms.TextBox tb_ximenos1;
        private System.Windows.Forms.DataGridView dgv_Secante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ximenos1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxi11;
        private System.Windows.Forms.DataGridViewTextBoxColumn erp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ea;
    }
}