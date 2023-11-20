using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculus;
namespace Métodos_Numéricos_401
{
    public partial class Formulario_Regla_de_Simpson_1_3 : Form
    {
        public Formulario_Regla_de_Simpson_1_3()
        {
            InitializeComponent();
        }
        Calculo oCalculo = new Calculo();
        double x0 = 0;
        double x1 = 0;
        double x2 = 0;
        double fx0 = 0;
        double fx1 = 0;
        double fx2 = 0;
        double a = 0;
        double b = 0;
        double n = 0;
        double resultado = 0;
        double erp = 0;
        double valorverdadero = 0;
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            tb_valorverdadero.Clear();
            tb_Funcion.Clear();
            tb_resultado.Clear();
            tb_Error.Clear();
            tb_a.Clear();
            tb_b.Clear();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {

            if (ValidarTextboxs.CamposVacios(tb_Funcion) || ValidarTextboxs.CamposVacios(tb_a) || ValidarTextboxs.CamposVacios(tb_b) || ValidarTextboxs.CamposVacios(tb_valorverdadero))
            {
                MessageBox.Show("Faltan datos");
                return;
            }
            a = Convert.ToDouble(tb_a.Text);
            b = Convert.ToDouble(tb_b.Text);
            valorverdadero = Convert.ToDouble(tb_valorverdadero.Text);
            n = ((b - a) / 2);


            x0 = a;
            x1 = n;
            x2 = b;

            if(oCalculo.Sintaxis(tb_Funcion.Text,'x'))
            {
                fx0 = oCalculo.EvaluaFx(x0);
                fx1 = oCalculo.EvaluaFx(x1);
                fx2 = oCalculo.EvaluaFx(x2);
            }

            resultado = (((b - a) * (fx0 + 4 * (fx1) + fx2) )/ 6);
            tb_resultado.Text = resultado.ToString();
            erp = Math.Abs((valorverdadero-resultado)/valorverdadero)*100;
            tb_Error.Text = erp.ToString() + "%";
        }

        private void tb_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_valorverdadero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }
    }
}
