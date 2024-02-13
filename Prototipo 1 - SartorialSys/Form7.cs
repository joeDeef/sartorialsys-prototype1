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
    public partial class frmAdministrarUsuarios : Form
    {
        public frmAdministrarUsuarios()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Usuario Registrado con exito");
            limpiarConsola();
        }

        private void limpiarConsola()
        {
            txtCódigoTrabajadorRegistrar.Text = "";
            txtUsuarioRegistrar.Text = "";
            txtContraseñaRegistrar.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarConsola();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmAdministracion administración = new frmAdministracion();
            administración.ShowDialog();
        }

        private void checkEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (checkContraseña.Checked)
            {
                txtContraseñaActualizar.Enabled = true;
            }
            else
            {
                txtContraseñaActualizar.Enabled = false;
            }
        }

        private void txtEmailActualizar_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Usuario Actaulizado con exito");
            limpiarActualizar();
        }

        private void limpiarActualizar()
        {
            txtParámetroParaActualizar.Text = "";
            txtCédulaActualizar.Text = "";
            txtUsuarioActualizar.Text = "";
            txtContraseñaActualizar.Text = "";
        }

        private void btnCancelarActualizacion_Click(object sender, EventArgs e)
        {
            limpiarActualizar();
        }

        private void btnBuscarParaActualizar_Click(object sender, EventArgs e)
        {
            txtCédulaActualizar.Text = "1724915770";
            txtUsuarioActualizar.Text = "PabloH12*";
            txtContraseñaActualizar.Text = "admin1234";
            comboBoxRolActualizar.SelectedIndex = 0;
        }

        private void comboBoxRolActualizar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBoxRol_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRol.Checked)
            {
                comboBoxRolActualizar.Enabled = true;
            }
            else
            {
                comboBoxRolActualizar.Enabled = false;
            }
        }

        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
            limpiarConsulta();
        }

        private void limpiarConsulta()
        {
            txtCódigoTrabajadorConsultar.Text = "";
            txtUsuarioConsultar.Text = "";
            txtContraseñaConsultar.Text = "";
            txtRolConsultar.Text = "";
            txtParámetroBusqueda.Text = "";
        }

        private void btnBuscarConsultar_Click(object sender, EventArgs e)
        {
            txtCódigoTrabajadorConsultar.Text = "1724915770";
            txtUsuarioConsultar.Text = "PabloH24@";
            txtContraseñaConsultar.Text = "admin1234";
            txtRolConsultar.Text = "Gerente";
        }

        private void btnBuscarEliminar_Click(object sender, EventArgs e)
        {
            txtCódigoEliminar.Text = "1724915770";
            txtUsuarioEliminar.Text = "PabloH24@";
            txtContraseñaEliminar.Text = "admin1234";
            txtRolEliminar.Text = "Gerente";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarEliminar();
        }

        private void limpiarEliminar()
        {
            txtParámetroEliminar.Text = "";
            txtCódigoEliminar.Text = "";
            txtUsuarioEliminar.Text = "";
            txtContraseñaEliminar.Text = "";
            txtRolEliminar.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Usuario eliminado con exito");
            limpiarEliminar();
        }
    }
}
