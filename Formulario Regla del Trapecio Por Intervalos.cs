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
    public partial class Formulario_Regla_del_Trapecio_Por_Intervalos : Form
    {
        public Formulario_Regla_del_Trapecio_Por_Intervalos()
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
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            tb_a.Clear();
            tb_b.Clear();
            tb_Funcion.Clear();
            tb_resultado.Clear();
            tb_Error.Clear();
            this.Close();
            intervalos = 0;
            n = 0;
            valorverdadero = 0;
            sumatoria0 = 0;
            resultado = 0;
            erp = 0;
            for (int i = 0; i < variables.Length; i++)
            {
                variables[i] = 0;
                fvariables[i] = 0;
            }

        }

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
            intervalos =Convert.ToInt32(tb_Intervalos.Text);
            valorverdadero = Convert.ToDouble(tb_valorverdadero.Text);
            n = ((b - a)/intervalos);

            variables = new double[intervalos+1];
            fvariables = new double[intervalos + 1];
        

            //CICLO PARA CALCULAR LAS VARIABLES
            for (int i = 0;i< variables.Length; i++)
            {
                if (i == 0)
                {
                    variables[i] = a;
                }
                else
                {
                    variables[i] = variables[i - 1] + n;
                }
                if(i==variables.Length-1)
                {
                    variables[i] = b;
                }
            }
            //CICLO PARA CALCULAR LAS SUSTITUCIONES DE LAS VARIABLES EN LAS ECUACION
            for(int i=0;i< variables.Length;i++)
            {
                if(oCalculo.Sintaxis(tb_Funcion.Text,'x'))
                {
                   fvariables[i] = oCalculo.EvaluaFx(variables[i]);
                }
            }
            //CICLO PARA CALCULAR LA SUMATORIA DE LOS RESULTADOS
            for (int i=0;i< fvariables.Length;i++)
            {
                sumatoria0=sumatoria0 + fvariables[i];
            }
            //APLICAMOS LA FORMULA
            resultado = ((n / 2) * (fvariables[0] + (2*sumatoria0)));
            tb_resultado.Text = resultado.ToString();
            //CALCULAMOS EL ERROR RELATIVO PORCENTUAL
            erp =Math.Abs(((valorverdadero - resultado) / valorverdadero)*100);
            tb_Error.Text = erp.ToString()+"%";
        }

        private void tb_valorverdadero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_Intervalos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
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
