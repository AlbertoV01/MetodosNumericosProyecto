namespace Métodos_Numéricos_401
{
    partial class Formulario_Falsa_Posición
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
            this.tb_Ea = new System.Windows.Forms.TextBox();
            this.tb_xranterior = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_FuncionFP = new System.Windows.Forms.TextBox();
            this.btn_Calcular_FalsaPosicion = new System.Windows.Forms.Button();
            this.tb_Xu = new System.Windows.Forms.TextBox();
            this.tb_Xl = new System.Windows.Forms.TextBox();
            this.tb_Es = new System.Windows.Forms.TextBox();
            this.tb_P = new System.Windows.Forms.TextBox();
            this.dgv_FalsaPosicion = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxlfxr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ERP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FalsaPosicion)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Ea
            // 
            this.tb_Ea.Location = new System.Drawing.Point(29, 35);
            this.tb_Ea.Name = "tb_Ea";
            this.tb_Ea.Size = new System.Drawing.Size(95, 20);
            this.tb_Ea.TabIndex = 27;
            this.tb_Ea.Text = "100";
            this.tb_Ea.Visible = false;
            // 
            // tb_xranterior
            // 
            this.tb_xranterior.Location = new System.Drawing.Point(29, 64);
            this.tb_xranterior.Name = "tb_xranterior";
            this.tb_xranterior.Size = new System.Drawing.Size(95, 20);
            this.tb_xranterior.TabIndex = 26;
            this.tb_xranterior.Text = "0";
            this.tb_xranterior.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Xu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Xl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Es";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "P";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "FUNCIÓN";
            // 
            // tb_FuncionFP
            // 
            this.tb_FuncionFP.Location = new System.Drawing.Point(301, 27);
            this.tb_FuncionFP.Multiline = true;
            this.tb_FuncionFP.Name = "tb_FuncionFP";
            this.tb_FuncionFP.Size = new System.Drawing.Size(201, 28);
            this.tb_FuncionFP.TabIndex = 20;
            this.tb_FuncionFP.Text = "(667.38/x)*(1-EXP(-0.146843*x))-40";
            this.tb_FuncionFP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Calcular_FalsaPosicion
            // 
            this.btn_Calcular_FalsaPosicion.Location = new System.Drawing.Point(663, 115);
            this.btn_Calcular_FalsaPosicion.Name = "btn_Calcular_FalsaPosicion";
            this.btn_Calcular_FalsaPosicion.Size = new System.Drawing.Size(60, 23);
            this.btn_Calcular_FalsaPosicion.TabIndex = 19;
            this.btn_Calcular_FalsaPosicion.Text = "Calcular";
            this.btn_Calcular_FalsaPosicion.UseVisualStyleBackColor = true;
            this.btn_Calcular_FalsaPosicion.Click += new System.EventHandler(this.btn_Calcular_FalsaPosicion_Click);
            // 
            // tb_Xu
            // 
            this.tb_Xu.Location = new System.Drawing.Point(347, 117);
            this.tb_Xu.Name = "tb_Xu";
            this.tb_Xu.Size = new System.Drawing.Size(95, 20);
            this.tb_Xu.TabIndex = 18;
            this.tb_Xu.Text = "16";
            this.tb_Xu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Xu_KeyPress);
            // 
            // tb_Xl
            // 
            this.tb_Xl.Location = new System.Drawing.Point(241, 117);
            this.tb_Xl.Name = "tb_Xl";
            this.tb_Xl.Size = new System.Drawing.Size(95, 20);
            this.tb_Xl.TabIndex = 17;
            this.tb_Xl.Text = "12";
            this.tb_Xl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Xl_KeyPress);
            // 
            // tb_Es
            // 
            this.tb_Es.Location = new System.Drawing.Point(135, 117);
            this.tb_Es.Name = "tb_Es";
            this.tb_Es.Size = new System.Drawing.Size(95, 20);
            this.tb_Es.TabIndex = 16;
            this.tb_Es.Text = "0.5";
            this.tb_Es.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Es_KeyPress);
            // 
            // tb_P
            // 
            this.tb_P.Location = new System.Drawing.Point(29, 117);
            this.tb_P.Name = "tb_P";
            this.tb_P.Size = new System.Drawing.Size(95, 20);
            this.tb_P.TabIndex = 15;
            this.tb_P.Text = "14.7802";
            this.tb_P.TextChanged += new System.EventHandler(this.tb_P_TextChanged);
            this.tb_P.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_P_KeyPress);
            // 
            // dgv_FalsaPosicion
            // 
            this.dgv_FalsaPosicion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_FalsaPosicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FalsaPosicion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.xl,
            this.xu,
            this.fxl,
            this.fxu,
            this.xr,
            this.fxr,
            this.fxlfxr,
            this.ERP,
            this.Ea});
            this.dgv_FalsaPosicion.Location = new System.Drawing.Point(24, 144);
            this.dgv_FalsaPosicion.Name = "dgv_FalsaPosicion";
            this.dgv_FalsaPosicion.RowHeadersVisible = false;
            this.dgv_FalsaPosicion.Size = new System.Drawing.Size(831, 400);
            this.dgv_FalsaPosicion.TabIndex = 28;
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.Name = "i";
            // 
            // xl
            // 
            this.xl.HeaderText = "xl";
            this.xl.Name = "xl";
            // 
            // xu
            // 
            this.xu.HeaderText = "xu";
            this.xu.Name = "xu";
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
            // xr
            // 
            this.xr.HeaderText = "xr";
            this.xr.Name = "xr";
            // 
            // fxr
            // 
            this.fxr.HeaderText = "fxr";
            this.fxr.Name = "fxr";
            // 
            // fxlfxr
            // 
            this.fxlfxr.HeaderText = "fxlfxr";
            this.fxlfxr.Name = "fxlfxr";
            // 
            // ERP
            // 
            this.ERP.HeaderText = "ERP";
            this.ERP.Name = "ERP";
            // 
            // Ea
            // 
            this.Ea.HeaderText = "Ea";
            this.Ea.Name = "Ea";
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(795, 115);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(60, 23);
            this.btn_Volver.TabIndex = 29;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(729, 115);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(60, 23);
            this.btn_Limpiar.TabIndex = 30;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // Formulario_Falsa_Posición
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 668);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.dgv_FalsaPosicion);
            this.Controls.Add(this.tb_Ea);
            this.Controls.Add(this.tb_xranterior);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_FuncionFP);
            this.Controls.Add(this.btn_Calcular_FalsaPosicion);
            this.Controls.Add(this.tb_Xu);
            this.Controls.Add(this.tb_Xl);
            this.Controls.Add(this.tb_Es);
            this.Controls.Add(this.tb_P);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario_Falsa_Posición";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario_Falsa_Posición";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FalsaPosicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Ea;
        private System.Windows.Forms.TextBox tb_xranterior;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_FuncionFP;
        private System.Windows.Forms.Button btn_Calcular_FalsaPosicion;
        private System.Windows.Forms.TextBox tb_Xu;
        private System.Windows.Forms.TextBox tb_Xl;
        private System.Windows.Forms.TextBox tb_Es;
        private System.Windows.Forms.TextBox tb_P;
        private System.Windows.Forms.DataGridView dgv_FalsaPosicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn xl;
        private System.Windows.Forms.DataGridViewTextBoxColumn xu;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxl;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxu;
        private System.Windows.Forms.DataGridViewTextBoxColumn xr;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxr;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxlfxr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ERP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ea;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}