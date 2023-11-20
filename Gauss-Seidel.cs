using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Expressions;

namespace Métodos_Numéricos_401
{
    public partial class Gauss_Seidel : Form
    {
        public Gauss_Seidel()
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
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (ValidarTextboxs.CamposVacios(tb_ErrorEsperado) || ValidarTextboxs.CamposVacios(tb_ValorInicial) || cb_Ecuaciones.Text == "")
            {
                MessageBox.Show("No se ademite campos vacios", ":I", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<string> NombreColumnas = new List<string>();
            for (int i = 0; i < dgv_Resultados.Columns.Count / 2; i++)
            {
                NombreColumnas.Add(dgv_Resultados.Columns[i].Name.ToString());
            }
            List<string> sEcuaciones = new List<string>();
            List<string> sEcuacionesAuxiliar = new List<string>();
            string[,] prueba = new string[50, 50];
            // CICLO QUE TOMA LA ECUACION DEL DATAGRIDVIEW Y LOS PASA A UNA LISTA
            for (int i = 0; i < dgv_Ecuaciones.Rows.Count; i++)
            {
                for (int a = 0; a < dgv_Ecuaciones.Columns.Count; a++)
                {
                    dgv_Ecuaciones.Rows[i].Selected = true;
                    try
                    {
                        //CONDICION EN LA QUE SE PRODUCE UNA EXCEPECION POR DIVIDIR ENTRE 0 PERO AL NO DIVIDIR ENTRE CERO, LA DIVISION NORMAL DARA 0
                        if (i % a == 0)
                        {
                            //LISTA EN LA QUE SE ALMACENAN LAS ECUACIONES INGRESADAS
                            sEcuaciones.Add(dgv_Ecuaciones.Rows[i].Cells[a].Value.ToString());
                            sEcuacionesAuxiliar.Add(dgv_Ecuaciones.Rows[i].Cells[a].Value.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                    dgv_Ecuaciones.Rows[i].Selected = false;
                }
            }
            // variables para dividir el calculo de los errores y de las variables
            int columnas = dgv_Resultados.Columns.Count / 2;
            //listas
            List<double> Resultados = new List<double>();
            List<double> Errores = new List<double>();
            int iteracion = 0;
            int gokussj1 = 0;
            int gokussj2 = 1;
            double xractual = 0;
            double xranterior = 0;
            // instanciamos un objeto que nos ayudara a realizar los calculos
            var values = new Dictionary<string, object>();
            //CICLO GENERAL DONDE SE REALIZA TODO EL PROCEDIMIENTO
            do
            {
                dgv_Resultados.Rows.Add();
                //CONDICION QUE SE EJECUTA SOLO CUANDO LA CONDICION DE LA ITERACION SE CUMPLA
                if (iteracion == 0) {for (int i = 0; i < NombreColumnas.Count; i++) {NombreColumnas[i] = NombreColumnas[i].ToUpper();values.Add(NombreColumnas[i], Convert.ToDouble(tb_ValorInicial.Text));}}         
                //CICLO DONDE SE CALCULA LOS RESULTADOS EVALUANDO LA ECUACION YA DESPEJADA
                Resultados.Clear();
                for (int i = 0; i < sEcuaciones.Count; i++){sEcuaciones[i] = sEcuaciones[i].ToUpper();Resultados.Add(Eval.Execute<double>(sEcuaciones[i], values));values[NombreColumnas[i]] = Resultados[i];}

                for (int i = 0; i < Resultados.Count; i++){dgv_Resultados.Rows[iteracion].Cells[i].Value = Resultados[i];}
                columnas= dgv_Resultados.Columns.Count / 2;
                Errores.Clear();
                //CICLO DONDE SE CALCULAN LOS ERRORES
                for (int i = 0; i < sEcuaciones.Count; i++)
                {
                    if (gokussj1 != 0)
                    {
                        xranterior = Convert.ToDouble(dgv_Resultados.Rows[gokussj1-1].Cells[i].Value);
                        xractual = Convert.ToDouble(dgv_Resultados.Rows[gokussj2 - 1].Cells[i].Value);
                    }
                    if(gokussj1 == 0)
                    {
                        for(int j=0; j <sEcuaciones.Count;j++)
                        {
                            dgv_Resultados.Rows[gokussj2 - 1].Cells[columnas].Value = 100;
                            columnas++;
                        }
                        columnas = dgv_Resultados.Columns.Count / 2;
                    }
                    else
                    {
                        dgv_Resultados.Rows[gokussj2 - 1].Cells[columnas].Value = Math.Abs(((xractual - xranterior) / xractual)) * 100;
                        Errores.Add(Math.Abs(((xractual - xranterior) / xractual) * 100));
                        columnas++;
                    }              
                }
                gokussj1++;
                gokussj2++;
                iteracion++;
            } while ((dgv_Resultados.ColumnCount / 2 != Errores.Where(a => a <= double.Parse(tb_ErrorEsperado.Text)).ToList().Count));
        }
        private void btn_nota_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tomar en cuenta para la multiplicacion el \"*\" al escribir la ecuación\n" +
                "y los paréntesis. También usar la variables X en mayúsculas");
        }
        private void tb_ErrorEsperado_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void cb_Ecuaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_ValorInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }
    }
}
