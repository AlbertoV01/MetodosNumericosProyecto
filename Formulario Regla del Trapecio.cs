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
    public partial class Formulario_Regla_del_Trapecio : Form
    {
        public Formulario_Regla_del_Trapecio()
        {
            InitializeComponent();
        }
        Calculo oCalclo = new Calculo();
        Calculo oCalculo2 = new Calculo();
        double b = 0;
        double a = 0;
        double fxa = 0;
        double fxb = 0;
        double resultado = 0;
        double erp = 0;
        double valorverdadero = 0;
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            tb_a.Clear();
            tb_b.Clear();
            tb_Funcion.Clear();
            tb_resultado.Clear();
            tb_Error.Clear();
        }

        private void tb_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            
            if (ValidarTextboxs.CamposVacios(tb_Funcion)||ValidarTextboxs.CamposVacios(tb_a)||ValidarTextboxs.CamposVacios(tb_b)||ValidarTextboxs.CamposVacios(tb_valorverdadero))
            {
                MessageBox.Show("Faltan datos");
                return;
            }

            a = Convert.ToDouble(tb_a.Text);
            b = Convert.ToDouble(tb_b.Text);
            valorverdadero = Convert.ToDouble(tb_valorverdadero.Text);
            if(oCalclo.Sintaxis(tb_Funcion.Text,'x'))
            {
                fxa = oCalclo.EvaluaFx(a);
            }
            if (oCalculo2.Sintaxis(tb_Funcion.Text, 'x'))
            {
                fxb = oCalculo2.EvaluaFx(b);
            }

            resultado=((b-a)*((fxa+fxb)/2));
            tb_resultado.Text = resultado.ToString();


            erp = Math.Abs(((valorverdadero - resultado) / valorverdadero))*100;
            tb_Error.Text = erp.ToString();

        }

        private void tb_valorverdadero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }
    }
}
