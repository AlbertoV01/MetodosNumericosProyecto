using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Métodos_Numéricos_401
{
    public partial class Netwon_Rhapson : Form
    {
        public Netwon_Rhapson()
        {
            InitializeComponent();
        }
        float iteracionN=0;
        private void btn_Calcular_Netwon_Click(object sender, EventArgs e)
        {

            if (ValidarTextboxs.CamposVacios(tb_xi) || ValidarTextboxs.CamposVacios(tb_P) || ValidarTextboxs.CamposVacios(tb_Es) || ValidarTextboxs.CamposVacios(tb_Derivada)
                || ValidarTextboxs.CamposVacios(tb_Funcion))
            {
                MessageBox.Show("No se admiten campos vacios",":L",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            Double ErrorAproximado = 0;
            NewtonRhapson oNewtonRhapson = new NewtonRhapson(tb_Funcion.Text,
            Convert.ToSingle(tb_xi.Text), (tb_Derivada.Text), Convert.ToSingle(tb_P.Text));
            do
            {          
                if (iteracionN==0)
                {
                    dgv_Netwon.Rows.Add(iteracionN, oNewtonRhapson.CalcularXi(), 
                   oNewtonRhapson.Calcularfxi(), oNewtonRhapson.Calcularfxiderivada(),
                   oNewtonRhapson.CalcularERP(), '?');
                    iteracionN++;
                }
                dgv_Netwon.Rows.Add(iteracionN, oNewtonRhapson.CalcularXi(),
                    oNewtonRhapson.Calcularfxi(), oNewtonRhapson.Calcularfxiderivada(),
                    oNewtonRhapson.CalcularERP(),
                    oNewtonRhapson.CalcularEa(Convert.ToSingle(tb_xianterior.Text)));
                
                ErrorAproximado = oNewtonRhapson.CalcularEa(Convert.ToSingle(tb_xianterior.Text));

                tb_xianterior.Text = Convert.ToString(oNewtonRhapson.ximas1);

                iteracionN++;
            } while (ErrorAproximado>=Convert.ToSingle(tb_Es.Text));
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            tb_xianterior.Text = 0.ToString();
            tb_xi.Clear();
            tb_Es.Clear();
            tb_P.Clear();
            dgv_Netwon.Rows.Clear();
        }

        private void tb_xi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_Es_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_P_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }
    }
}
