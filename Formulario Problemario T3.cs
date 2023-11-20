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
    public partial class Formulario_Problemario_T3 : Form
    {
        public Formulario_Problemario_T3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ReporteT2_Click(object sender, EventArgs e)
        {
            string ruta_ReporteT3 = @"Reporte_Tema3_AVR_ISC_401.pdf";
            Process.Start(ruta_ReporteT3);
        }

        private void btn_ExcelT2_Click(object sender, EventArgs e)
        {
            string ruta_ExcelT3 = @"Reporte_Excel_Tema3_AVR_ISC_401.xlsx";
            Process.Start(ruta_ExcelT3);
        }

        private void btn_Ejercicios_T2_Click(object sender, EventArgs e)
        {
            string ruta_ReporteT3 = @"EjerciciosTema3.pdf";
            Process.Start(ruta_ReporteT3);
        }
    }
}
