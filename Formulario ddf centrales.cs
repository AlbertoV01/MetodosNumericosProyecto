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
    public partial class Formulario_ddf_centrales : Form
    {
        public Formulario_ddf_centrales()
        {
            InitializeComponent();
        }
        Calculo oCalculo = new Calculo();
        double h = 0;
        double xi = 0;
        double valorverdadero = 0;
        double ximas1 = 0;
        double ximas2 = 0;
        double ximas3 = 0;
        double ximenos1 = 0;
        double ximenos2 = 0;
        double ximenos3 = 0;
        string funcion = string.Empty;
        string funcionSustituida = string.Empty;
        double fxi = 0;
        double fximenos1 = 0;
        double fximenos2 = 0;
        double fximenos3 = 0;
        double fximas1 = 0;
        double fximas2 = 0;
        double fximas3 = 0;
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
                ximenos2 = xi - (2 * h);
                ximas1 = xi + h;
                ximas2 = xi + (2 * h);

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

                //Se calcula f(ximas1)

                funcionSustituida = funcion.Replace("x", ximas1.ToString());

                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
                {
                    fximas1 = oCalculo.EvaluaFx(ximas1);
                }

                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximas1.ToString());

                //Se calcula f(ximas2)

                funcionSustituida = funcion.Replace("x", ximas2.ToString());

                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
                {
                    fximas2 = oCalculo.EvaluaFx(ximas2);
                }
                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximas2.ToString());

                double resultadoPD = (-(fximas2)+8*(fximas1)-8*(fximenos1)+fximenos2)/(12*h);

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
                ximas1 = xi + h;
                ximas2 = xi + (2 * h);
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

             
                //Se calcula f(ximas1)

                funcionSustituida = funcion.Replace("x", ximas1.ToString());

                if(oCalculo.Sintaxis(tb_Funcion.Text,'x'))
                {
                    fximas1 = oCalculo.EvaluaFx(ximas1);
                }

                dgv_ecuacionSustituida.Rows.Add(funcionSustituida+" = "+fximas1.ToString());

                //Se calcula f(ximas2)

                funcionSustituida = funcion.Replace("x", ximas2.ToString());

                if (oCalculo.Sintaxis(tb_Funcion.Text,'x'))
                {
                    fximas2 = oCalculo.EvaluaFx(ximas2);
                }
                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximas2.ToString());

                double resultadoPD = (-(fximas2)-16*(fximas1)-30*(fxi)+16*(fximenos1)-fximenos2)/(12*(h*h));
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

               

                h = Convert.ToDouble(tb_h.Text);
                xi = Convert.ToDouble(tb_xi.Text);
                valorverdadero = Convert.ToDouble(tb_valorverdadero.Text);

                ximenos1 = xi - h;
                ximenos2 = xi - (2 * h);
                ximenos3 = xi - (3 * h);
                ximas1 = xi + h;
                ximas2 = xi + (2 * h);
                ximas3 = xi + (3 * h);
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
            
                //Se calcula f(ximas1)

                funcionSustituida = funcion.Replace("x", ximas1.ToString());

                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
                {
                    fximas1 = oCalculo.EvaluaFx(ximas1);
                }

                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximas1.ToString());

                //Se calcula f(ximas2)

                funcionSustituida = funcion.Replace("x", ximas2.ToString());

                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
                {
                    fximas2 = oCalculo.EvaluaFx(ximas2);
                }
                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximas2.ToString());

                // Se calcula f(ximas3)
                funcionSustituida = funcion.Replace("x", ximas3.ToString());
                if(oCalculo.Sintaxis(tb_Funcion.Text,'x'))
                {
                    fximas3 = oCalculo.EvaluaFx(ximas3);
                }
                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximas3.ToString());


                double xj = Math.Pow(h, 3);
                double resultadoPD =(-(fximas3)+8*(fximas2)-13*(fximas1)+13*(fximenos1)-8*(fximenos2)+(fximenos3))/(8*xj);
                label_Resultado.Text = resultadoPD.ToString();
                erp = Math.Abs((valorverdadero - resultadoPD) / valorverdadero) * 100;
                label_Error.Text = erp.ToString() + "%";
            }

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            tb_Funcion.Clear();
            tb_h.Clear();
            tb_valorverdadero.Clear();
            tb_xi.Clear();
            dgv_ecuacionSustituida.Rows.Clear();

            checkBoxSegundaDerivada.Checked = false;
            checkBox_PrimeraDerivada.Checked = false;
            checkBoxTerceraDerivada.Checked = false;
            label_Error.Text = "";
            label_Resultado.Text = "";
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_PrimeraDerivada_Click(object sender, EventArgs e)
        {
            checkBoxSegundaDerivada.Checked = false;
            checkBoxTerceraDerivada.Checked = false;

        }

        private void checkBoxSegundaDerivada_Click(object sender, EventArgs e)
        {
            checkBoxTerceraDerivada.Checked = false;
            checkBox_PrimeraDerivada.Checked = false;
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

        private void tb_h_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_valorverdadero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }
    }
}
