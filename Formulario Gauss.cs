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
    public partial class Formulario_Gauss : Form
    {
        public Formulario_Gauss()
        {
            InitializeComponent();
        }
        Boolean Entrada = false;
        //Matriz de TextBoxs de ecuacion 2x2
        public TextBox[,] Renglon_2x2 = new TextBox[2, 3];
        //Matriz tipo double que se utiliza para convertir los datos de la Matriz de TextBoxs
        public double[,] dRenglon_2x2 = new double[2, 3];
        //Matriz que se usa para mostrar la matriz original
        private float[,]fRenglon_2x2=new float[2, 3];
        //Matriz de TextBoxs de ecuacion 3x3 
        public TextBox[,] Renglon_3x3 = new TextBox[3, 4];
        //Matriz tipo double que se utiliza para convertir los datos de la matriz de textboxs
        private double[,] dRenglon_3x3 = new double[3, 4];
        //Matriz que se usa para mostrar la matriz original
        private float[,] fRenglon_3x3 = new float[3, 4];
        //Matriz de textboxs de ecuacion 4x4
        public TextBox[,] Matriz4x4 = new TextBox[4, 5];
        //Matriz Tipo double
        public double[,] dMatriz4x4 = new double[4, 5];
        // Matriz tip float
        public float[,] fMatriz4x4 = new float[4, 5];
        Panel panel1 = new Panel();
        //int contador = 0;


        Calculo oCalculo = new Calculo();
        Boolean entrada2x2 = false;
        Boolean entrada3x3 = false;
        Boolean entrada4x4 = false;
   

        //EVENTOS DE LOS TEXBOX
        //2X2
        private void TextBox00_Enter(object sender, EventArgs e)
        {

            Renglon_2x2[0, 0].Text = "";
        }
        private void TextBox00_Leave (object sender, EventArgs e)
        {
            if (Renglon_2x2[0, 0].Text == "")
            {

                Renglon_2x2[0, 0].Text = "X";

            }
        }
        private void TextBox01_Enter(object sender,EventArgs e)
        {

            Renglon_2x2[0, 1].Text = "";
           
        }
        private void TextBox01_Leave(object sender,EventArgs e)
        {
            if (Renglon_2x2[0, 1].Text == "")
            {

                Renglon_2x2[0, 1].Text = "Y";

            }
        }
        private void TextBox10_Enter (object sender, EventArgs e)
        {

            Renglon_2x2[1, 0].Text = "";
        }
        private void TextBox10_Leave (object sender,EventArgs e)
        {
            if (Renglon_2x2[1, 0].Text == "")
            {

                Renglon_2x2[1, 0].Text = "X";

            }
        }
        private void TextBox11_Enter(object sender, EventArgs e)
        {
            Renglon_2x2[1,1].Text ="";

        }

        private void TextBox11_Leave(object sender, EventArgs e)
        {
            if (Renglon_2x2[1, 1].Text == "")
            {

                Renglon_2x2[1, 1].Text = "Y";

            }          
        }
        private void TextBox02_Enter(object sender, EventArgs e)
        {
            if (Renglon_2x2[0, 2].Text != "")
            {
                Renglon_2x2[0, 2].Text = "";
            }
        }
        private void TextBox12_Leave (object sender, EventArgs e)
        {
           

        }
        private void TextBox12_Enter (object sender, EventArgs e)
        {
            if (Renglon_2x2[1,2].Text != "")
            {
                

                Renglon_2x2[1, 2].Text = "";

            }
        }

        //3x3

        //-------------------------------------------------
        private void TextBox3x300_Enter(object sender, EventArgs e)
        {
            if(Renglon_3x3[0,0].Text != "")
            Renglon_3x3[0, 0].Text = "";
        }
        private void TextBox3x300_Leave(object sender, EventArgs e)
        {
            if (Renglon_3x3[0,0].Text=="")
            Renglon_3x3[0, 0].Text = "x";
        }
        private void TextBox3x301_Enter(object sender, EventArgs e)
        {
            if (Renglon_3x3[0, 1].Text != "")
                Renglon_3x3[0, 1].Text = "";
        }
        private void TextBox3x301_Leave(object sender, EventArgs e)
        {
            if(Renglon_3x3[0,1].Text=="")
            Renglon_3x3[0, 1].Text = "y";
        }
        private void TextBox3x302_Enter(object sender, EventArgs e)
        {
            if (Renglon_3x3[0, 2].Text != "")
                Renglon_3x3[0, 2].Text = "";
        }
        private void TextBox3x302_Leave(object sender, EventArgs e)
        {
            if (Renglon_3x3[0,2].Text=="")
            Renglon_3x3[0, 2].Text = "z";
        }

        private void TextBox3x310_Enter(object sender, EventArgs e)
        {
            if (Renglon_3x3[1, 0].Text != "")
                Renglon_3x3[1, 0].Text = "";
        }
        private void TextBox3x310_Leave(object sender, EventArgs e)
        {
            if (Renglon_3x3[1,0].Text=="")
            Renglon_3x3[1, 0].Text = "x";
        }
        private void TextBox3x311_Enter(object sender, EventArgs e)
        {
            if (Renglon_3x3[1, 1].Text != "")
                Renglon_3x3[1, 1].Text = "";
        }
        private void TextBox3x311_Leave(object sender, EventArgs e)
        {
            if(Renglon_3x3[1,1].Text=="")
            Renglon_3x3[1, 1].Text = "y";
        }
        private void TextBox3x312_Enter(object sender, EventArgs e)
        {
            if (Renglon_3x3[1, 2].Text != "")
                Renglon_3x3[1, 2].Text = "";
        }
        private void TextBox3x312_Leave(object sender, EventArgs e)
        {
            if(Renglon_3x3[1,2].Text=="")
            Renglon_3x3[1, 2].Text = "z";
        }

        private void TextBox3x320_Enter(object sender, EventArgs e)
        {
            if (Renglon_3x3[2, 0].Text != "")
                Renglon_3x3[2, 0].Text = "";
        }
        private void TextBox3x320_Leave(object sender, EventArgs e)
        {
            if(Renglon_3x3[2,0].Text=="")
            Renglon_3x3[2, 0].Text = "x";
        }
        private void TextBox3x321_Enter(object sender, EventArgs e)
        {
            if (Renglon_3x3[2, 1].Text != "")
                Renglon_3x3[2, 1].Text = "";
        }
        private void TextBox3x321_Leave(object sender, EventArgs e)
        {
            if(Renglon_3x3[2,1].Text=="")
            Renglon_3x3[2, 1].Text = "y";
        }
        private void TextBox3x322_Enter(object sender, EventArgs e)
        {
            if (Renglon_3x3[2, 2].Text != "")
                Renglon_3x3[2, 2].Text = "";
        }
        private void TextBox3x322_Leave(object sender, EventArgs e)
        {
            if (Renglon_3x3[2,2].Text=="")
            Renglon_3x3[2, 2].Text = "z";
        }

        private void TextBox3x303_Enter(object sender, EventArgs e)
        {
            Renglon_3x3[0, 3].Text = "";
        }
        private void TextBox3x313_Enter(object sender, EventArgs e)
        {
            Renglon_3x3[1, 3].Text = "";

        }
        private void TextBox3x323_Enter(object sender, EventArgs e)
        {
            Renglon_3x3[2, 3].Text = "";

        }

        // 4x4 -------------------------------------------------------
        private void Textbox4x400_Enter(object sender, EventArgs e)
        {
            if(Matriz4x4[0,0].Text!="")
            Matriz4x4[0,0].Text = "";
        }
        private void Textbox4x400_Leave(object sender, EventArgs e)
        {
           if (Matriz4x4[0, 0].Text =="")
           {
                Matriz4x4[0, 0].Text = "W";
           }          
        }
        private void Textbox4x401_Enter(object sender, EventArgs e)
        {
            if (Matriz4x4[0, 1].Text != "")
                Matriz4x4[0, 1].Text = "";
        }
        private void Textbox4x401_Leave(object sender, EventArgs e)
        {
            if (Matriz4x4[0, 1].Text == "")
            {
                Matriz4x4[0, 1].Text = "X";
            }
        }
        private void Textbox4x402_Enter(object sender, EventArgs e)
        {
            if (Matriz4x4[0, 2].Text != "")
                Matriz4x4[0, 2].Text = "";
        }
        private void Textbox4x402_Leave(object sender, EventArgs e)
        {
            if (Matriz4x4[0, 2].Text == "")
            {
                Matriz4x4[0, 2].Text = "Y";
            }

        }
        private void Textbox4x403_Enter(object sender, EventArgs e)
        {
            if (Matriz4x4[0, 3].Text != "")
                Matriz4x4[0, 3].Text = "";
        }
        private void Textbox4x403_Leave(object sender, EventArgs e)
        {
            if (Matriz4x4[0, 3].Text == "")
            {
                Matriz4x4[0, 3].Text = "Z";
            }
        }
        private void Textbox4x410_Enter(object sender, EventArgs e)
        {
            if (Matriz4x4[1, 0].Text != "")
                Matriz4x4[1, 0].Text = "";
        }
        private void Textbox4x410_Leave(object sender, EventArgs e)
        {
            if (Matriz4x4[1, 0].Text == "")
            {
                Matriz4x4[1, 0].Text = "W";
            }
        }
        private void Textbox4x411_Enter(object sender, EventArgs e)
        {
            if (Matriz4x4[1, 1].Text != "")
                Matriz4x4[1, 1].Text = "";
        }
        private void Textbox4x411_Leave(object sender, EventArgs e)
        {
            if (Matriz4x4[1, 1].Text == "")
            {
                Matriz4x4[1, 1].Text = "X";
            }

        }
        private void Textbox4x412_Enter(object sender, EventArgs e)
        {
            if (Matriz4x4[1, 2].Text != "")
                Matriz4x4[1, 2].Text = "";
        }
        private void Textbox4x412_Leave(object sender, EventArgs e)
        {
            if (Matriz4x4[1, 2].Text == "")
            {
                Matriz4x4[1, 2].Text = "Y";
            }
        }
        private void TextBox4x413_Enter(object sender, EventArgs e)
        {
            if (Matriz4x4[1, 3].Text != "")
                Matriz4x4[1, 3].Text = "";
        }
        private void TextBox4x413_Leave(object sender, EventArgs e)
        {
            if (Matriz4x4[1, 3].Text == "")
            {
                Matriz4x4[1, 3].Text = "Z";
            }
        }
        private void TextBox4x420_Enter(object sender, EventArgs e)
        {
            if (Matriz4x4[2, 0].Text != "")
                Matriz4x4[2, 0].Text = "";
        }
        private void TextBox4x420_Leave(object sender, EventArgs e)
        {
            if (Matriz4x4[2, 0].Text == "")
            {
                Matriz4x4[2, 0].Text = "W";
            }
        }
        private void TextBox4x421_Enter(object sender, EventArgs e)
        {
            if (Matriz4x4[2, 1].Text != "")
                Matriz4x4[2, 1].Text = "";
        }
        private void TextBox4x421_Leave(object sender, EventArgs e)
        {
            if (Matriz4x4[2, 1].Text == "")
            {
                Matriz4x4[2, 1].Text = "X";
            }
        }
        private void TextBox4x422_Enter(object sender, EventArgs e)
        {
            if (Matriz4x4[2, 2].Text != "")
                Matriz4x4[2, 2].Text = "";
        }
        private void TextBox4x422_Leave(object sender, EventArgs e)
        {
            if (Matriz4x4[2, 2].Text == "")
            {
                Matriz4x4[2, 2].Text = "Y";
            }
        }
        private void TextBox4x423_Enter(object sender, EventArgs e)
        {
            if (Matriz4x4[2, 3].Text != "")
                Matriz4x4[2, 3].Text = "";
        }
        private void TextBox4x423_Leave(object sender, EventArgs e)
        {
            if (Matriz4x4[2, 3].Text == "")
            {
                Matriz4x4[2, 3].Text = "Z";
            }
        }
        private void TextBox4x430_Enter(object sender, EventArgs e)
        {
            if (Matriz4x4[3, 0].Text != "")
                Matriz4x4[3, 0].Text = "";
        }
        private void TextBox4x430_Leave(object sender, EventArgs e)
        {
            if (Matriz4x4[3, 0].Text == "")
            {
                Matriz4x4[3, 0].Text = "W";
            }

        }
        private void TextBox4x431_Enter(object sender, EventArgs e)
        {
            if (Matriz4x4[3, 1].Text != "")
                Matriz4x4[3, 1].Text = "";
        }
        private void TextBox4x431_Leave(object sender, EventArgs e)
        {
            if (Matriz4x4[3, 1].Text == "")
            {
                Matriz4x4[3, 1].Text = "X";
            }

        }
        private void TextBox4x432_Enter(object sender, EventArgs e)
        {
            if (Matriz4x4[3, 2].Text != "")
                Matriz4x4[3, 2].Text = "";
        }
        private void TextBox4x432_Leave(object sender, EventArgs e)
        {
            if (Matriz4x4[3, 2].Text == "")
            {
                Matriz4x4[3, 2].Text = "Y";
            }

        }
        private void TextBox4x433_Enter(object sender, EventArgs e)
        {
            if (Matriz4x4[3, 3].Text != "")
                Matriz4x4[3, 3].Text = "";
        }
        private void TextBox4x433_Leave(object sender, EventArgs e)
        {
            if (Matriz4x4[3, 3].Text == "")
            {
                Matriz4x4[3, 3].Text = "Z";
            }

        }      
        private void TextBox4x404_Enter(object sender, EventArgs e)
        {
                Matriz4x4[0, 4].Text = "";
        }
        private void TextBox4x414_Enter(object sender, EventArgs e)
        {
            Matriz4x4[1, 4].Text = "";

        }
        private void TextBox4x424_Enter(object sender, EventArgs e)
        {
            Matriz4x4[2, 4].Text = "";

        }
        private void TextBox4x434_Enter(object sender, EventArgs e)
        {
            Matriz4x4[3, 4].Text = "";

        }


        private void btn_Agregar_Ecuacion_Click(object sender, EventArgs e)
        {
            Entrada = true;
            switch (cb_Orden_Matriz.Text)
            {
                //CASO PARA AGREGAR LA MATRIZ 2X2 DE TEXTBOXS
                case "2x2":
                    //SI SE CUMPLE LA CONDICION SE LIMPIARA DEL FORMS LOS TEXTBOS CREADOS DE LA MATRIZ 3X3
                    if (entrada3x3)
                    {
                        for (int i = 0; i < Renglon_3x3.GetLength(0); i++)
                        {
                            for (int j = 0; j < Renglon_3x3.GetLength(1); j++)
                            {
                                Renglon_3x3[i, j].Dispose();
                            }
                        }
                        entrada3x3 = false;
                    }
                    if (entrada4x4)
                    {
                        for (int i = 0; i < Matriz4x4.GetLength(0); i++)
                        {
                            for (int j = 0; j < Matriz4x4.GetLength(1); j++)
                            {
                                Controls.Remove(Matriz4x4[i, j]);
                            }
                        }
                    }
                    int x = 10;
                    int y = 10;
                    int varaux_2x2 = 10;
                    //CICLO PARA AGREGAR TODOS LOS TEXTBOX DE LA MATRIZ 2X2
                    for (int filas = 0; filas < Renglon_2x2.GetLength(0); filas++)
                    {
                        for (int columnas = 0; columnas < Renglon_2x2.GetLength(1); columnas++)
                        {                 
                            Renglon_2x2[filas, columnas] = new TextBox();
                            Renglon_2x2[filas, columnas].Location = new Point(x, y);
                            x += 40;
                            if (columnas == 1)
                            {
                                panel1.Location = new Point(78, 10);
                                panel1.BackColor = Color.Black;
                                panel1.Size = new Size(5, 53);
                                Controls.Add(panel1);
                                varaux_2x2 = 40;
                            }
                            if (columnas == 2)
                            {
                                x = 10;
                                y = 40;
                            }
                            Renglon_2x2[filas, columnas].ForeColor = Color.Gray;
                            Renglon_2x2[filas, columnas].Name = String.Concat("Renglon2x2", filas.ToString(), columnas.ToString());
                            Renglon_2x2[filas, columnas].Size = new Size(20, 20);
                            //ASIGNACION DE EVENTOS ENTER Y LEAVE A LOS TEXBOX DE LA MATRIZ
                            if (filas == 0 && columnas == 0)
                            {
                                Renglon_2x2[filas, columnas].Text = "X";
                                Renglon_2x2[filas, columnas].Enter += TextBox00_Enter;
                                Renglon_2x2[filas, columnas].Leave += TextBox00_Leave;
                            }
                            if (filas == 0 && columnas == 1)
                            {
                                Renglon_2x2[filas, columnas].Text = "Y";
                                Renglon_2x2[filas, columnas].Enter += TextBox01_Enter;
                                Renglon_2x2[filas, columnas].Leave += TextBox01_Leave;
                            }
                            if (filas == 1 && columnas == 0)
                            {
                                Renglon_2x2[filas, columnas].Text = "X";
                                Renglon_2x2[filas, columnas].Enter += TextBox10_Enter;
                                Renglon_2x2[filas, columnas].Leave += TextBox10_Leave;
                            }
                            if (filas == 1 && columnas == 1)
                            {
                                Renglon_2x2[filas, columnas].Text = "Y";
                                Renglon_2x2[filas, columnas].Enter += TextBox11_Enter;
                                Renglon_2x2[filas, columnas].Leave += TextBox11_Leave;

                            }
                            if (filas == 0 && columnas == 2)
                            {
                                Renglon_2x2[filas, columnas].Text = "";
                                Renglon_2x2[filas, columnas].Enter += TextBox02_Enter;
                            }
                            if (filas == 1 && columnas == 2)
                            {
                                Renglon_2x2[filas, columnas].Text = "";
                                Renglon_2x2[filas, columnas].Enter += TextBox12_Enter;
                                Renglon_2x2[filas, columnas].Leave += TextBox12_Leave;
                            }
                            Renglon_2x2[filas, columnas].Visible = true;
                            Controls.Add(Renglon_2x2[filas, columnas]);

                        }
                    }
                    entrada2x2 = true;
                    break;

                // CASO PARA AGREGAR LA MATRIZ 3X3 DE TEXTBOXS
                case "3x3":
                    //SI SE CUMPLE LA CONDICION SE LIMPIARA DEL FORMS LOS TEXTBOXS CREADOS DE LAS OTRAS MATRICEZ
                    if (entrada2x2)
                    {
                        for (int i = 0; i < Renglon_2x2.GetLength(0); i++)
                        {
                            for (int j = 0; j < Renglon_2x2.GetLength(1); j++)
                            {
                                //   Renglon_2x2[i, j].Dispose();
                                Controls.Remove(Renglon_2x2[i, j]);
                            }
                        }
                        entrada2x2 = false;
                    }


                    if (entrada4x4)
                    {
                        for (int i = 0; i < Matriz4x4.GetLength(0); i++)
                        {
                            for (int j = 0; j < Matriz4x4.GetLength(1); j++)
                            {
                                Controls.Remove(Matriz4x4[i, j]);
                            }
                        }
                    }
                    int x_3x3 = 10;
                    int y_3x3 = 10;
                    int varaux_3x3 = 10;
                    // CICLO PARA AGREGAR TODOS LOS TEXTBOX DE LA MATRIZ 3X3
                    for (int filas = 0; filas < Renglon_3x3.GetLength(0); filas++)
                    {
                        for (int columnas = 0; columnas < Renglon_3x3.GetLength(1); columnas++)
                        {
                            Renglon_3x3[filas, columnas] = new TextBox();
                            Renglon_3x3[filas, columnas].Location = new Point(x_3x3, y_3x3);
                            x_3x3 += 40;
                            if (columnas == 2)
                            {
                                panel1.Location = new Point(126, 10);
                                panel1.BackColor = Color.Black;
                                panel1.Size = new Size(3, 83);
                                Controls.Add(panel1);
                            }
                            if (columnas == 3)
                            {
                                x_3x3 = 10;
                                y_3x3 = 40;
                            }
                            if (filas == 1 && columnas == 3)
                            {
                                x_3x3 = 10;
                                y_3x3 = 70;
                            }
                            Renglon_3x3[filas, columnas].ForeColor = Color.Gray;
                            Renglon_3x3[filas, columnas].Name = String.Concat("Renglon3X3", filas.ToString(), columnas.ToString());
                            Renglon_3x3[filas, columnas].Size = new Size(35, 35);
                            //Renglon_3x3[filas, columnas].Text = filas.ToString() + columnas.ToString();
                            if (filas == 0 && columnas == 0)
                            {
                                Renglon_3x3[filas, columnas].Text = "X";
                                Renglon_3x3[filas, columnas].Enter += TextBox3x300_Enter;
                                Renglon_3x3[filas, columnas].Leave += TextBox3x300_Leave;
                            }
                            if (filas == 0 && columnas == 1)
                            {
                                Renglon_3x3[filas, columnas].Text = "Y";
                                Renglon_3x3[filas, columnas].Enter += TextBox3x301_Enter;
                                Renglon_3x3[filas, columnas].Leave += TextBox3x301_Leave;
                            }
                            if (filas == 0 && columnas == 2)
                            {
                                Renglon_3x3[filas, columnas].Text = "Z";
                                Renglon_3x3[filas, columnas].Enter += TextBox3x302_Enter;
                                Renglon_3x3[filas, columnas].Leave += TextBox3x302_Leave;
                            }

                            if (filas == 1 && columnas == 0)
                            {
                                Renglon_3x3[filas, columnas].Text = "X";
                                Renglon_3x3[filas, columnas].Enter += TextBox3x310_Enter;
                                Renglon_3x3[filas, columnas].Leave += TextBox3x310_Leave;
                            }
                            if (filas == 1 && columnas == 1)
                            {
                                Renglon_3x3[filas, columnas].Text = "Y";
                                Renglon_3x3[filas, columnas].Enter += TextBox3x311_Enter;
                                Renglon_3x3[filas, columnas].Leave += TextBox3x311_Leave;
                            }
                            if (filas == 1 && columnas == 2)
                            {
                                Renglon_3x3[filas, columnas].Text = "Z";
                                Renglon_3x3[filas, columnas].Enter += TextBox3x312_Enter;
                                Renglon_3x3[filas, columnas].Leave += TextBox3x312_Leave;
                            }

                            if (filas == 2 && columnas == 0)
                            {
                                Renglon_3x3[filas, columnas].Text = "X";
                                Renglon_3x3[filas, columnas].Enter += TextBox3x320_Enter;
                                Renglon_3x3[filas, columnas].Leave += TextBox3x320_Leave;
                            }
                            if (filas == 2 && columnas == 1)
                            {
                                Renglon_3x3[filas, columnas].Text = "Y";
                                Renglon_3x3[filas, columnas].Enter += TextBox3x321_Enter;
                                Renglon_3x3[filas, columnas].Leave += TextBox3x321_Leave;
                            }
                            if (filas == 2 && columnas == 2)
                            {
                                Renglon_3x3[filas, columnas].Text = "Z";
                                Renglon_3x3[filas, columnas].Enter += TextBox3x322_Enter;
                                Renglon_3x3[filas, columnas].Leave += TextBox3x322_Leave;
                            }
                            if (filas == 0 && columnas == 3)
                            {
                                Renglon_3x3[filas, columnas].Text = "";
                                Renglon_3x3[filas, columnas].Enter += TextBox3x303_Enter;
                            }
                            if (filas == 1 && columnas == 3)
                            {
                                Renglon_3x3[filas, columnas].Text = "";
                                Renglon_3x3[filas, columnas].Enter += TextBox3x313_Enter;
                            }
                            if (filas == 2 && columnas == 3)
                            {
                                Renglon_3x3[filas, columnas].Text = "";
                                Renglon_3x3[filas, columnas].Enter += TextBox3x323_Enter;
                            }


                            Renglon_3x3[filas, columnas].Visible = true;
                            Controls.Add(Renglon_3x3[filas, columnas]);
                        }
                    }

                    entrada3x3 = true;

                    break;
                //CASO PARA AFREFAR LA MATRIZ 4X4 DE TEXTBOXS

                case "4x4":
                    //SI SE CUMPLE LA CONDICION SE LIMPIARA DEL FORMS LOS TEXTBOXS CREADOS DE LAS OTRAS MATRICEZ

                    if (entrada2x2 == true)
                    {
                        for (int i = 0; i < Renglon_2x2.GetLength(0); i++)
                        {
                            for (int j = 0; j < Renglon_2x2.GetLength(1); j++)
                            {

                                Controls.Remove(Renglon_2x2[i, j]);
                            }
                        }
                    }
                    if (entrada3x3 == true)
                    {
                        for (int i = 0; i < Renglon_3x3.GetLength(0); i++)
                        {
                            for (int j = 0; j < Renglon_3x3.GetLength(1); j++)
                            {

                                Controls.Remove(Renglon_3x3[i, j]);
                            }
                        }
                    }
                    int x_4x4 = 10;
                    int y_4x4 = 10;
                    int varaux_4x4 = 10;
                   
                    for (int filas = 0; filas < Matriz4x4.GetLength(0); filas++)
                    {
                        for (int columnas = 0; columnas < Matriz4x4.GetLength(1); columnas++)
                        {

                            Matriz4x4[filas, columnas] = new TextBox();
                            Matriz4x4[filas, columnas].Location = new Point(x_4x4, y_4x4);

                            x_4x4 += 40;

                            if (columnas == 3)
                            {
                                panel1.Location = new Point(166, 10);
                                panel1.BackColor = Color.Black;
                                panel1.Size = new Size(3, 113);
                                Controls.Add(panel1);

                            }

                            if (columnas == 4)
                            {
                                x_4x4 = 10;
                                y_4x4 = 40;
                            }
                            if (filas == 1 && columnas == 4)
                            {
                                x_4x4 = 10;
                                y_4x4 = 70;
                            }
                            if (filas == 2 && columnas == 4)
                            {
                                x_4x4 = 10;
                                y_4x4 = 100;
                            }

                            Matriz4x4[filas, columnas].ForeColor = Color.Gray;
                            Matriz4x4[filas, columnas].Name = String.Concat("Renglon4X4", filas.ToString(), columnas.ToString());
                            Matriz4x4[filas, columnas].Size = new Size(35, 35);
                            //Renglon_3x3[filas, columnas].Text = 
                            if (filas == 0 && columnas == 0)
                            {
                                Matriz4x4[filas, columnas].Text = "W";
                                Matriz4x4[filas, columnas].Enter += Textbox4x400_Enter;
                                Matriz4x4[filas, columnas].Leave += Textbox4x400_Leave; ;
                            }
                            if (filas == 0 && columnas == 1)
                            {
                                Matriz4x4[filas, columnas].Text = "X"; 
                                 Matriz4x4[filas, columnas].Enter += Textbox4x401_Enter;
                                Matriz4x4[filas, columnas].Leave += Textbox4x401_Leave;
                            }
                            if (filas == 0 && columnas == 2)
                            {
                                Matriz4x4[filas, columnas].Text = "Y";
                                Matriz4x4[filas, columnas].Enter += Textbox4x402_Enter;
                                Matriz4x4[filas, columnas].Leave += Textbox4x402_Leave;
                            }
                            if (filas==0 && columnas == 3)
                            {
                                Matriz4x4[filas, columnas].Text = "Z";
                                Matriz4x4[filas, columnas].Enter += Textbox4x403_Enter;
                                Matriz4x4[filas, columnas].Leave += Textbox4x403_Leave;
                            }

                            if (filas == 1 && columnas == 0)
                            {
                                Matriz4x4[filas, columnas].Text = "W";
                                Matriz4x4[filas, columnas].Enter += Textbox4x410_Enter;
                                Matriz4x4[filas, columnas].Leave += Textbox4x410_Leave;
                            }
                            if (filas == 1 && columnas == 1)
                            {
                                Matriz4x4[filas, columnas].Text = "X";
                                Matriz4x4[filas, columnas].Enter += Textbox4x411_Enter;
                                Matriz4x4[filas, columnas].Leave += Textbox4x411_Leave;
                            }
                            if (filas == 1 && columnas == 2)
                            {
                                Matriz4x4[filas, columnas].Text = "Y";
                                Matriz4x4[filas, columnas].Enter += Textbox4x412_Enter;
                                Matriz4x4[filas, columnas].Leave += Textbox4x412_Leave;
                            }
                            if (filas == 1 && columnas == 3)
                            {
                                Matriz4x4[filas, columnas].Text = "Z";
                                Matriz4x4[filas, columnas].Enter += TextBox4x413_Enter;
                                Matriz4x4[filas, columnas].Leave += TextBox4x413_Leave;
                            }

                            if (filas == 2 && columnas == 0)
                            {
                                Matriz4x4[filas, columnas].Text = "W";
                                Matriz4x4[filas, columnas].Enter += TextBox4x420_Enter;
                                Matriz4x4[filas, columnas].Leave += TextBox4x420_Leave;
                            }
                            if (filas == 2 && columnas == 1)
                            {
                                Matriz4x4[filas, columnas].Text = "X";
                                Matriz4x4[filas, columnas].Enter += TextBox4x421_Enter;
                                Matriz4x4[filas, columnas].Leave += TextBox4x421_Leave;                          
                            }
                            if (filas == 2 && columnas == 2)
                            {
                                Matriz4x4[filas, columnas].Text = "Y";
                                Matriz4x4[filas, columnas].Enter += TextBox4x422_Enter;
                                Matriz4x4[filas, columnas].Leave += TextBox4x422_Leave;
                            }
                            if (filas == 2 && columnas == 3)
                            {
                                Matriz4x4[filas, columnas].Text = "Z";
                                Matriz4x4[filas, columnas].Enter += TextBox4x423_Enter;
                                Matriz4x4[filas,columnas].Leave+=TextBox4x423_Leave;
                            }
                            if (filas == 3 && columnas == 0)
                            {
                                Matriz4x4[filas, columnas].Text = "W";
                                Matriz4x4[filas, columnas].Enter += TextBox4x430_Enter;
                                Matriz4x4[filas, columnas].Leave += TextBox4x430_Leave;
                            }
                            if (filas == 3 && columnas == 1)
                            {
                                Matriz4x4[filas, columnas].Text = "X";
                                Matriz4x4[filas, columnas].Enter += TextBox4x431_Enter;
                                Matriz4x4[filas,columnas].Leave += TextBox4x431_Leave;
                            }
                            if (filas == 3 && columnas == 2)
                            {
                                Matriz4x4[filas, columnas].Text = "Y";
                                Matriz4x4[filas, columnas].Enter += TextBox4x432_Enter;
                                Matriz4x4[filas,columnas].Leave+=TextBox4x432_Leave;
                            }
                            if (filas == 3 && columnas == 3)
                            {
                                Matriz4x4[filas, columnas].Text = "Z";
                                Matriz4x4[filas, columnas].Enter += TextBox4x433_Enter;
                                Matriz4x4[filas, columnas].Leave += TextBox4x433_Leave;
                            }
                            if (filas==0 && columnas ==4)
                            {
                                Matriz4x4[filas, columnas].Text = "";
                                Matriz4x4[filas, columnas].Enter += TextBox4x404_Enter;
                            }
                            if (filas==1 && columnas ==4)
                            {
                                Matriz4x4[filas, columnas].Text = "";
                                Matriz4x4[filas, columnas].Enter += TextBox4x414_Enter;
                            }
                            if (filas ==2 && columnas ==4)
                            {
                                Matriz4x4[filas, columnas].Text = "";
                                Matriz4x4[filas, columnas].Enter += TextBox4x424_Enter;
                            }
                            if (filas==3 && columnas ==4)
                            {
                                Matriz4x4[filas, columnas].Text = "";
                                Matriz4x4[filas, columnas].Enter += TextBox4x434_Enter;
                            }
                            Matriz4x4[filas, columnas].Visible = true;
                            Controls.Add(Matriz4x4[filas, columnas]);
                        }
                    }
                    entrada4x4 = true;
                    break;
            }   
        }

 

        private void btn_Calcular_Click_1(object sender, EventArgs e)
        {
            if(Entrada==false)
            {
                MessageBox.Show("Primero agregue la matriz y los datos\n" +
                    "para calcular después");
                return;
            }        
            switch (cb_Orden_Matriz.Text)
            {
                case "2x2":
                    try
                    {
                        listBox1.Items.Clear();
                        //CONVIERTE LOS VALORES DE LA MATRIZ DE TEXTBOX  Y LOS PASA A UNA MATRIZ TIPO DOUBLE

                        for (int h = 0; h < Renglon_2x2.GetLength(0); h++)
                        {
                            for (int m = 0; m < Renglon_2x2.GetLength(1); m++)
                            {
                                if (Renglon_2x2[0, 0].Text == "0")
                                {
                                    MessageBox.Show("No se puede resolver", "Vaya . . .", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                dRenglon_2x2[h, m] = Convert.ToDouble(Renglon_2x2[h, m].Text);
                                fRenglon_2x2[h, m] = Convert.ToSingle(Renglon_2x2[h, m].Text);
                            }
                        }                  
                        EliminacionAdelante(dRenglon_2x2);
                        List<double> Resultado_2x2 = new List<double>();                    
                        for (int h = 0; h < Renglon_2x2.GetLength(0); h++)
                        {
                            for (int m = 0; m < Renglon_2x2.GetLength(1) - 1; m++)
                            {
                                Renglon_2x2[h, m].Text = Convert.ToString(dRenglon_2x2[h, m]);
                            }
                        }                     
                        // Instrucciones para realizar la sustitucion hacia atras
                        Resultado_2x2 = SustitucionAtras(dRenglon_2x2);
                        listBox1.Items.Add("X = " + Resultado_2x2[0].ToString());
                        listBox1.Items.Add("Y = " + Resultado_2x2[1].ToString());
                        //LLENAREMOS EL DATAGRIDVIEW CON LA MATRIZ ORIGINAL
                        DataGridViewRow row_2x2 = new DataGridViewRow();
                        row_2x2.CreateCells(dgv_MatrizOriginal);
                        dgv_MatrizOriginal.RowCount = Renglon_2x2.GetLength(0);
                        dgv_MatrizOriginal.ColumnCount = Renglon_2x2.GetLength(1);
                        for (int i = 0; i < Renglon_2x2.GetLength(0); i++)
                        {
                            for (int a = 0; a < Renglon_2x2.GetLength(1); a++)
                            {
                                dgv_MatrizOriginal.Rows[i].Cells[a].Value = fRenglon_2x2[i, a];
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Agregue una Matriz para realizar el calculo e ingrese\n" +
                            "solo valores numéricos","Vaya. . .",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    entrada2x2 = true;
                    break;
                case "3x3":
                    listBox1.Items.Clear();
                    //CONVIERTE LOS VALORES DE LA MATRIZ DE TEXTBOX  Y LOS PASA A UNA MATRIZ TIPO DOUBLE
                    for (int h = 0; h < Renglon_3x3.GetLength(0); h++)
                    {
                        for (int m = 0; m < Renglon_3x3.GetLength(1); m++)
                        {
                            dRenglon_3x3[h, m] = Convert.ToDouble(Renglon_3x3[h, m].Text);
                            fRenglon_3x3[h, m] = Convert.ToSingle(Renglon_3x3[h, m].Text);
                        }
                    }
                    //Se invoca al metodo para volver 0 las posiciones por debajo del pivote
                    EliminacionAdelante(dRenglon_3x3);
                    List<double> Resultado_3x3 = new List<double>(); 
                    // CICLO MOSTRAR LOS VALORES DE LA MATRIZ DESPUES DE LA ELIMINACION                                
                    for (int h = 0; h < Renglon_3x3.GetLength(0); h++)
                    {                    
                        for (int m = 0; m < Renglon_3x3.GetLength(1); m++)
                        {
                            Renglon_3x3[h, m].Text = Convert.ToString(dRenglon_3x3[h, m]);
                        }
                    }
                    // SE invoca al metodo para realizar la sustitucion hacia atras
                    Resultado_3x3=SustitucionAtras(dRenglon_3x3);
                    //textBox1.Text ="X=" + Resultado_3x3[0].ToString() +"\n  Y="+Resultado_3x3[1].ToString() + "\n  Z="+Resultado_3x3[2].ToString();
                    listBox1.Items.Add("X = " + Resultado_3x3[0].ToString());
                    listBox1.Items.Add("Y = " + Resultado_3x3[1].ToString());
                    listBox1.Items.Add("Z = " + Resultado_3x3[2].ToString());
                    //LLENAREMOS EL DATAGRIDVIEW CON LA MATRIZ ORIGINAL
                    DataGridViewRow row_3x3 = new DataGridViewRow();
                    row_3x3.CreateCells(dgv_MatrizOriginal);
                    dgv_MatrizOriginal.RowCount = Renglon_3x3.GetLength(0);
                    dgv_MatrizOriginal.ColumnCount = Renglon_3x3.GetLength(1);
                    for(int i=0;i<Renglon_3x3.GetLength(0);i++)
                    {
                        for(int a=0;a<Renglon_3x3.GetLength(1);a++)
                        {
                            dgv_MatrizOriginal.Rows[i].Cells[a].Value = fRenglon_3x3[i, a];
                        }
                    }
                    break;
                case "4x4":
                    listBox1.Items.Clear();
                    //CONVIERTE LOS VALORES DE LA MATRIZ DE TEXTBOX  Y LOS PASA A UNA MATRIZ TIPO DOUBLE
                    for (int h=0;h<Matriz4x4.GetLength(0);h++)
                    {
                        for(int m=0;m<Matriz4x4.GetLength(1);m++)
                        {
                            dMatriz4x4[h, m] = Convert.ToDouble(Matriz4x4[h,m].Text);
                            fMatriz4x4[h, m] = Convert.ToSingle(Matriz4x4[h,m].Text);
                        }
                    }
                    //Se invoca al metodo para volver 0 las posiciones por debajo del pivote
                    EliminacionAdelante(dMatriz4x4);
                    List<double> Resultado_4x4 = new List<double>();
                    // CICLO MOSTRAR LOS VALORES DE LA MATRIZ DESPUES DE LA ELIMINACION                                
                    for (int h = 0; h < Matriz4x4.GetLength(0); h++)
                    {

                        for (int m = 0; m < Matriz4x4.GetLength(1); m++)
                        {
                            Matriz4x4[h, m].Text = Convert.ToString(dMatriz4x4[h, m]);
                        }

                    }
                    // SE invoca al metodo para realizar la sustitucion hacia atras
                    Resultado_4x4 = SustitucionAtras(dMatriz4x4);
                    //textBox1.Text = "\nW=" + Resultado_4x4[0].ToString() + "\n\n  X=" + Resultado_4x4[1].ToString() + "\n\n  Y=" + Resultado_4x4[2].ToString() + "\n Z=" + Resultado_4x4[3].ToString();
                    listBox1.Items.Add("W = "+ Resultado_4x4[0].ToString());
                    listBox1.Items.Add("X = " + Resultado_4x4[1].ToString());
                    listBox1.Items.Add("Y = " + Resultado_4x4[2].ToString());
                    listBox1.Items.Add("Z = " + Resultado_4x4[3].ToString());
                    //LLENAREMOS EL DATAGRIDVIEW CON LA MATRIZ ORIGINAL
                    DataGridViewRow row_4x4 = new DataGridViewRow();
                    row_4x4.CreateCells(dgv_MatrizOriginal);
                    dgv_MatrizOriginal.RowCount = Matriz4x4.GetLength(0);
                    dgv_MatrizOriginal.ColumnCount = Matriz4x4.GetLength(1);
                    for (int i = 0; i < Matriz4x4.GetLength(0); i++)
                    {
                        for (int a = 0; a < Matriz4x4.GetLength(1); a++)
                        {
                            dgv_MatrizOriginal.Rows[i].Cells[a].Value = fMatriz4x4[i, a];
                        }
                    }
                    break;
            }
        }




        List<double> SustitucionAtras(double [,]Matriz)
        {
            StringBuilder sBuilder = new StringBuilder();
            List<double> Resultado = new List<double>();
            //  double x = dRenglon_3x3[Renglon_3x3.GetLength(0) - 1, Renglon_3x3.GetLength(1) - 1] / dRenglon_3x3[Renglon_3x3.GetLength(0) - 1, Renglon_3x3.GetLength(1) - 2];
            double x = Matriz[Matriz.GetLength(0) - 1, Matriz.GetLength(1) - 1] / Matriz[Matriz.GetLength(0) - 1, Matriz.GetLength(1) - 2];
            sBuilder.AppendFormat("\nX{0} = {1:G30} \n", Matriz.GetLength(0), x);
            Resultado.Add(x);
            for (int f = Matriz.GetLength(0) - 2; f >= 0; f--)
            {
                double suma = 0;
                int Max = 0;
                for (int c = Matriz.GetLength(1) - 2; c >= f + 1; c--)
                {
                    suma += Matriz[f, c] * Resultado[Max];
                    Max++;
                }
                double r = ((Matriz[f, Matriz.GetLength(1) - 1] - suma) / Matriz[f, f]);
                sBuilder.AppendFormat("X{0}= {1:G30} \n", f + 1, r);
                Resultado.Add(r);
            }
            return Resultado;
        }
        void EliminacionAdelante(double[,] Matriz)
        {
            int filas = Matriz.GetLength(0);
            int columnas = Matriz.GetLength(1);

            for (int fpivot = 0; fpivot < filas; fpivot++)
            {
                for (int f = fpivot + 1; f < columnas - 1; f++)
                {
                    double k = Matriz[f, fpivot] / Matriz[fpivot, fpivot];

                    for (int c = fpivot; c < columnas; c++)
                    {
                        Matriz[f, c] = Matriz[f, c] - (k * Matriz[fpivot, c]);

                    }
                }
            }
        }
        List<double> SustitucionAtras4x4(double[,] Matriz)
        {
            StringBuilder sBuilder = new StringBuilder();
            List<double> Resultado = new List<double>();

            //  double x = dRenglon_3x3[Renglon_3x3.GetLength(0) - 1, Renglon_3x3.GetLength(1) - 1] / dRenglon_3x3[Renglon_3x3.GetLength(0) - 1, Renglon_3x3.GetLength(1) - 2];
            double x = Matriz[Matriz.GetLength(0) - 1, Matriz.GetLength(1) - 1] / Matriz[Matriz.GetLength(0) - 1, Matriz.GetLength(1) - 2];

            sBuilder.AppendFormat("\nX{0} = {1:G30} \n", Matriz.GetLength(0), x);

            Resultado.Add(x);

            for (int f = Matriz.GetLength(0) - 2; f >= 0; f--)
            {
                double suma = 0;
                int Max = 0;

                for (int c = Matriz.GetLength(1) - 2; c >= f + 1; c--)
                {
                    suma += Matriz[f, c] * Resultado[Max];
                    Max++;
                }

                double r = ((Matriz[f, Matriz.GetLength(1) - 1] - suma) / Matriz[f, f]);
                sBuilder.AppendFormat("X{0}= {1:G30} \n", f + 1, r);
                Resultado.Add(r);


            }

            return Resultado;
        }
        private void EliminacionAdelante()
        {
            //matrix -> matriz que contiene nuestro sistema de ecuaciones
            //filas, columnas -> cantidad de filas y columnas respetivamente

            for (int fpivot = 0; fpivot < dRenglon_3x3.GetLength(0); fpivot++)
            {
                for (int f = fpivot + 1; f < dRenglon_3x3.GetLength(1) - 1; f++)
                {
                    double k = dRenglon_3x3[f, fpivot] / dRenglon_3x3[fpivot, fpivot];

                    for (int c = fpivot; c < dRenglon_3x3.GetLength(1); c++)
                    {
                        dRenglon_3x3[f, c] = dRenglon_3x3[f, c] - (k * dRenglon_3x3[fpivot, c]);
                    }
                }

            }

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            dgv_MatrizOriginal.Rows.Clear();
            listBox1.Items.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}
