using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Expressions;

namespace Métodos_Numéricos_401
{
    public partial class Formulario_Iterativo_Secuencial : Form
    {
        public Formulario_Iterativo_Secuencial()
        {
            InitializeComponent();
        }
        int contadorEc = 1;
        int contadorColumnas = 1;
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            btn_Limpiar_Click(sender, e);
            // Se agrega filas a un datagrid view donde se ingresaran las ecuaciones despejadas
            if (cb_Ecuaciones.Text == "")
            {
                MessageBox.Show("Ingrese el número de ecuaciones", "OOO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 0; i < Convert.ToInt32(cb_Ecuaciones.Text); i++)
            {
                dgv_Ecuaciones.Rows.Add($"X{contadorEc}=", "");
                DataGridViewTextBoxColumn columnasX = new DataGridViewTextBoxColumn();
                columnasX.HeaderText = $"X{contadorEc}";
                columnasX.Name = $"x{contadorEc}";
                dgv_Resultados.Columns.Add(columnasX);
                contadorEc++;
            }
            for (int i = 0; i < Convert.ToInt32(cb_Ecuaciones.Text); i++)
            {
                DataGridViewTextBoxColumn columnasEA = new DataGridViewTextBoxColumn();
                columnasEA.HeaderText = $"EA{contadorColumnas}";
                dgv_Resultados.Columns.Add(columnasEA);
                contadorColumnas++;
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            dgv_Ecuaciones.Rows.Clear();
            dgv_Resultados.Columns.Clear();
            contadorEc = 1;
            contadorColumnas = 1;
        }
    }
}
