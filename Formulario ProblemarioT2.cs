using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Métodos_Numéricos_401
{
    public partial class Formulario_ProblemarioT2 : Form
    {
        public Formulario_ProblemarioT2()
        {
            InitializeComponent();
        }

        private void btn_Ejercicios_T2_Click(object sender, EventArgs e)
        {
            string ruta_EjerciciosT2 = @"Ejercicios Tema 2 AVR 401 ISC.pdf";
            Process.Start(ruta_EjerciciosT2);
        }

        private void btn_ReporteT2_Click(object sender, EventArgs e)
        {
            string ruta_ReporteT2 = @"Reporte Tema 2 AVR 401 ISC.pdf";
            Process.Start(ruta_ReporteT2);
        }

        private void btn_ExcelT2_Click(object sender, EventArgs e)
        {
            string ruta_ExcelT2 = @"Reporte Excel.xlsx";
            Process.Start(ruta_ExcelT2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
