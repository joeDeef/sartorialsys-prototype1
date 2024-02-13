using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prototipo_1___SartorialSys
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }

        private void checkNombres_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNombres.Checked)
            {
                txtNombresActualizar.Enabled = true;
            }
            else
            {
                txtNombresActualizar.Enabled = false;
            }
        }

        private void checkDireccion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDireccion.Checked)
            {
                txtDireccionActualizar.Enabled = true;
            }
            else
            {
                txtDireccionActualizar.Enabled = false;
            }
        }

        private void checkTelefono_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTelefono.Checked)
            {
                txtTelefonoActualizar.Enabled = true;
            }
            else
            {
                txtTelefonoActualizar.Enabled = false;
            }
        }

        private void checkEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEmail.Checked)
            {
                txtEmailActualizar.Enabled = true;
            }
            else
            {
                txtEmailActualizar.Enabled = false;
            }
        }

        private void txtCedulaActualizar_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void txtTelefonoActualizar_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cliente Registrado con exito");
            limpiarConsola();
        }

        private void limpiarConsola()
        {
            txtCedulaRegistrar.Text = "";
            txtNombresRegistrar.Text = "";
            txtDireccionRegistrar.Text = "";
            txtTelefonoRegistrar.Text = "";
            txtEmailRegistrar.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarConsola();
        }

        private void tableClientes_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnCancelarActualizacion_Click(object sender, EventArgs e)
        {
            limpiarActualizacion();
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cliente Actualizado con exito");
            limpiarActualizacion();
        }

        private void limpiarActualizacion()
        {
            txtParametroParaActualizar.Text = ""; 
            txtCedulaActualizar.Text = "";
            txtNombresActualizar.Enabled = false;
            checkNombres.Checked = false;
            txtNombresActualizar.Text = "";
            txtDireccionActualizar.Enabled = false;
            checkDireccion.Checked = false;
            txtDireccionActualizar.Text = "";
            txtTelefonoActualizar.Enabled = false;
            checkTelefono.Checked = false;
            txtTelefonoActualizar.Text = "";
            txtEmailActualizar.Enabled = false;
            checkEmail.Checked = false;
            txtEmailActualizar.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter ingresado
            }
        }

        private void btnBuscarParaActualizar_Click(object sender, EventArgs e)
        {
            txtCedulaActualizar.Text = "1724915770";
            txtNombresActualizar.Text = "Alan Brito Delgado";
            txtDireccionActualizar.Text = "La loma";
            txtTelefonoActualizar.Text = "0994306989";
            txtEmailActualizar.Text = "alan.brito@epn.edu.ec";
        }

        private void txtParametroParaActualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
            limpiarConsulta();
        }

        private void limpiarConsulta()
        {
            txtParametroBusqueda.Text = "";
            txtCedulaConsultar.Text = "";
            txtNombresConsultar.Text = "";
            txtDireccionConsultar.Text = "";
            txtTelefonoConsultar.Text = "";
            txtEmailConsultar.Text = "";
        }

        private void txtParametroBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtCedulaConsultar.Text = "1724915770";
            txtNombresConsultar.Text = "Alan Brito Delgado";
            txtDireccionConsultar.Text = "La loma";
            txtTelefonoConsultar.Text = "0994306989";
            txtEmailConsultar.Text = "alan.brito@epn.edu.ec";
        }

        private void txtParametroEliminar_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCedulaEliminar.Text = "1724915770";
            txtNombresEliminar.Text = "Alan Brito Delgado";
            txtDireccionEliminar.Text = "La loma";
            txtTelefonoEliminar.Text = "0994306989";
            txtEmailEliminar.Text = "alan.brito@epn.edu.ec";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarEliminar();
        }

        private void limpiarEliminar()
        {
            txtParametroEliminar.Text = "";
            txtCedulaEliminar.Text = "";
            txtNombresEliminar.Text = "";
            txtDireccionEliminar.Text = "";
            txtTelefonoEliminar.Text = "";
            txtEmailEliminar.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cliente Eliminado con exito");
            limpiarEliminar();
        }
    }
}
