namespace Métodos_Numéricos_401
{
    partial class Formulario_Gauss
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Agregar_Ecuacion = new System.Windows.Forms.Button();
            this.cb_Orden_Matriz = new System.Windows.Forms.ComboBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.dgv_MatrizOriginal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MatrizOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Agregar_Ecuacion
            // 
            this.btn_Agregar_Ecuacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Agregar_Ecuacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Agregar_Ecuacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar_Ecuacion.ForeColor = System.Drawing.Color.White;
            this.btn_Agregar_Ecuacion.Location = new System.Drawing.Point(613, 12);
            this.btn_Agregar_Ecuacion.Name = "btn_Agregar_Ecuacion";
            this.btn_Agregar_Ecuacion.Size = new System.Drawing.Size(247, 23);
            this.btn_Agregar_Ecuacion.TabIndex = 0;
            this.btn_Agregar_Ecuacion.Text = "Agregar Matriz";
            this.btn_Agregar_Ecuacion.UseVisualStyleBackColor = true;
            this.btn_Agregar_Ecuacion.Click += new System.EventHandler(this.btn_Agregar_Ecuacion_Click);
            // 
            // cb_Orden_Matriz
            // 
            this.cb_Orden_Matriz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cb_Orden_Matriz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Orden_Matriz.FormattingEnabled = true;
            this.cb_Orden_Matriz.Items.AddRange(new object[] {
            "2x2",
            "3x3",
            "4x4"});
            this.cb_Orden_Matriz.Location = new System.Drawing.Point(613, 41);
            this.cb_Orden_Matriz.Name = "cb_Orden_Matriz";
            this.cb_Orden_Matriz.Size = new System.Drawing.Size(247, 21);
            this.cb_Orden_Matriz.TabIndex = 1;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Calcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calcular.ForeColor = System.Drawing.Color.White;
            this.btn_Calcular.Location = new System.Drawing.Point(613, 68);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(247, 23);
            this.btn_Calcular.TabIndex = 2;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click_1);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.Location = new System.Drawing.Point(613, 97);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(247, 23);
            this.btn_Limpiar.TabIndex = 4;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // dgv_MatrizOriginal
            // 
            this.dgv_MatrizOriginal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MatrizOriginal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_MatrizOriginal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgv_MatrizOriginal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_MatrizOriginal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_MatrizOriginal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MatrizOriginal.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_MatrizOriginal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_MatrizOriginal.Location = new System.Drawing.Point(613, 262);
            this.dgv_MatrizOriginal.Name = "dgv_MatrizOriginal";
            this.dgv_MatrizOriginal.ReadOnly = true;
            this.dgv_MatrizOriginal.RowHeadersVisible = false;
            this.dgv_MatrizOriginal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_MatrizOriginal.Size = new System.Drawing.Size(247, 150);
            this.dgv_MatrizOriginal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(673, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "MATRIZ ORIGINAL";
            // 
            // btn_Salir
            // 
            this.btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(12, 556);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(146, 23);
            this.btn_Salir.TabIndex = 8;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(613, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 108);
            this.listBox1.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Formulario_Gauss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(872, 629);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_MatrizOriginal);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.cb_Orden_Matriz);
            this.Controls.Add(this.btn_Agregar_Ecuacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Formulario_Gauss";
            this.Text = "Formulario_Gauss";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MatrizOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Agregar_Ecuacion;
        private System.Windows.Forms.ComboBox cb_Orden_Matriz;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.DataGridView dgv_MatrizOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}