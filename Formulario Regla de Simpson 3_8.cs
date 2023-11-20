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
    public partial class Formulario_Regla_de_Simpson_3_8 : Form
    {
        public Formulario_Regla_de_Simpson_3_8()
        {
            InitializeComponent();
        }
        Calculo oCalculo = new Calculo();
        //double x0 = 0;
        //double x1 = 0;
        //double x2 = 0;
        //double x3 = 0;
        double h = 0;
        double a = 0;
        double b = 0;
        double valorverdadero = 0;
        double []variables=new double [4];
        double[] fvariables = new double[4];
        double resultado = 0;
        double erp = 0;
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            tb_valorverdadero.Clear();
            tb_Funcion.Clear();
            tb_Intervalos.Clear();
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

            h = (b - a) / 3;
            //SE CALCULA LAS VARIABLES
            for (int i = 0; i < variables.Length; i++)
            {
                if (i == 0)
                {
                    variables[i] = a;
                }
                else
                {
                    variables[i] = variables[i - 1] + h;
                }
                if (i == variables.Length - 1)
                {
                    variables[i] = b;
                }
            }
            // SE SUSTITUYE LAS VARIABLES EN LA ECUACION
            for (int i = 0; i < variables.Length; i++)
            {
                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
                {
                    fvariables[i] = oCalculo.EvaluaFx(variables[i]);
                }
            }
            resultado = ((b - a) * ((fvariables[0]) + 3 * (fvariables[1]) + 3 * (fvariables[2]) + (fvariables[3])) / 8);
            tb_resultado.Text = resultado.ToString();
            erp =Math.Abs( ((valorverdadero - resultado)/ valorverdadero) * 100);
            tb_Error.Text = erp.ToString()+"%";

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

        private void tb_Intervalos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }
    }
}
