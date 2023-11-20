namespace Métodos_Numéricos_401
{
    partial class Formulario_Biseccion
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
            this.dgv_Biseccion = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxl_fxr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Erp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_P = new System.Windows.Forms.TextBox();
            this.tb_Es = new System.Windows.Forms.TextBox();
            this.tb_Xl = new System.Windows.Forms.TextBox();
            this.tb_Xu = new System.Windows.Forms.TextBox();
            this.btn_Calcular_Biseccion = new System.Windows.Forms.Button();
            this.tb_Funcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_xranterior = new System.Windows.Forms.TextBox();
            this.tb_Ea = new System.Windows.Forms.TextBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Biseccion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Biseccion
            // 
            this.dgv_Biseccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Biseccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Biseccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.Xl,
            this.Xu,
            this.Xr,
            this.fxl,
            this.fxu,
            this.fxr,
            this.fxl_fxr,
            this.Erp,
            this.Ea});
            this.dgv_Biseccion.Location = new System.Drawing.Point(12, 141);
            this.dgv_Biseccion.Name = "dgv_Biseccion";
            this.dgv_Biseccion.RowHeadersVisible = false;
            this.dgv_Biseccion.Size = new System.Drawing.Size(836, 393);
            this.dgv_Biseccion.TabIndex = 0;
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.Name = "i";
            // 
            // Xl
            // 
            this.Xl.HeaderText = "Xl";
            this.Xl.Name = "Xl";
            // 
            // Xu
            // 
            this.Xu.HeaderText = "Xu";
            this.Xu.Name = "Xu";
            // 
            // Xr
            // 
            this.Xr.HeaderText = "Xr";
            this.Xr.Name = "Xr";
            // 
            // fxl
            // 
            this.fxl.HeaderText = "fxl";
            this.fxl.Name = "fxl";
            // 
            // fxu
            // 
            this.fxu.HeaderText = "fxu";
            this.fxu.Name = "fxu";
            // 
            // fxr
            // 
            this.fxr.HeaderText = "fxr";
            this.fxr.Name = "fxr";
            // 
            // fxl_fxr
            // 
            this.fxl_fxr.HeaderText = "fxl*fxr";
            this.fxl_fxr.Name = "fxl_fxr";
            // 
            // Erp
            // 
            this.Erp.HeaderText = "ERP";
            this.Erp.Name = "Erp";
            // 
            // Ea
            // 
            this.Ea.HeaderText = "Ea";
            this.Ea.Name = "Ea";
            // 
            // tb_P
            // 
            this.tb_P.Location = new System.Drawing.Point(40, 115);
            this.tb_P.Name = "tb_P";
            this.tb_P.Size = new System.Drawing.Size(100, 20);
            this.tb_P.TabIndex = 1;
            this.tb_P.Text = "14.7802";
            this.tb_P.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_P_KeyPress);
            // 
            // tb_Es
            // 
            this.tb_Es.Location = new System.Drawing.Point(173, 115);
            this.tb_Es.Name = "tb_Es";
            this.tb_Es.Size = new System.Drawing.Size(100, 20);
            this.tb_Es.TabIndex = 2;
            this.tb_Es.Text = "0.5";
            this.tb_Es.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Es_KeyPress);
            // 
            // tb_Xl
            // 
            this.tb_Xl.Location = new System.Drawing.Point(304, 115);
            this.tb_Xl.Name = "tb_Xl";
            this.tb_Xl.Size = new System.Drawing.Size(100, 20);
            this.tb_Xl.TabIndex = 3;
            this.tb_Xl.Text = "12";
            this.tb_Xl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Xl_KeyPress);
            // 
            // tb_Xu
            // 
            this.tb_Xu.Location = new System.Drawing.Point(432, 114);
            this.tb_Xu.Name = "tb_Xu";
            this.tb_Xu.Size = new System.Drawing.Size(100, 20);
            this.tb_Xu.TabIndex = 4;
            this.tb_Xu.Text = "16";
            this.tb_Xu.Enter += new System.EventHandler(this.tb_Xu_Enter);
            this.tb_Xu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Xu_KeyPress);
            // 
            // btn_Calcular_Biseccion
            // 
            this.btn_Calcular_Biseccion.Location = new System.Drawing.Point(641, 112);
            this.btn_Calcular_Biseccion.Name = "btn_Calcular_Biseccion";
            this.btn_Calcular_Biseccion.Size = new System.Drawing.Size(65, 23);
            this.btn_Calcular_Biseccion.TabIndex = 5;
            this.btn_Calcular_Biseccion.Text = "Calcular";
            this.btn_Calcular_Biseccion.UseVisualStyleBackColor = true;
            this.btn_Calcular_Biseccion.Click += new System.EventHandler(this.btn_Calcular_Biseccion_Click);
            // 
            // tb_Funcion
            // 
            this.tb_Funcion.Location = new System.Drawing.Point(337, 25);
            this.tb_Funcion.Multiline = true;
            this.tb_Funcion.Name = "tb_Funcion";
            this.tb_Funcion.Size = new System.Drawing.Size(206, 28);
            this.tb_Funcion.TabIndex = 6;
            this.tb_Funcion.Text = "(667.38/x)*(1-EXP(-0.146843*x))-40";
            this.tb_Funcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "FUNCION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "P";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Es";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Xl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Xu";
            // 
            // tb_xranterior
            // 
            this.tb_xranterior.Location = new System.Drawing.Point(40, 62);
            this.tb_xranterior.Name = "tb_xranterior";
            this.tb_xranterior.Size = new System.Drawing.Size(100, 20);
            this.tb_xranterior.TabIndex = 12;
            this.tb_xranterior.Text = "0";
            this.tb_xranterior.Visible = false;
            // 
            // tb_Ea
            // 
            this.tb_Ea.Location = new System.Drawing.Point(40, 33);
            this.tb_Ea.Name = "tb_Ea";
            this.tb_Ea.Size = new System.Drawing.Size(100, 20);
            this.tb_Ea.TabIndex = 13;
            this.tb_Ea.Text = "100";
            this.tb_Ea.Visible = false;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(712, 112);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(65, 23);
            this.btn_Limpiar.TabIndex = 14;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(783, 113);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(65, 23);
            this.btn_Volver.TabIndex = 15;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // Formulario_Biseccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 668);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.tb_Ea);
            this.Controls.Add(this.tb_xranterior);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Funcion);
            this.Controls.Add(this.btn_Calcular_Biseccion);
            this.Controls.Add(this.tb_Xu);
            this.Controls.Add(this.tb_Xl);
            this.Controls.Add(this.tb_Es);
            this.Controls.Add(this.tb_P);
            this.Controls.Add(this.dgv_Biseccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario_Biseccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario_Biseccion";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Biseccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Biseccion;
        private System.Windows.Forms.TextBox tb_P;
        private System.Windows.Forms.TextBox tb_Es;
        private System.Windows.Forms.TextBox tb_Xl;
        private System.Windows.Forms.TextBox tb_Xu;
        private System.Windows.Forms.Button btn_Calcular_Biseccion;
        private System.Windows.Forms.TextBox tb_Funcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_xranterior;
        private System.Windows.Forms.TextBox tb_Ea;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xr;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxl;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxu;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxr;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxl_fxr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Erp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ea;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Volver;
    }
}