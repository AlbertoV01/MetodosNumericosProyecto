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
    public partial class Formulario_Problemario_Tema1 : Form
    {
        public Formulario_Problemario_Tema1()
        {
            InitializeComponent();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Problemario_Tema1_Click(object sender, EventArgs e)
        {
            string ruta_Problemario = @"Tema1_Problemario AVR 401 ISC.pdf";
            Process.Start(ruta_Problemario);
            
        }
    }
}
