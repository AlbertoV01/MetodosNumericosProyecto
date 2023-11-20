using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Métodos_Numéricos_401
{
    public partial class Formulario_Métodos_Abiertos : Form
    {
        public Formulario_Métodos_Abiertos()
        {
            InitializeComponent();
        }
        private Form FormularioActivo = null;
        private void AbrirFormulario(Form NuevoFormulario)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = NuevoFormulario;
            NuevoFormulario.TopLevel = false;
            NuevoFormulario.FormBorderStyle = FormBorderStyle.None;
            //NuevoFormulario.Size = new System.Drawing.Size(709, 529);
            NuevoFormulario.Dock = DockStyle.Fill;
            //pnl_MetodosAbiertos.Controls.Add(NuevoFormulario);
            
            Controls.Add(NuevoFormulario);

            NuevoFormulario.BringToFront();
            NuevoFormulario.Show();
        }
        private void btn_PuntoFijo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Punto_Fijo());
        }

        private void btn_Netwon_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Netwon_Rhapson());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Secante());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
