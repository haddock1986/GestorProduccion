using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorProduccion
{
    public partial class ModificarCliente: Form
    {
        public ModificarCliente(Cliente cliente)
        {
            InitializeComponent();
            txtID.Text = cliente.id.ToString();
            txtNombre.Text = cliente.nombre;
            txtNIF.Text = cliente.nif;
            txtDireccion.Text = cliente.direccion;
            txtCodPostal.Text = cliente.codPostal;
            txtPoblacion.Text = cliente.poblacion;
            txtTelefono.Text = cliente.telefono;
            txtEmail.Text = cliente.email;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            Cliente cliente = new Cliente();

            cliente.id = int.Parse(txtID.Text);
            cliente.nombre = txtNombre.Text;
            cliente.nif = txtNIF.Text;
            cliente.direccion = txtDireccion.Text;
            cliente.codPostal = txtCodPostal.Text;
            cliente.poblacion = txtPoblacion.Text;
            cliente.telefono = txtTelefono.Text;
            cliente.email = txtEmail.Text;

            VPpal.updateCliente(cliente);
            VPpal.actualizarListaClientes();
            Dispose();
        }
    }
}
