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
    public partial class Formulario_Punto_Fijo : Form
    {
        public Formulario_Punto_Fijo()
        {
            InitializeComponent();
        }
        float i = 0;
        private void btn_Calcular_PuntoFijo_Click(object sender, EventArgs e)
        {
            if(ValidarTextboxs.CamposVacios(tb_Es)||ValidarTextboxs.CamposVacios(tb_P)||ValidarTextboxs.CamposVacios(tb_xi)||ValidarTextboxs.CamposVacios(tb_Funcion))
            {
                MessageBox.Show("No se admieten campos vacios", "u_u", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            Double ErrporAproximado = 0;
            do
            {
                Punto_Fijo oPuntoFijo = new Punto_Fijo( Convert.ToSingle(tb_xi.Text), Convert.ToSingle(tb_P.Text), tb_Funcion.Text, Convert.ToSingle(tb_xianterior.Text));

                if (i == 0)
                {
                    dgv_PuntoFijo.Rows.Add(i, tb_xi.Text, '?', '?');
                    i++;
                }
                
                dgv_PuntoFijo.Rows.Add(i, oPuntoFijo.CalcularXi(), oPuntoFijo.CalcularERP(),oPuntoFijo.CalcularEa());
                tb_xianterior.Text = Convert.ToString(oPuntoFijo.CalcularXi());
            i++;
            ErrporAproximado = oPuntoFijo.CalcularEa();
            } while (ErrporAproximado >= Convert.ToSingle(tb_Es.Text));

        }

        private void dgv_PuntoFijo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            dgv_PuntoFijo.Rows.Clear();
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
