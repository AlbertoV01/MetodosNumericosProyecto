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
    public partial class Formulario_Métodos_Cerrados : Form
    {
        public Formulario_Métodos_Cerrados()
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
        private void btn_Biseccion_Click(object sender, EventArgs e)
        {
            
            AbrirFormulario(new Formulario_Biseccion());
        }

        private void btn_FalsaPosicion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Falsa_Posición());
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
