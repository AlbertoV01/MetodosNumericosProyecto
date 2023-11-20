namespace Métodos_Numéricos_401
{
    partial class Formulario_Integracion_Numerica
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_reglasimpson13 = new System.Windows.Forms.Button();
            this.btn_regla_trapecio = new System.Windows.Forms.Button();
            this.btn_regla_trapecio_i = new System.Windows.Forms.Button();
            this.btn_regla_simpson_13_i = new System.Windows.Forms.Button();
            this.btn_regla_simpson_38 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Black;
            this.btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salir.Location = new System.Drawing.Point(-1, 477);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Salir.Size = new System.Drawing.Size(105, 35);
            this.btn_Salir.TabIndex = 17;
            this.btn_Salir.Text = "VOLVER";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_reglasimpson13
            // 
            this.btn_reglasimpson13.BackColor = System.Drawing.Color.Black;
            this.btn_reglasimpson13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_reglasimpson13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_reglasimpson13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reglasimpson13.ForeColor = System.Drawing.Color.LightGray;
            this.btn_reglasimpson13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reglasimpson13.Location = new System.Drawing.Point(-1, 232);
            this.btn_reglasimpson13.Name = "btn_reglasimpson13";
            this.btn_reglasimpson13.Size = new System.Drawing.Size(874, 35);
            this.btn_reglasimpson13.TabIndex = 16;
            this.btn_reglasimpson13.Text = "REGLA DE SIMPSON 1/3";
            this.btn_reglasimpson13.UseVisualStyleBackColor = false;
            this.btn_reglasimpson13.Click += new System.EventHandler(this.btn_reglasimpson13_Click);
            // 
            // btn_regla_trapecio
            // 
            this.btn_regla_trapecio.BackColor = System.Drawing.Color.Black;
            this.btn_regla_trapecio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_regla_trapecio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_regla_trapecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regla_trapecio.ForeColor = System.Drawing.Color.LightGray;
            this.btn_regla_trapecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_regla_trapecio.Location = new System.Drawing.Point(-1, 109);
            this.btn_regla_trapecio.Name = "btn_regla_trapecio";
            this.btn_regla_trapecio.Size = new System.Drawing.Size(874, 35);
            this.btn_regla_trapecio.TabIndex = 14;
            this.btn_regla_trapecio.Text = "REGLA DEL TRAPECIO";
            this.btn_regla_trapecio.UseVisualStyleBackColor = false;
            this.btn_regla_trapecio.Click += new System.EventHandler(this.btn_regla_trapecio_Click);
            // 
            // btn_regla_trapecio_i
            // 
            this.btn_regla_trapecio_i.BackColor = System.Drawing.Color.Black;
            this.btn_regla_trapecio_i.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_regla_trapecio_i.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_regla_trapecio_i.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regla_trapecio_i.ForeColor = System.Drawing.Color.LightGray;
            this.btn_regla_trapecio_i.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_regla_trapecio_i.Location = new System.Drawing.Point(-1, 150);
            this.btn_regla_trapecio_i.Name = "btn_regla_trapecio_i";
            this.btn_regla_trapecio_i.Size = new System.Drawing.Size(874, 35);
            this.btn_regla_trapecio_i.TabIndex = 15;
            this.btn_regla_trapecio_i.Text = "REGLA DEL TRAPECIO POR INTERVALOS";
            this.btn_regla_trapecio_i.UseVisualStyleBackColor = false;
            this.btn_regla_trapecio_i.Click += new System.EventHandler(this.btn_regla_trapecio_i_Click);
            // 
            // btn_regla_simpson_13_i
            // 
            this.btn_regla_simpson_13_i.BackColor = System.Drawing.Color.Black;
            this.btn_regla_simpson_13_i.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_regla_simpson_13_i.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_regla_simpson_13_i.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regla_simpson_13_i.ForeColor = System.Drawing.Color.LightGray;
            this.btn_regla_simpson_13_i.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_regla_simpson_13_i.Location = new System.Drawing.Point(-1, 273);
            this.btn_regla_simpson_13_i.Name = "btn_regla_simpson_13_i";
            this.btn_regla_simpson_13_i.Size = new System.Drawing.Size(874, 35);
            this.btn_regla_simpson_13_i.TabIndex = 18;
            this.btn_regla_simpson_13_i.Text = "REGLA DE SIMPSON 1/3 POR INTERVALOS";
            this.btn_regla_simpson_13_i.UseVisualStyleBackColor = false;
            this.btn_regla_simpson_13_i.Click += new System.EventHandler(this.btn_regla_simpson_13_i_Click);
            // 
            // btn_regla_simpson_38
            // 
            this.btn_regla_simpson_38.BackColor = System.Drawing.Color.Black;
            this.btn_regla_simpson_38.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_regla_simpson_38.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_regla_simpson_38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regla_simpson_38.ForeColor = System.Drawing.Color.LightGray;
            this.btn_regla_simpson_38.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_regla_simpson_38.Location = new System.Drawing.Point(-1, 357);
            this.btn_regla_simpson_38.Name = "btn_regla_simpson_38";
            this.btn_regla_simpson_38.Size = new System.Drawing.Size(874, 35);
            this.btn_regla_simpson_38.TabIndex = 19;
            this.btn_regla_simpson_38.Text = "REGLA DE SIMPSON 3/8";
            this.btn_regla_simpson_38.UseVisualStyleBackColor = false;
            this.btn_regla_simpson_38.Click += new System.EventHandler(this.btn_regla_simpson_38_Click);
            // 
            // Formulario_Integracion_Numerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(872, 629);
            this.Controls.Add(this.btn_regla_simpson_38);
            this.Controls.Add(this.btn_regla_simpson_13_i);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_reglasimpson13);
            this.Controls.Add(this.btn_regla_trapecio);
            this.Controls.Add(this.btn_regla_trapecio_i);
            this.Name = "Formulario_Integracion_Numerica";
            this.Text = "Formulario_Integracion_Numerica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_reglasimpson13;
        private System.Windows.Forms.Button btn_regla_trapecio;
        private System.Windows.Forms.Button btn_regla_trapecio_i;
        private System.Windows.Forms.Button btn_regla_simpson_13_i;
        private System.Windows.Forms.Button btn_regla_simpson_38;
    }
}