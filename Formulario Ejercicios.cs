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
    public partial class Formulario_Ejercicios_Tema1 : Form
    {
        public Formulario_Ejercicios_Tema1()
        {
            InitializeComponent();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ejercicio_Errores_Click(object sender, EventArgs e)
        {
            pnl_Ejercicios.Visible = true;
            pnl_Ejercicios.BackgroundImage = Properties.Resources.Ejercicio_Errores;
            pnl_Ejercicios.BackgroundImageLayout= ImageLayout.Zoom;

            btn_Ejercicio_Errores.Visible = false;
            btn_Ejercicio_1.Visible = false;
            btn_Ejercicio_2.Visible = false;
            btn_Ejercicio_3.Visible = false;

                       
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            pnl_Ejercicios.Visible = false;

            pnl_Ejercicios.BackgroundImage = null;


            btn_Ejercicio_Errores.Visible = true;
            btn_Ejercicio_1.Visible = true;
            btn_Ejercicio_2.Visible = true;
            btn_Ejercicio_3.Visible = true;
        }

        private void btn_Ejercicio_1_Click(object sender, EventArgs e)
        {
            pnl_Ejercicios.Visible = true;
            pnl_Ejercicios.BackgroundImage = Properties.Resources.Eejercicio1_Tema1;
            pnl_Ejercicios.BackgroundImageLayout = ImageLayout.Zoom;

            btn_Ejercicio_Errores.Visible = false;
            btn_Ejercicio_1.Visible = false;
            btn_Ejercicio_2.Visible = false;
            btn_Ejercicio_3.Visible = false;
        }

        private void btn_Ejercicio_2_Click(object sender, EventArgs e)
        {
            pnl_Ejercicios.Visible = true;
            pnl_Ejercicios.BackgroundImage = Properties.Resources.Ejercicio2_Tema1;
            pnl_Ejercicios.BackgroundImageLayout = ImageLayout.Zoom;

            btn_Ejercicio_Errores.Visible = false;
            btn_Ejercicio_1.Visible = false;
            btn_Ejercicio_2.Visible = false;
            btn_Ejercicio_3.Visible = false;

        }

        private void btn_Ejercicio_3_Click(object sender, EventArgs e)
        {
            pnl_Ejercicios.Visible = true;
            pnl_Ejercicios.BackgroundImage = Properties.Resources.Ejercicio3_Tema1;
            pnl_Ejercicios.BackgroundImageLayout = ImageLayout.Zoom;

            btn_Ejercicio_Errores.Visible = false;
            btn_Ejercicio_1.Visible = false;
            btn_Ejercicio_2.Visible = false;
            btn_Ejercicio_3.Visible = false;
        }
    }
}
