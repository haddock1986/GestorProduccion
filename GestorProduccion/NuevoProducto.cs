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
    public partial class NuevoProducto: Form
    {
        public NuevoProducto()
        {
            InitializeComponent();
        }

        private void NuevoProducto_Load(object sender, EventArgs e)
        {
            cbCliente.DataSource = VPpal.ObtenerClientes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.nombreCliente = cbCliente.Text;
            producto.codigo = txtCodigo.Text;
            producto.nombre = txtNombre.Text;
            producto.descripcion = txtDescripcion.Text;
            producto.rendimiento = Convert.ToInt32(nudRendimiento.Text);
            producto.precio = Convert.ToDecimal(txtPrecio.Text);
            VPpal.insertarProducto(producto);
            VPpal.actualizarListaProductos();
            Dispose();
        }
    }
}
