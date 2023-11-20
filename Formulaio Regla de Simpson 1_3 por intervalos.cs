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
    public partial class Formulaio_Regla_de_Simpson_1_3_por_intervalos : Form
    {
        public Formulaio_Regla_de_Simpson_1_3_por_intervalos()
        {
            InitializeComponent();
        }
        Calculo oCalculo = new Calculo();
        int intervalos = 0;
        double n = 0;
        double b = 0;
        double a = 0;
        double valorverdadero = 0;
        double[] variables;
        double[] fvariables;
        double sumatoria0;
        double resultado = 0;
        double erp = 0;
        private void btn_Calcular_Click(object sender, EventArgs e)
        {

            if (ValidarTextboxs.CamposVacios(tb_Funcion) || ValidarTextboxs.CamposVacios(tb_a) || ValidarTextboxs.CamposVacios(tb_b) || ValidarTextboxs.CamposVacios(tb_valorverdadero))
            {
                MessageBox.Show("Faltan datos");
                return;
            }
            sumatoria0 = 0;


            b = Convert.ToDouble(tb_b.Text);
            a = Convert.ToDouble(tb_a.Text);
            intervalos = Convert.ToInt32(tb_Intervalos.Text);
            valorverdadero = Convert.ToDouble(tb_valorverdadero.Text);
            n = ((b - a) / intervalos);

            variables = new double[intervalos + 1];
            fvariables = new double[intervalos + 1];


            //CICLO PARA CALCULAR LAS VARIABLES
            for (int i = 0; i < variables.Length; i++)
            {
                if (i == 0)
                {
                    variables[i] = a;
                }
                else
                {
                    variables[i] = variables[i - 1] + n;
                }
                if (i == variables.Length - 1)
                {
                    variables[i] = b;
                }
            }
            //CICLO PARA CALCULAR LAS SUSTITUCIONES DE LAS VARIABLES EN LAS ECUACION
            for (int i = 0; i < variables.Length; i++)
            {
                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
                {
                    fvariables[i] = oCalculo.EvaluaFx(variables[i]);
                }
            }
            //CICLO PARA CALCULAR LA SUMATORIA DE LOS RESULTADOS
            for (int i = 0; i < fvariables.Length; i++)
            {
                sumatoria0 = sumatoria0 + fvariables[i];
            }
            //APLICAMOS LA FORMULA
            resultado = ((b - a) * (fvariables[0] + 4 * fvariables[1]+2 * (sumatoria0)))/(3*n);
            tb_resultado.Text = resultado.ToString();
            //CALCULAMOS EL ERROR RELATIVO PORCENTUAL
            erp = Math.Abs(((valorverdadero - resultado) / valorverdadero) * 100);
            tb_Error.Text = erp.ToString() + "%";
        }

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
    }
}
