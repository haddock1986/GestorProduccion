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
    public partial class NuevoCliente: Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            Cliente cliente = new Cliente();

            cliente.nombre = txtNombre.Text;
            cliente.nif = txtNIF.Text;
            cliente.direccion = txtDireccion.Text;
            cliente.codPostal = txtCodPostal.Text;
            cliente.poblacion = txtPoblacion.Text;
            cliente.telefono = txtTelefono.Text;
            cliente.email = txtEmail.Text;

            VPpal.insertarCliente(cliente);
            VPpal.actualizarListaClientes();
            Dispose();
        }
    }
}
