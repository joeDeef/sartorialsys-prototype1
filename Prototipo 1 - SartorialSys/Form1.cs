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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Visible = false;               //No se visualiza la ventana
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            //btnSalir.BackColor = Color.Bisque;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
           // btnSalir.BackColor = SystemColors.Control;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
