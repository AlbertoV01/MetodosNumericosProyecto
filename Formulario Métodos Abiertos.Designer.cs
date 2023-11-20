namespace Métodos_Numéricos_401
{
    partial class Formulario_Métodos_Abiertos
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
            this.btn_Netwon = new System.Windows.Forms.Button();
            this.btn_PuntoFijo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Netwon
            // 
            this.btn_Netwon.BackColor = System.Drawing.Color.Black;
            this.btn_Netwon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Netwon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Netwon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Netwon.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Netwon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Netwon.Location = new System.Drawing.Point(-2, 171);
            this.btn_Netwon.Name = "btn_Netwon";
            this.btn_Netwon.Size = new System.Drawing.Size(874, 35);
            this.btn_Netwon.TabIndex = 7;
            this.btn_Netwon.Text = "NEWTON - RHAPSON";
            this.btn_Netwon.UseVisualStyleBackColor = false;
            this.btn_Netwon.Click += new System.EventHandler(this.btn_Netwon_Click);
            // 
            // btn_PuntoFijo
            // 
            this.btn_PuntoFijo.BackColor = System.Drawing.Color.Black;
            this.btn_PuntoFijo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_PuntoFijo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_PuntoFijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PuntoFijo.ForeColor = System.Drawing.Color.LightGray;
            this.btn_PuntoFijo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PuntoFijo.Location = new System.Drawing.Point(-2, 51);
            this.btn_PuntoFijo.Name = "btn_PuntoFijo";
            this.btn_PuntoFijo.Size = new System.Drawing.Size(874, 35);
            this.btn_PuntoFijo.TabIndex = 6;
            this.btn_PuntoFijo.Text = "ITERACIÓN SIMPLE DE PUNTO FIJO";
            this.btn_PuntoFijo.UseVisualStyleBackColor = false;
            this.btn_PuntoFijo.Click += new System.EventHandler(this.btn_PuntoFijo_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-2, 382);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(105, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "VOLVER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-2, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(874, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "SECANTE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formulario_Métodos_Abiertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(872, 629);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_PuntoFijo);
            this.Controls.Add(this.btn_Netwon);
            this.Name = "Formulario_Métodos_Abiertos";
            this.Text = "Formulario_Métodos_Abiertos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Netwon;
        private System.Windows.Forms.Button btn_PuntoFijo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}