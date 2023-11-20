namespace Métodos_Numéricos_401
{
    partial class Formulario_Regla_del_Trapecio
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Funcion = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_resultado = new System.Windows.Forms.TextBox();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_valorverdadero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Error = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(377, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "FUNCION";
            // 
            // tb_Funcion
            // 
            this.tb_Funcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tb_Funcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Funcion.ForeColor = System.Drawing.Color.LightGray;
            this.tb_Funcion.Location = new System.Drawing.Point(184, 65);
            this.tb_Funcion.Name = "tb_Funcion";
            this.tb_Funcion.Size = new System.Drawing.Size(435, 20);
            this.tb_Funcion.TabIndex = 48;
            this.tb_Funcion.Text = "-(x^2)+(8*x)-12";
            this.tb_Funcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Salir
            // 
            this.btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.LightSalmon;
            this.btn_Salir.Location = new System.Drawing.Point(184, 472);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(97, 23);
            this.btn_Salir.TabIndex = 67;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.ForeColor = System.Drawing.Color.LightSalmon;
            this.btn_Limpiar.Location = new System.Drawing.Point(349, 472);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(110, 23);
            this.btn_Limpiar.TabIndex = 66;
            this.btn_Limpiar.Text = "LIMPIAR";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calcular.ForeColor = System.Drawing.Color.LightSalmon;
            this.btn_Calcular.Location = new System.Drawing.Point(522, 472);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(97, 23);
            this.btn_Calcular.TabIndex = 65;
            this.btn_Calcular.Text = "CALCULAR";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(288, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 31);
            this.label2.TabIndex = 68;
            this.label2.Text = "I=((b*a) ( f(a) + f(b) ))/2\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSalmon;
            this.label3.Location = new System.Drawing.Point(253, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 31);
            this.label3.TabIndex = 69;
            this.label3.Text = "REGLA DEL TRAPECIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(332, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 31);
            this.label4.TabIndex = 70;
            this.label4.Text = "RESULTADO";
            // 
            // tb_resultado
            // 
            this.tb_resultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tb_resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tb_resultado.Location = new System.Drawing.Point(184, 313);
            this.tb_resultado.Name = "tb_resultado";
            this.tb_resultado.ReadOnly = true;
            this.tb_resultado.Size = new System.Drawing.Size(435, 20);
            this.tb_resultado.TabIndex = 71;
            this.tb_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_a
            // 
            this.tb_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tb_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_a.ForeColor = System.Drawing.Color.LightGray;
            this.tb_a.Location = new System.Drawing.Point(184, 126);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(97, 20);
            this.tb_a.TabIndex = 72;
            this.tb_a.Text = "3";
            this.tb_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_a_KeyPress);
            // 
            // tb_b
            // 
            this.tb_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tb_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_b.ForeColor = System.Drawing.Color.LightGray;
            this.tb_b.Location = new System.Drawing.Point(522, 126);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(97, 20);
            this.tb_b.TabIndex = 73;
            this.tb_b.Text = "5.5";
            this.tb_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_b_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(226, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 74;
            this.label5.Text = "a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(559, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 75;
            this.label6.Text = "b";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(345, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 76;
            this.label7.Text = "Valor Verdadero";
            // 
            // tb_valorverdadero
            // 
            this.tb_valorverdadero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tb_valorverdadero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_valorverdadero.ForeColor = System.Drawing.Color.LightGray;
            this.tb_valorverdadero.Location = new System.Drawing.Point(349, 126);
            this.tb_valorverdadero.Name = "tb_valorverdadero";
            this.tb_valorverdadero.Size = new System.Drawing.Size(110, 20);
            this.tb_valorverdadero.TabIndex = 77;
            this.tb_valorverdadero.Text = "6";
            this.tb_valorverdadero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_valorverdadero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_valorverdadero_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(224, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(449, 31);
            this.label8.TabIndex = 78;
            this.label8.Text = "ERROR RELATIVO PORCENTUAL";
            // 
            // tb_Error
            // 
            this.tb_Error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tb_Error.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tb_Error.Location = new System.Drawing.Point(184, 417);
            this.tb_Error.Name = "tb_Error";
            this.tb_Error.ReadOnly = true;
            this.tb_Error.Size = new System.Drawing.Size(435, 20);
            this.tb_Error.TabIndex = 79;
            this.tb_Error.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Formulario_Regla_del_Trapecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(872, 629);
            this.Controls.Add(this.tb_Error);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_valorverdadero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.tb_resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Funcion);
            this.Name = "Formulario_Regla_del_Trapecio";
            this.Text = "Formulario_Regla_del_Trapecio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Funcion;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_resultado;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_valorverdadero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Error;
    }
}