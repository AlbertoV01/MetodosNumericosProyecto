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
    public partial class Formulario_Mapa_Conceptual : Form
    {
        public Formulario_Mapa_Conceptual()
        {
            InitializeComponent();
        }

        private void btn_MapaConceptual_Click(object sender, EventArgs e)
        {
            btn_MapaConceptual.Visible=false;
            pnl_MapaConceptual.Visible = true;
            pnl_MapaConceptual.BackgroundImage = Properties.Resources.Mapa_Conceptual_bmp;
            pnl_MapaConceptual.BackgroundImageLayout = ImageLayout.Zoom;          
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            pnl_MapaConceptual.BackgroundImage = null;
            btn_MapaConceptual.Visible=true;
            pnl_MapaConceptual.Visible = false;

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
