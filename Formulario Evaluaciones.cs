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
    public partial class Formulario_Evaluaciones : Form
    {
        public Formulario_Evaluaciones()
        {
            InitializeComponent();
        }

        private void btn_Evaluacion1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.BackgroundImage = Properties.Resources.Evaluacion_1;
           
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Formulario_Evaluaciones_Load(object sender, EventArgs e)
        {

        }

        private void btn_Evaluacion2_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.BackgroundImage = Properties.Resources.Evaluacion2;

        }

        private void btn_Evaluacion3_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.BackgroundImage = Properties.Resources.Evalacion3;

        }

        private void btn_Evaluacion4_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.BackgroundImage = Properties.Resources.Evaluacion_4;

        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
