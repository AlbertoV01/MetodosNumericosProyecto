namespace Métodos_Numéricos_401
{
    partial class Formulario_Diferenciacion
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
            this.btn_ddfcentrales = new System.Windows.Forms.Button();
            this.btn_ddfadelante = new System.Windows.Forms.Button();
            this.btn_ddfatras = new System.Windows.Forms.Button();
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
            this.btn_Salir.Location = new System.Drawing.Point(-1, 462);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Salir.Size = new System.Drawing.Size(105, 35);
            this.btn_Salir.TabIndex = 13;
            this.btn_Salir.Text = "VOLVER";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_ddfcentrales
            // 
            this.btn_ddfcentrales.BackColor = System.Drawing.Color.Black;
            this.btn_ddfcentrales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ddfcentrales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_ddfcentrales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ddfcentrales.ForeColor = System.Drawing.Color.LightGray;
            this.btn_ddfcentrales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ddfcentrales.Location = new System.Drawing.Point(-1, 297);
            this.btn_ddfcentrales.Name = "btn_ddfcentrales";
            this.btn_ddfcentrales.Size = new System.Drawing.Size(874, 35);
            this.btn_ddfcentrales.TabIndex = 12;
            this.btn_ddfcentrales.Text = "DIFERENCIAS DIVIDIDAS FINITAS CENTRALES";
            this.btn_ddfcentrales.UseVisualStyleBackColor = false;
            this.btn_ddfcentrales.Click += new System.EventHandler(this.btn_ddfcentrales_Click);
            // 
            // btn_ddfadelante
            // 
            this.btn_ddfadelante.BackColor = System.Drawing.Color.Black;
            this.btn_ddfadelante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ddfadelante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_ddfadelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ddfadelante.ForeColor = System.Drawing.Color.LightGray;
            this.btn_ddfadelante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ddfadelante.Location = new System.Drawing.Point(-1, 102);
            this.btn_ddfadelante.Name = "btn_ddfadelante";
            this.btn_ddfadelante.Size = new System.Drawing.Size(874, 35);
            this.btn_ddfadelante.TabIndex = 10;
            this.btn_ddfadelante.Text = "DIFERENCIAS DIVIDIDAS FINITAS HACIA ADELANTE\r\n";
            this.btn_ddfadelante.UseVisualStyleBackColor = false;
            this.btn_ddfadelante.Click += new System.EventHandler(this.btn_ddfadelante_Click);
            // 
            // btn_ddfatras
            // 
            this.btn_ddfatras.BackColor = System.Drawing.Color.Black;
            this.btn_ddfatras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ddfatras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_ddfatras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ddfatras.ForeColor = System.Drawing.Color.LightGray;
            this.btn_ddfatras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ddfatras.Location = new System.Drawing.Point(-1, 199);
            this.btn_ddfatras.Name = "btn_ddfatras";
            this.btn_ddfatras.Size = new System.Drawing.Size(874, 35);
            this.btn_ddfatras.TabIndex = 11;
            this.btn_ddfatras.Text = "DIFERENCIAS DIVIDIDAS FINTIAS HACIA ATRAS";
            this.btn_ddfatras.UseVisualStyleBackColor = false;
            this.btn_ddfatras.Click += new System.EventHandler(this.btn_ddfatras_Click);
            // 
            // Formulario_Diferenciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(872, 629);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_ddfcentrales);
            this.Controls.Add(this.btn_ddfadelante);
            this.Controls.Add(this.btn_ddfatras);
            this.Name = "Formulario_Diferenciacion";
            this.Text = "Formulario_Diferenciacion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_ddfcentrales;
        private System.Windows.Forms.Button btn_ddfadelante;
        private System.Windows.Forms.Button btn_ddfatras;
    }
}