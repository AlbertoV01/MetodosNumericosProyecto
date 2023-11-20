using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculus;
using Z;
using Z.Expressions;


namespace Métodos_Numéricos_401
{
    public partial class Formulario_Jacobi : Form
    {
        public Formulario_Jacobi()
        {
            InitializeComponent();
        }
        int contadorEc = 1;
        int contadorColumnas = 1;
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            btn_Limpiar_Click(sender, e);
            // Se agrega filas a un datagrid view donde se ingresaran las ecuaciones despejadas
            if(cb_Ecuaciones.Text=="")
            {
                MessageBox.Show("Ingrese el número de ecuaciones","OOO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            //Agrega las filas y las columnas al datagridview
            for (int i = 0; i < Convert.ToInt32(cb_Ecuaciones.Text); i++)
            {
                dgv_Ecuaciones.Rows.Add($"X{contadorEc}=", "");
                DataGridViewTextBoxColumn columnasX = new DataGridViewTextBoxColumn();
                columnasX.HeaderText = $"X{contadorEc}";
                columnasX.Name = $"x{contadorEc}";
                dgv_Resultados.Columns.Add(columnasX);


                contadorEc++;
            }
            //Agrega las columnas de los errores
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
            if (ValidarTextboxs.CamposVacios(tb_ErrorEsperado)||ValidarTextboxs.CamposVacios(tb_ValorInicial)||cb_Ecuaciones.Text=="")
            {
                MessageBox.Show("No se ademite campos vacios",":I",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            List<string> NombreColumnas = new List<string>();
            for (int i = 0; i < dgv_Resultados.Columns.Count / 2; i++)
            {
                NombreColumnas.Add(dgv_Resultados.Columns[i].Name.ToString());
            }
            Jacobi.ValorInicial = Convert.ToDouble(tb_ValorInicial.Text);
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
            int columnasDivididas = dgv_Resultados.Columns.Count;
            int columnas = dgv_Resultados.Columns.Count / 2;
            int columnasextra= dgv_Resultados.Columns.Count / 2; 
            // variables usadas para los ciclos
            int cicloerrores = dgv_Resultados.Columns.Count / 2;
            //listas
            List<double> ResultadosVariableI0 = new List<double>();
            List<string> NuevasEcuaciones = new List<string>();
            List<string> VariablesGuardadas = new List<string>();
            List<double>Errores=new List<double>();
            NuevasEcuaciones = sEcuaciones;
            double result = 0;        
            //CICLO DONDE LAS VARIABLES INGRESADAS SE REMPLAZAN POR EL VALOR INICIAL
            for (int i = 0; i < sEcuaciones.Count; i++)
            {
                for (int j = sEcuaciones.Count; j > 0; j--)
                {
                    if (NombreColumnas[i] == dgv_Resultados.Columns[i].Name)
                    {
                        NuevasEcuaciones[j - 1] = sEcuaciones[j - 1].Replace(NombreColumnas[i], $"({tb_ValorInicial.Text})");
                    }
                }
            }
            //CICLO DONDE SE MUESTRAN LOS VALORES OBTENIDOS DE LOS RESULTADOS DE EVALUAR LA ECUACION
            dgv_Resultados.Rows.Add();
            for (int i = 0; i < sEcuaciones.Count; i++)
            {
                result = Eval.Execute<double>(NuevasEcuaciones[i]);
                dgv_Resultados.Rows[0].Cells[i].Value = result;
                dgv_Resultados.Rows[0].Cells[columnas].Value = 100;
                
                columnas++;
            }
              sEcuaciones = sEcuacionesAuxiliar;
            //    //CICLO DONDE SE REALIZARÁ TODO EL PROCEDIMIENTO TOMANDO LOS VALORES DE LA FILA 0 DEL DATAGRIDVIEW
            int gokussj1 = 0;
            int gokussj2 = 1;
            int iteraciones = 0;
            double xranterior = 0;
            double xractual = 0;
            do
            {
                dgv_Resultados.Rows.Add();
                NuevasEcuaciones.Clear();
                for (int i=0;i<sEcuacionesAuxiliar.Count;i++)
                {
                    NuevasEcuaciones.Add (sEcuacionesAuxiliar[i]);
                }
                var x = string.Empty;
                for (int i = 0; i < sEcuacionesAuxiliar.Count; i++)
                {
                    for (int j = sEcuacionesAuxiliar.Count; j > 0; j--)
                    {
                        if (NombreColumnas[i] == dgv_Resultados.Columns[i].Name)
                        {
                            x = dgv_Resultados.Rows[gokussj1].Cells[i].Value.ToString();
                        }

                        if(sEcuaciones[j-1].Contains(NombreColumnas[i]))
                        NuevasEcuaciones[j - 1] = NuevasEcuaciones[j - 1].Replace(NombreColumnas[i], $"({x})");
                    }
                }
                //Se reinicia el valor de la variable de columnas a como estaba al inicio
                columnas = dgv_Resultados.Columns.Count / 2;

                for (int i = 0; i < sEcuaciones.Count; i++)
                {
                    result = Eval.Execute<double>(NuevasEcuaciones[i]);
                    dgv_Resultados.Rows[gokussj2].Cells[i].Value = result;              
                }
                Errores.Clear();
                //CICLO DONDE SE CACLULARA LOS ERRORES
                for (int i = 0;i<sEcuaciones.Count;i++)
                {
                    xractual = Convert.ToDouble(dgv_Resultados.Rows[gokussj2].Cells[i].Value);
                    xranterior = Convert.ToDouble(dgv_Resultados.Rows[gokussj2 - 1].Cells[i].Value);
                    dgv_Resultados.Rows[gokussj2].Cells[columnas].Value = Math.Abs(((xractual - xranterior) / xractual) * 100);
                    Errores.Add(((xractual - xranterior) / xractual) * 100);
                    columnas++;
                }                        
                gokussj1++;
                gokussj2++;
                iteraciones++;               
            } while ((dgv_Resultados.ColumnCount / 2 != Errores.Where(a => a <= double.Parse(tb_ErrorEsperado.Text)).ToList().Count)); 
        }
        private void tb_ValorInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }
        private void tb_ErrorEsperado_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }
        private void cb_Ecuaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }
        private void btn_nota_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese el valor inicial con decimal aunque sea un número entero\n" +
                "ejemplo: 0.0, 1.0, 2.0, 3.0, 4.0, 5.0");
        }
    }
}
