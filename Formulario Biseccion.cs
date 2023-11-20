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
    public partial class Formulario_Biseccion : Form
    {
        public Formulario_Biseccion()
        {
            InitializeComponent();
        }
        
        private void btn_Calcular_Biseccion_Click(object sender, EventArgs e)
        {
            
            
            if(ValidarTextboxs.CamposVacios(tb_Funcion)||ValidarTextboxs.CamposVacios(tb_P) || ValidarTextboxs.CamposVacios(tb_Es) || ValidarTextboxs.CamposVacios(tb_Xl) || ValidarTextboxs.CamposVacios(tb_Xu))
            {
                MessageBox.Show("No se admiten campos vacios","e_e",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
           
            
         
           
           

            Double ValorEsperado = 0;
            int i=1;
            do
            {

                Biseccion oBiseccion = new Biseccion(Convert.ToSingle(tb_Xl.Text),Convert.ToSingle(tb_Xu.Text),
                    tb_Funcion.Text,Convert.ToSingle(tb_P.Text),Convert.ToSingle(tb_xranterior.Text));
                // Les pasamos los parámetros al constructor de la clase

                tb_xranterior.Text = Convert.ToString(oBiseccion.CalcularXr()); // TOMA XR ANTERIOR PARA PODER REALIZAR EL ERROR APROXIMADO


                dgv_Biseccion.Rows.Add(i,Convert.ToSingle(tb_Xl.Text), Convert.ToSingle(tb_Xu.Text), oBiseccion.CalcularXr(), oBiseccion.Calcularfxl(), 
                    oBiseccion.Calcularfxu(), oBiseccion.Calcularfxr(),oBiseccion.Calcularfxlfxr(),oBiseccion.CalcularERP(), oBiseccion.CalcularEa());
                // Mandamos llamar los métodos de la clase para que los agregue a un datagridview
                oBiseccion.Algoritmo(); // Mandamos llamar el algoritmo para saber si fxlfxr es mayor a cero y para saber si fxlfxr es menor que cero


                ValorEsperado = Convert.ToDouble(oBiseccion.CalcularEa());
                tb_Xl.Text = Convert.ToString(oBiseccion.xl);
                tb_Xu.Text = Convert.ToString(oBiseccion.xu);
                i=i+1;

            } while (ValorEsperado >= Convert.ToSingle(tb_Es.Text));  // El ciclo se repetirá mientras el error aproximado sea  mayor o igual que el error esperado                           
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Xu_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            tb_Ea.Text = "100";
            tb_xranterior.Text = 0.ToString();
            dgv_Biseccion.Rows.Clear();
            tb_P.Clear();
            tb_Xl.Clear();
            tb_Xu.Clear();
            tb_Es.Clear();
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
