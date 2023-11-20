namespace Métodos_Numéricos_401
{
    partial class Formulario_Iterativo_Secuencial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Resultados = new System.Windows.Forms.DataGridView();
            this.dgv_Ecuaciones = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ecuaciones)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Resultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Resultados.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Resultados.EnableHeadersVisualStyles = false;
            this.dgv_Resultados.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Resultados.Location = new System.Drawing.Point(22, 343);
            this.dgv_Resultados.MultiSelect = false;
            this.dgv_Resultados.Name = "dgv_Resultados";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Resultados.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Resultados.RowHeadersVisible = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(59)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Red;
            this.dgv_Resultados.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Resultados.Size = new System.Drawing.Size(760, 251);
            this.dgv_Resultados.TabIndex = 41;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Ecuaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Ecuaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ecuaciones.ColumnHeadersVisible = false;
            this.dgv_Ecuaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.b});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Ecuaciones.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_Ecuaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_Ecuaciones.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Ecuaciones.Location = new System.Drawing.Point(11, 34);
            this.dgv_Ecuaciones.Name = "dgv_Ecuaciones";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Ecuaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_Ecuaciones.RowHeadersVisible = false;
            this.dgv_Ecuaciones.Size = new System.Drawing.Size(760, 273);
            this.dgv_Ecuaciones.TabIndex = 40;
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
            // btn_nota
            // 
            this.btn_nota.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_nota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_nota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nota.ForeColor = System.Drawing.Color.White;
            this.btn_nota.Location = new System.Drawing.Point(784, 12);
            this.btn_nota.Name = "btn_nota";
            this.btn_nota.Size = new System.Drawing.Size(75, 23);
            this.btn_nota.TabIndex = 39;
            this.btn_nota.Text = "Nota";
            this.btn_nota.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(781, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Error Esperado";
            // 
            // tb_ErrorEsperado
            // 
            this.tb_ErrorEsperado.Location = new System.Drawing.Point(784, 93);
            this.tb_ErrorEsperado.Name = "tb_ErrorEsperado";
            this.tb_ErrorEsperado.Size = new System.Drawing.Size(72, 20);
            this.tb_ErrorEsperado.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(784, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Valor Inicial";
            // 
            // tb_ValorInicial
            // 
            this.tb_ValorInicial.Location = new System.Drawing.Point(784, 54);
            this.tb_ValorInicial.Name = "tb_ValorInicial";
            this.tb_ValorInicial.Size = new System.Drawing.Size(72, 20);
            this.tb_ValorInicial.TabIndex = 35;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.Location = new System.Drawing.Point(784, 159);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(72, 48);
            this.btn_Aceptar.TabIndex = 34;
            this.btn_Aceptar.Text = "Agregar\r\nEcuaciones\r\n";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(781, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 33;
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
            this.cb_Ecuaciones.Location = new System.Drawing.Point(784, 132);
            this.cb_Ecuaciones.Name = "cb_Ecuaciones";
            this.cb_Ecuaciones.Size = new System.Drawing.Size(71, 21);
            this.cb_Ecuaciones.TabIndex = 32;
            // 
            // btn_Volver
            // 
            this.btn_Volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver.ForeColor = System.Drawing.Color.White;
            this.btn_Volver.Location = new System.Drawing.Point(784, 372);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(71, 23);
            this.btn_Volver.TabIndex = 31;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.Location = new System.Drawing.Point(784, 343);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(71, 23);
            this.btn_Limpiar.TabIndex = 30;
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
            this.btn_Calcular.Location = new System.Drawing.Point(784, 213);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 29;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            // 
            // Formulario_Iterativo_Secuencial
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
            this.Name = "Formulario_Iterativo_Secuencial";
            this.Text = "Formulario_Iterativo_Secuencial";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ecuaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Resultados;
        private System.Windows.Forms.DataGridView dgv_Ecuaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
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
    }
}