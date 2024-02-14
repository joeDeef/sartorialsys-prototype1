using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_1___SartorialSys
{
    public partial class frmAdministraciónParámetros : Form
    {
        public frmAdministraciónParámetros()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmAdministracion administracion = new frmAdministracion();
            administracion.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmDetallesParametro parametro = new frmDetallesParametro();
            parametro.ShowDialog();
        }

        private void btnMostra2_Click(object sender, EventArgs e)
        {
            frmDetallesParametro parametro = new frmDetallesParametro();
            parametro.ShowDialog();
        }
    }
}
