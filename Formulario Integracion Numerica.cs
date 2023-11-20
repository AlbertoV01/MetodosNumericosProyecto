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
    public partial class Formulario_Integracion_Numerica : Form
    {
        public Formulario_Integracion_Numerica()
        {
            InitializeComponent();
        }
        private Form FormularioActivo = null;
        public void AbrirFormulario(Form NuevoFormulario)
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
        private void btn_regla_trapecio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Regla_del_Trapecio());
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_regla_trapecio_i_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Regla_del_Trapecio_Por_Intervalos());
        }

        private void btn_reglasimpson13_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Regla_de_Simpson_1_3());
        }

        private void btn_regla_simpson_13_i_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulaio_Regla_de_Simpson_1_3_por_intervalos());
        }

        private void btn_regla_simpson_38_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Regla_de_Simpson_3_8());
        }
    }
}
