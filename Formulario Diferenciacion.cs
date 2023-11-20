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
    public partial class Formulario_Diferenciacion : Form
    {
        public Formulario_Diferenciacion()
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
            NuevoFormulario.Dock = DockStyle.Fill;
            Controls.Add(NuevoFormulario);
            NuevoFormulario.BringToFront();
            NuevoFormulario.Show();
        }


        private void btn_ddfadelante_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_ddf_adelante());
        }

        private void btn_ddfatras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_ddf_atras());
        }

        private void btn_ddfcentrales_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_ddf_centrales());
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
