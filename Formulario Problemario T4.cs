using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Métodos_Numéricos_401
{
    public partial class Formulario_Problemario_T4 : Form
    {
        public Formulario_Problemario_T4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ejercicios_T2_Click(object sender, EventArgs e)
        {
            string ruta_ReporteT4 = @"ProblemarioT4_AVR_ISC_401.pdf";
            Process.Start(ruta_ReporteT4);
        }
    }
}
