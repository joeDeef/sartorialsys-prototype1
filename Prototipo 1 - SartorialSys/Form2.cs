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
            frmEmpleados empleados = new frmEmpleados();
            empleados.ShowDialog();
        }

        private void btnVentasYFacturación_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmVentas ventas = new frmVentas(); 
            ventas.ShowDialog();
        }

        private void btnAdministración_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmAdministracion administracion = new frmAdministracion();
            administracion.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
