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
    public partial class Formulario_Falsa_Posición : Form
    {
        public Formulario_Falsa_Posición()
        {
            InitializeComponent();
        }

        private void btn_Calcular_FalsaPosicion_Click(object sender, EventArgs e)
        {

            if (ValidarTextboxs.CamposVacios(tb_P) || ValidarTextboxs.CamposVacios(tb_Es) || ValidarTextboxs.CamposVacios(tb_Xl) || ValidarTextboxs.CamposVacios(tb_Xu)||ValidarTextboxs.CamposVacios(tb_FuncionFP))
            {
                MessageBox.Show("No se admiten campos vacios", "e_e", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }







            int i = 1;
            Double ValorEsperado = 0;

            do
            {
                Falsa_Posicion oFalsaPosicion = new Falsa_Posicion(Convert.ToSingle(tb_Xl.Text), 
                    Convert.ToSingle(tb_Xu.Text), tb_FuncionFP.Text, 
                    Convert.ToSingle(tb_P.Text), Convert.ToSingle(tb_xranterior.Text));

                dgv_FalsaPosicion.Rows.Add(i, tb_Xl.Text, tb_Xu.Text, oFalsaPosicion.Calcularfxl(),
                    oFalsaPosicion.Calcularfxu(), oFalsaPosicion.CalcularXr(),
                    oFalsaPosicion.Calcularfxr(), oFalsaPosicion.Calcularfxlfxr(),
                    oFalsaPosicion.CalcularERP(), oFalsaPosicion.CalcularEa());

                tb_xranterior.Text = Convert.ToString(oFalsaPosicion.CalcularXr());

                ValorEsperado = Convert.ToDouble(oFalsaPosicion.CalcularEa());

                oFalsaPosicion.Algoritmo();
                tb_Xl.Text = Convert.ToString(oFalsaPosicion.xl);
                tb_Xu.Text = Convert.ToString(oFalsaPosicion.xu);
                i++;

            } while (ValorEsperado >= Convert.ToSingle(tb_Es.Text));          
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            tb_Ea.Text = "100";
            tb_xranterior.Text = "0";
            tb_P.Clear();
            tb_Xl.Clear();
            tb_Xu.Clear();
            tb_Es.Clear();
        }

        private void tb_P_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_P_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);

        }

        private void tb_Es_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_Xl_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_Xu_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }
    }
}
