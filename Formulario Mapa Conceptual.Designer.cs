namespace Métodos_Numéricos_401
{
    partial class Formulario_Mapa_Conceptual
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
            this.btn_MapaConceptual = new System.Windows.Forms.Button();
            this.pnl_MapaConceptual = new System.Windows.Forms.Panel();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.pnl_MapaConceptual.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_MapaConceptual
            // 
            this.btn_MapaConceptual.BackColor = System.Drawing.Color.Black;
            this.btn_MapaConceptual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_MapaConceptual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_MapaConceptual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MapaConceptual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MapaConceptual.ForeColor = System.Drawing.Color.LightGray;
            this.btn_MapaConceptual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MapaConceptual.Location = new System.Drawing.Point(0, 143);
            this.btn_MapaConceptual.Name = "btn_MapaConceptual";
            this.btn_MapaConceptual.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_MapaConceptual.Size = new System.Drawing.Size(885, 109);
            this.btn_MapaConceptual.TabIndex = 3;
            this.btn_MapaConceptual.Text = "MAPA CONCEPTUAL";
            this.btn_MapaConceptual.UseVisualStyleBackColor = false;
            this.btn_MapaConceptual.Click += new System.EventHandler(this.btn_MapaConceptual_Click);
            // 
            // pnl_MapaConceptual
            // 
            this.pnl_MapaConceptual.Controls.Add(this.btn_Atras);
            this.pnl_MapaConceptual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MapaConceptual.Location = new System.Drawing.Point(0, 0);
            this.pnl_MapaConceptual.Name = "pnl_MapaConceptual";
            this.pnl_MapaConceptual.Size = new System.Drawing.Size(888, 668);
            this.pnl_MapaConceptual.TabIndex = 4;
            this.pnl_MapaConceptual.Visible = false;
            // 
            // btn_Atras
            // 
            this.btn_Atras.BackColor = System.Drawing.Color.Black;
            this.btn_Atras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atras.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Atras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Atras.Location = new System.Drawing.Point(782, 369);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btn_Atras.Size = new System.Drawing.Size(94, 40);
            this.btn_Atras.TabIndex = 11;
            this.btn_Atras.Text = "Atrás";
            this.btn_Atras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Atras.UseVisualStyleBackColor = false;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.Black;
            this.btn_Volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Volver.Location = new System.Drawing.Point(-3, 369);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Volver.Size = new System.Drawing.Size(87, 40);
            this.btn_Volver.TabIndex = 10;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // Formulario_Mapa_Conceptual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(888, 668);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.pnl_MapaConceptual);
            this.Controls.Add(this.btn_MapaConceptual);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario_Mapa_Conceptual";
            this.Text = "Formulario_Mapa_Conceptual";
            this.pnl_MapaConceptual.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MapaConceptual;
        private System.Windows.Forms.Panel pnl_MapaConceptual;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Button btn_Volver;
    }
}