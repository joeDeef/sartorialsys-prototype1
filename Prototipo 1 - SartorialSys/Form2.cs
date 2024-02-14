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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmInicio inicio = new frmInicio();
            inicio.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmClientes clientes = new frmClientes();
            clientes.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            this.Close();
            frmInventario inventario = new frmInventario();
            inventario.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            this.Visible=false;

            this.Close();
            frmInventario frm = new frmInventario();
            frm.ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmPedidos frm = new frmPedidos();
            frm.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmProveedores frm = new frmProveedores();
            frm.ShowDialog();

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmPedidos pedidos = new frmPedidos();
            pedidos.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmProveedores proveedores = new frmProveedores();
            proveedores.ShowDialog();
        }
    }
}
