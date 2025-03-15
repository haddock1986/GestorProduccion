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
    public partial class NuevoTrabajador: Form
    {
        public NuevoTrabajador()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Trabajador trabajador = new Trabajador();
            trabajador.nombre = txtNombre.Text;
            trabajador.apellido1 = txtApellido1.Text;
            trabajador.apellido2 = txtApellido2.Text;
            trabajador.dni = txtDNI.Text;
            trabajador.ss = txtSS.Text;
            trabajador.telefono = txtTelefono.Text;
            trabajador.email = txtEmail.Text;

            VPpal.insertarTrabajador(trabajador);
            VPpal.actualizarListaTrabajadores();
            Dispose();
        }
    }
}
