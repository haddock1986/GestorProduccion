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
    public partial class ModificarProducto : Form
    {
        public ModificarProducto(Producto producto)
        {
            InitializeComponent();
            txtID.Text = producto.id.ToString();
            txtCliente.Text = producto.nombreCliente;
            txtCodigo.Text = producto.codigo;
            txtNombre.Text = producto.nombre;
            txtDescripcion.Text = producto.descripcion;
            nudRendimiento.Text = producto.rendimiento.ToString();
            txtPrecio.Text = producto.precio.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.id = Convert.ToInt32(txtID.Text);
            producto.nombreCliente = txtCliente.Text;
            producto.codigo = txtCodigo.Text;
            producto.nombre = txtNombre.Text;
            producto.descripcion = txtDescripcion.Text;
            producto.rendimiento = Convert.ToInt32(nudRendimiento.Text);
            producto.precio = Convert.ToDecimal(txtPrecio.Text);
            VPpal.updateProducto(producto);
            VPpal.actualizarListaProductos();
            Dispose();
        }
    }
}
