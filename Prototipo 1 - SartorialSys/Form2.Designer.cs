namespace Prototipo_1___SartorialSys
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.btnVentasYFacturación = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRAJES HIDALGO PLUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bienvenido: Usuario X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesión.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrarSesión.Image = global::Prototipo_1___SartorialSys.Properties.Resources.Icono_logout;
            this.btnCerrarSesión.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesión.Location = new System.Drawing.Point(520, 12);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(204, 49);
            this.btnCerrarSesión.TabIndex = 11;
            this.btnCerrarSesión.Text = "Cerrar Sesión\r\n";
            this.btnCerrarSesión.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesión.UseVisualStyleBackColor = true;
            this.btnCerrarSesión.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministracion.Image = global::Prototipo_1___SartorialSys.Properties.Resources.icono_administracion;
            this.btnAdministracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministracion.Location = new System.Drawing.Point(432, 326);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Size = new System.Drawing.Size(242, 83);
            this.btnAdministracion.TabIndex = 9;
            this.btnAdministracion.Text = "Administración";
            this.btnAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdministracion.UseVisualStyleBackColor = true;
            // 
            // btnVentasYFacturación
            // 
            this.btnVentasYFacturación.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasYFacturación.Image = global::Prototipo_1___SartorialSys.Properties.Resources.icono_ventas;
            this.btnVentasYFacturación.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasYFacturación.Location = new System.Drawing.Point(195, 426);
            this.btnVentasYFacturación.Name = "btnVentasYFacturación";
            this.btnVentasYFacturación.Size = new System.Drawing.Size(332, 93);
            this.btnVentasYFacturación.TabIndex = 8;
            this.btnVentasYFacturación.Text = "Ventas y Facturación";
            this.btnVentasYFacturación.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentasYFacturación.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Image = global::Prototipo_1___SartorialSys.Properties.Resources.icono_inventario;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(76, 126);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(243, 86);
            this.btnInventario.TabIndex = 7;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnPedidos
            // 
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.Image = global::Prototipo_1___SartorialSys.Properties.Resources.icono_pedido;
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.Location = new System.Drawing.Point(432, 220);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(186, 100);
            this.btnPedidos.TabIndex = 6;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPedidos.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Image = global::Prototipo_1___SartorialSys.Properties.Resources.icono_proveedor;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(76, 330);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(243, 79);
            this.btnProveedores.TabIndex = 5;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Image = global::Prototipo_1___SartorialSys.Properties.Resources.icono_empleados;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(76, 227);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(243, 86);
            this.btnEmpleados.TabIndex = 4;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Image = global::Prototipo_1___SartorialSys.Properties.Resources.icono_cliente;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(428, 128);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(190, 79);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Copyrigth © 2024";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 543);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCerrarSesión);
            this.Controls.Add(this.btnAdministracion);
            this.Controls.Add(this.btnVentasYFacturación);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnVentasYFacturación;
        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.Label label4;
    }
}