namespace Métodos_Numéricos_401
{
    partial class Gauss_Seidel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_nota = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ErrorEsperado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ValorInicial = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Ecuaciones = new System.Windows.Forms.ComboBox();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.dgv_Ecuaciones = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Resultados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ecuaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nota
            // 
            this.btn_nota.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_nota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_nota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nota.ForeColor = System.Drawing.Color.White;
            this.btn_nota.Location = new System.Drawing.Point(783, 12);
            this.btn_nota.Name = "btn_nota";
            this.btn_nota.Size = new System.Drawing.Size(75, 23);
            this.btn_nota.TabIndex = 26;
            this.btn_nota.Text = "Nota";
            this.btn_nota.UseVisualStyleBackColor = true;
            this.btn_nota.Click += new System.EventHandler(this.btn_nota_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(782, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Error Esperado";
            // 
            // tb_ErrorEsperado
            // 
            this.tb_ErrorEsperado.Location = new System.Drawing.Point(785, 97);
            this.tb_ErrorEsperado.Name = "tb_ErrorEsperado";
            this.tb_ErrorEsperado.Size = new System.Drawing.Size(72, 20);
            this.tb_ErrorEsperado.TabIndex = 24;
            this.tb_ErrorEsperado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ErrorEsperado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(782, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Valor Inicial";
            // 
            // tb_ValorInicial
            // 
            this.tb_ValorInicial.Location = new System.Drawing.Point(785, 58);
            this.tb_ValorInicial.Name = "tb_ValorInicial";
            this.tb_ValorInicial.Size = new System.Drawing.Size(72, 20);
            this.tb_ValorInicial.TabIndex = 22;
            this.tb_ValorInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ValorInicial_KeyPress);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.Location = new System.Drawing.Point(785, 163);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(72, 48);
            this.btn_Aceptar.TabIndex = 21;
            this.btn_Aceptar.Text = "Agregar\r\nEcuaciones\r\n";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(780, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "N. Ecuaciones";
            // 
            // cb_Ecuaciones
            // 
            this.cb_Ecuaciones.FormattingEnabled = true;
            this.cb_Ecuaciones.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb_Ecuaciones.Location = new System.Drawing.Point(785, 136);
            this.cb_Ecuaciones.Name = "cb_Ecuaciones";
            this.cb_Ecuaciones.Size = new System.Drawing.Size(71, 21);
            this.cb_Ecuaciones.TabIndex = 19;
            this.cb_Ecuaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Ecuaciones_KeyPress);
            // 
            // btn_Volver
            // 
            this.btn_Volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver.ForeColor = System.Drawing.Color.White;
            this.btn_Volver.Location = new System.Drawing.Point(789, 350);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(71, 23);
            this.btn_Volver.TabIndex = 18;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.Location = new System.Drawing.Point(789, 321);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(71, 23);
            this.btn_Limpiar.TabIndex = 17;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Calcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calcular.ForeColor = System.Drawing.Color.White;
            this.btn_Calcular.Location = new System.Drawing.Point(785, 217);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 16;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // dgv_Ecuaciones
            // 
            this.dgv_Ecuaciones.AllowUserToAddRows = false;
            this.dgv_Ecuaciones.AllowUserToDeleteRows = false;
            this.dgv_Ecuaciones.AllowUserToResizeColumns = false;
            this.dgv_Ecuaciones.AllowUserToResizeRows = false;
            this.dgv_Ecuaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Ecuaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgv_Ecuaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Ecuaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Ecuaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ecuaciones.ColumnHeadersVisible = false;
            this.dgv_Ecuaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.b});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Ecuaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Ecuaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_Ecuaciones.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Ecuaciones.Location = new System.Drawing.Point(12, 12);
            this.dgv_Ecuaciones.Name = "dgv_Ecuaciones";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Ecuaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Ecuaciones.RowHeadersVisible = false;
            this.dgv_Ecuaciones.Size = new System.Drawing.Size(760, 273);
            this.dgv_Ecuaciones.TabIndex = 27;
            // 
            // a
            // 
            this.a.HeaderText = "a";
            this.a.Name = "a";
            // 
            // b
            // 
            this.b.HeaderText = "b";
            this.b.Name = "b";
            // 
            // dgv_Resultados
            // 
            this.dgv_Resultados.AllowUserToAddRows = false;
            this.dgv_Resultados.AllowUserToDeleteRows = false;
            this.dgv_Resultados.AllowUserToResizeColumns = false;
            this.dgv_Resultados.AllowUserToResizeRows = false;
            this.dgv_Resultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Resultados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgv_Resultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Resultados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Resultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Resultados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Resultados.EnableHeadersVisualStyles = false;
            this.dgv_Resultados.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Resultados.Location = new System.Drawing.Point(23, 321);
            this.dgv_Resultados.MultiSelect = false;
            this.dgv_Resultados.Name = "dgv_Resultados";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Resultados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Resultados.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(59)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Red;
            this.dgv_Resultados.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Resultados.Size = new System.Drawing.Size(760, 251);
            this.dgv_Resultados.TabIndex = 28;
            // 
            // Gauss_Seidel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(872, 629);
            this.Controls.Add(this.dgv_Resultados);
            this.Controls.Add(this.dgv_Ecuaciones);
            this.Controls.Add(this.btn_nota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_ErrorEsperado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ValorInicial);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Ecuaciones);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Calcular);
            this.Name = "Gauss_Seidel";
            this.Text = "Gauss_Seidel";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ecuaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ErrorEsperado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ValorInicial;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Ecuaciones;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.DataGridView dgv_Ecuaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridView dgv_Resultados;
    }
}