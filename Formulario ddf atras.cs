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
    public partial class Formulario_ddf_atras : Form
    {
        public Formulario_ddf_atras()
        {
            InitializeComponent();
        }
        Calculo oCalculo = new Calculo();
        double h = 0;
        double xi = 0;
        double valorverdadero = 0;
        double ximenos1 = 0;
        double ximenos2 = 0;
        double ximenos3 = 0;
        double ximenos4 = 0;
        string funcion = string.Empty;
        string funcionSustituida = string.Empty;
        double fxi = 0;
        double fximenos1 = 0;
        double fximenos2 = 0;
        double fximenos3 = 0;
        double fximenos4 = 0;
        double erp = 0;
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (ValidarTextboxs.CamposVacios(tb_h) || ValidarTextboxs.CamposVacios(tb_xi) || ValidarTextboxs.CamposVacios(tb_valorverdadero) || ValidarTextboxs.CamposVacios(tb_Funcion))
            {
                MessageBox.Show("No se ademite campos vacios", ":I", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //----------------------------------//PRIMERA DERIVADA
            if (checkBox_PrimeraDerivada.Checked)
            {
                if (ValidarTextboxs.CamposVacios(tb_h) || ValidarTextboxs.CamposVacios(tb_xi) || ValidarTextboxs.CamposVacios(tb_valorverdadero))
                {
                    MessageBox.Show("No se ademite campos vacios", ":I", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgv_ecuacionSustituida.Rows.Clear();
                h = Convert.ToDouble(tb_h.Text);
                xi = Convert.ToDouble(tb_xi.Text);
                valorverdadero = Convert.ToDouble(tb_valorverdadero.Text);
                checkBoxSegundaDerivada.Checked = false;
                checkBoxTerceraDerivada.Checked = false;

                ximenos1 = xi - h;
                ximenos2 = xi -(2 * h);

                funcion = tb_Funcion.Text;

                //Se calcula f(xi)
                funcionSustituida = funcion.Replace("x", xi.ToString());

                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
                {
                    fxi = oCalculo.EvaluaFx(xi);

                }
                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fxi);
                //Se calcula f(ximas1)
                funcionSustituida = funcion.Replace("x", ximenos1.ToString());

                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
                {
                    fximenos1 = oCalculo.EvaluaFx(ximenos1);
                }

                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximenos1.ToString());

                //se calcula f(ximas2)
                funcionSustituida = funcion.Replace("x", ximenos2.ToString());

                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
                {
                    fximenos2 = oCalculo.EvaluaFx(ximenos2);
                }

                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximenos2.ToString());

                double resultadoPD = (3*fxi-4*fximenos1+fximenos2)/(2*h);

                label_Resultado.Text = resultadoPD.ToString();

                erp = Math.Abs((valorverdadero - resultadoPD) / valorverdadero) * 100;
                label_Error.Text = erp.ToString() + "%";
            }

            //-------------------------------  //SEGUNDA DERIVADA
            if (checkBoxSegundaDerivada.Checked)
            {
                dgv_ecuacionSustituida.Rows.Clear();

                if (ValidarTextboxs.CamposVacios(tb_h) || ValidarTextboxs.CamposVacios(tb_xi) || ValidarTextboxs.CamposVacios(tb_valorverdadero) || ValidarTextboxs.CamposVacios(tb_Funcion))
                {
                    MessageBox.Show("No se ademite campos vacios", ":I", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                checkBox_PrimeraDerivada.Checked = false;
                checkBoxTerceraDerivada.Checked = false;

                h = Convert.ToDouble(tb_h.Text);
                xi = Convert.ToDouble(tb_xi.Text);
                valorverdadero = Convert.ToDouble(tb_valorverdadero.Text);

                ximenos1 = xi - h;
                ximenos2 = xi - (2 * h);
                ximenos3 = xi - (3 * h);
                funcion = tb_Funcion.Text;

                //Se calcula f(xi)
                funcionSustituida = funcion.Replace("x", xi.ToString());

                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
                {
                    fxi = oCalculo.EvaluaFx(xi);

                }
                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fxi);
                //Se calcula f(ximenos1)
                funcionSustituida = funcion.Replace("x", ximenos1.ToString());

                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
                {
                    fximenos1 = oCalculo.EvaluaFx(ximenos1);
                }

                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximenos1.ToString());

                //se calcula f(ximenos2)
                funcionSustituida = funcion.Replace("x", ximenos2.ToString());

                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
                {
                    fximenos2 = oCalculo.EvaluaFx(ximenos2);
                }

                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximenos2.ToString());

                //Se calcula f(ximenos3)
                funcionSustituida = funcion.Replace("x", ximenos3.ToString());

                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
                {
                    fximenos3 = oCalculo.EvaluaFx(ximenos3);
                }

                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximenos3.ToString());

                double resultadoPD = (2*(fxi)-5*(fximenos1)+4*(fximenos2)-(fximenos3))/(h*h);
                label_Resultado.Text = resultadoPD.ToString();
                erp = Math.Abs((valorverdadero - resultadoPD) / valorverdadero) * 100;
                label_Error.Text = erp.ToString() + "%";
            }

            //------------------------------- TERCERA DERIVADA
            if (checkBoxTerceraDerivada.Checked)
            {
                dgv_ecuacionSustituida.Rows.Clear();

                if (ValidarTextboxs.CamposVacios(tb_h) || ValidarTextboxs.CamposVacios(tb_xi) || ValidarTextboxs.CamposVacios(tb_valorverdadero) || ValidarTextboxs.CamposVacios(tb_Funcion))
                {
                    MessageBox.Show("No se ademite campos vacios", ":I", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                checkBox_PrimeraDerivada.Checked = false;
                checkBoxTerceraDerivada.Checked = false;

                h = Convert.ToDouble(tb_h.Text);
                xi = Convert.ToDouble(tb_xi.Text);
                valorverdadero = Convert.ToDouble(tb_valorverdadero.Text);

                ximenos1 = xi - h;
                ximenos2 = xi - (2 * h);
                ximenos3 = xi - (3 * h);
                ximenos4 = xi - (4 * h);
                funcion = tb_Funcion.Text;

                //Se calcula f(xi)
                funcionSustituida = funcion.Replace("x", xi.ToString());

                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
                {
                    fxi = oCalculo.EvaluaFx(xi);

                }
                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fxi);
                //Se calcula f(ximas1)
                funcionSustituida = funcion.Replace("x", ximenos1.ToString());

                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
                {
                    fximenos1 = oCalculo.EvaluaFx(ximenos1);
                }

                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximenos1.ToString());

                //se calcula f(ximas2)
                funcionSustituida = funcion.Replace("x", ximenos2.ToString());

                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
                {
                    fximenos2 = oCalculo.EvaluaFx(ximenos2);
                }

                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximenos2.ToString());

                //Se calcula f(ximas3)
                funcionSustituida = funcion.Replace("x", ximenos3.ToString());

                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
                {
                    fximenos3 = oCalculo.EvaluaFx(ximenos3);
                }

                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximenos3.ToString());

                //Se calcula f(ximenos4)

                funcionSustituida = funcion.Replace("x", ximenos4.ToString());
                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
                {
                    fximenos4 = oCalculo.EvaluaFx(ximenos4);
                }
                dgv_ecuacionSustituida.Rows.Add(funcionSustituida+" = "+fximenos4.ToString());
                double xj = Math.Pow(h, 3);
                double resultadoPD = (5*(fxi)-18*(fximenos1)+24*(fximenos2)-14*(fximenos3)+3*(fximenos4))/(2*xj);
                label_Resultado.Text = resultadoPD.ToString();
                erp = Math.Abs((valorverdadero - resultadoPD) / valorverdadero) * 100;
                label_Error.Text = erp.ToString() + "%";
            }

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            dgv_ecuacionSustituida.Rows.Clear();
            tb_Funcion.Clear();
            tb_h.Clear();
            tb_xi.Clear();
            tb_valorverdadero.Clear();
            label_Resultado.Text = "";
            label_Error.Text = "";
        }

        private void checkBox_PrimeraDerivada_Click(object sender, EventArgs e)
        {
            checkBoxSegundaDerivada.Checked = false;
            checkBoxTerceraDerivada.Checked = false;
             
        }

        private void checkBoxSegundaDerivada_Click(object sender, EventArgs e)
        {
            checkBox_PrimeraDerivada.Checked = false;
            checkBoxTerceraDerivada.Checked = false;
        }

        private void checkBoxTerceraDerivada_Click(object sender, EventArgs e)
        {
            checkBoxSegundaDerivada.Checked = false;
            checkBox_PrimeraDerivada.Checked = false;
        }

        private void tb_xi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
