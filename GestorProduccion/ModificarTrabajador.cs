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
    public partial class ModificarTrabajador: Form
    {
        public ModificarTrabajador(Trabajador trabajador)
        {
            InitializeComponent();
            txtID.Text = trabajador.id.ToString();
            txtNombre.Text = trabajador.nombre;
            txtApellido1.Text = trabajador.apellido1;
            txtApellido2.Text = trabajador.apellido2;
            txtDNI.Text = trabajador.dni;
            txtSS.Text = trabajador.ss;
            txtTelefono.Text = trabajador.telefono;
            txtEmail.Text = trabajador.email;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Trabajador trabajador = new Trabajador();
            trabajador.id = Convert.ToInt32(txtID.Text);
            trabajador.nombre = txtNombre.Text;
            trabajador.apellido1 = txtApellido1.Text;
            trabajador.apellido2 = txtApellido2.Text;
            trabajador.dni = txtDNI.Text;
            trabajador.ss = txtSS.Text;
            trabajador.telefono = txtTelefono.Text;
            trabajador.email = txtEmail.Text;

            VPpal.updateTrabajador(trabajador);
            VPpal.actualizarListaTrabajadores();
            Dispose();
        }
    }
}
