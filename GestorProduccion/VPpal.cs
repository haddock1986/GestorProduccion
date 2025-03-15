using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorProduccion
{
    public partial class VPpal : Form
    {
        public VPpal()
        {
            InitializeComponent();
            DgvClientes = dgvClientes;
            DgvProductos = dgvListaProductos;
            DgvTrabajadores = dgvListaTrabajadores;
        }

        public static DataGridView DgvClientes { get; private set; }
        public static DataGridView DgvProductos { get; private set; }
        public static DataGridView DgvTrabajadores { get; private set; }

        public static SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GestorDB.mdf;Integrated Security=True");

        public static void insertarCliente(Cliente cliente)
        {
            try
            {
                conn.Open();

                string query = @"INSERT INTO clientes (nombre, nif, direccion, codPostal, poblacion, telefono, email)
                            VALUES (@nombre, @nif, @direccion, @codPostal, @poblacion, @telefono, @email)";

                SqlParameter nombreParameter = new SqlParameter();
                nombreParameter.ParameterName = "@nombre";
                nombreParameter.Value = cliente.nombre;
                nombreParameter.DbType = DbType.String;

                SqlParameter nifParameter = new SqlParameter();
                nifParameter.ParameterName = "@nif";
                nifParameter.Value = cliente.nif;
                nifParameter.DbType = DbType.String;

                SqlParameter direccionParameter = new SqlParameter();
                direccionParameter.ParameterName = "@direccion";
                direccionParameter.Value = cliente.direccion;
                direccionParameter.DbType = DbType.String;

                SqlParameter codPostalParameter = new SqlParameter();
                codPostalParameter.ParameterName = "@codPostal";
                codPostalParameter.Value = cliente.codPostal;
                codPostalParameter.DbType = DbType.String;

                SqlParameter poblacionParameter = new SqlParameter();
                poblacionParameter.ParameterName = "@poblacion";
                poblacionParameter.Value = cliente.poblacion;
                poblacionParameter.DbType = DbType.String;

                SqlParameter telefonoParameter = new SqlParameter();
                telefonoParameter.ParameterName = "@telefono";
                telefonoParameter.Value = cliente.telefono;
                telefonoParameter.DbType = DbType.String;

                SqlParameter emailParameter = new SqlParameter();
                emailParameter.ParameterName = "@email";
                emailParameter.Value = cliente.email;
                emailParameter.DbType = DbType.String;

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.Add(nombreParameter);
                command.Parameters.Add(nifParameter);
                command.Parameters.Add(direccionParameter);
                command.Parameters.Add(codPostalParameter);
                command.Parameters.Add(poblacionParameter);
                command.Parameters.Add(telefonoParameter);
                command.Parameters.Add(emailParameter);

                command.ExecuteNonQuery();

                conn.Close();
            }
            catch (SqlException) { throw; }


        }

        public static List<string> ObtenerClientes()
        {
            List<string> listaClientes = new List<string>();
            try
            {
                conn.Open();
                string query = "SELECT nombre FROM clientes";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    string nombre = reader["nombre"].ToString();

                    listaClientes.Add(nombre);
                }

                conn.Close();
            }
            catch (Exception) { throw; }
            return listaClientes;
        }

        public static void updateCliente(Cliente cliente)
        {
            try
            {
                conn.Open();

                string query = @"UPDATE clientes 
                                SET nombre = @nombre, 
                                nif = @nif, 
                                direccion = @direccion, 
                                codPostal = @codPostal, 
                                poblacion = @poblacion, 
                                telefono = @telefono, 
                                email = @email
                                WHERE Id = @id";

                SqlParameter idParameter = new SqlParameter("@id", cliente.id);

                SqlParameter nombreParameter = new SqlParameter();
                nombreParameter.ParameterName = "@nombre";
                nombreParameter.Value = cliente.nombre;
                nombreParameter.DbType = DbType.String;

                SqlParameter nifParameter = new SqlParameter();
                nifParameter.ParameterName = "@nif";
                nifParameter.Value = cliente.nif;
                nifParameter.DbType = DbType.String;

                SqlParameter direccionParameter = new SqlParameter();
                direccionParameter.ParameterName = "@direccion";
                direccionParameter.Value = cliente.direccion;
                direccionParameter.DbType = DbType.String;

                SqlParameter codPostalParameter = new SqlParameter();
                codPostalParameter.ParameterName = "@codPostal";
                codPostalParameter.Value = cliente.codPostal;
                codPostalParameter.DbType = DbType.String;

                SqlParameter poblacionParameter = new SqlParameter();
                poblacionParameter.ParameterName = "@poblacion";
                poblacionParameter.Value = cliente.poblacion;
                poblacionParameter.DbType = DbType.String;

                SqlParameter telefonoParameter = new SqlParameter();
                telefonoParameter.ParameterName = "@telefono";
                telefonoParameter.Value = cliente.telefono;
                telefonoParameter.DbType = DbType.String;

                SqlParameter emailParameter = new SqlParameter();
                emailParameter.ParameterName = "@email";
                emailParameter.Value = cliente.email;
                emailParameter.DbType = DbType.String;

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.Add(idParameter);
                command.Parameters.Add(nombreParameter);
                command.Parameters.Add(nifParameter);
                command.Parameters.Add(direccionParameter);
                command.Parameters.Add(codPostalParameter);
                command.Parameters.Add(poblacionParameter);
                command.Parameters.Add(telefonoParameter);
                command.Parameters.Add(emailParameter);

                command.ExecuteNonQuery();

                conn.Close();
            }
            catch (SqlException) { throw; }

        }

        public static void eliminarCliente(int ID)
        {
            try
            {
                conn.Open();
                string query = @"DELETE FROM clientes WHERE Id = @id";
                SqlParameter nombreClienteParameter = new SqlParameter("@id", ID);
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(nombreClienteParameter);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException) { throw; }
        }

        public static void eliminarProductosDeCliente(string nombreCliente)
        {
            try
            {
                conn.Open();
                string query = @"DELETE FROM productos WHERE nombreCliente = @nombreCliente";
                SqlParameter nombreClienteParameter = new SqlParameter("@nombreCliente", nombreCliente);
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(nombreClienteParameter);
                command.ExecuteNonQuery();

                conn.Close();
            }
            catch (SqlException) { throw; }
        }

        public static void actualizarListaClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            try
            {
                conn.Open();

                string query = "SELECT * FROM clientes";

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.id = int.Parse(reader["Id"].ToString());
                    cliente.nombre = reader["nombre"].ToString();
                    cliente.nif = reader["nif"].ToString();
                    cliente.direccion = reader["direccion"].ToString();
                    cliente.codPostal = reader["codPostal"].ToString();
                    cliente.poblacion = reader["poblacion"].ToString();
                    cliente.telefono = reader["telefono"].ToString();
                    cliente.email = reader["email"].ToString();

                    listaClientes.Add(cliente);
                }

                conn.Close();
            }
            catch (Exception) { throw; }
            DgvClientes.DataSource = null;
            DgvClientes.DataSource = listaClientes;
        }

        public static void insertarProducto(Producto producto)
        {
            try
            {
                conn.Open();

                string query = @"INSERT INTO productos (nombreCliente, codigo, nombre, descripcion, rendimiento, precio)
                            VALUES (@nombreCliente, @codigo, @nombre, @descripcion, @rendimiento, @precio)";



                SqlParameter nombreClienteParameter = new SqlParameter("@nombreCliente", producto.nombreCliente);

                SqlParameter codigoParameter = new SqlParameter("@codigo", producto.codigo);

                SqlParameter nombreParameter = new SqlParameter("@nombre", producto.nombre);

                SqlParameter descripcionParameter = new SqlParameter("@descripcion", producto.descripcion);

                SqlParameter rendimientoParameter = new SqlParameter("@rendimiento", producto.rendimiento);

                SqlParameter precioParameter = new SqlParameter("@precio", producto.precio);


                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.Add(nombreClienteParameter);
                command.Parameters.Add(codigoParameter);
                command.Parameters.Add(nombreParameter);
                command.Parameters.Add(descripcionParameter);
                command.Parameters.Add(rendimientoParameter);
                command.Parameters.Add(precioParameter);

                command.ExecuteNonQuery();

                conn.Close();
            }
            catch (SqlException) { throw; }


        }

        public static void updateProducto(Producto producto)
        {
            try
            {
                conn.Open();
                string query = @"UPDATE productos 
                                SET nombreCliente = @nombreCliente, 
                                codigo = @codigo, 
                                nombre = @nombre, 
                                descripcion = @descripcion, 
                                rendimiento = @rendimiento, 
                                precio = @precio
                                WHERE Id = @id";

                SqlParameter idParameter = new SqlParameter("@id", producto.id);

                SqlParameter nombreClienteParameter = new SqlParameter("@nombreCliente", producto.nombreCliente);

                SqlParameter codigoParameter = new SqlParameter("@codigo", producto.codigo);

                SqlParameter nombreParameter = new SqlParameter("@nombre", producto.nombre);

                SqlParameter descripcionParameter = new SqlParameter("@descripcion", producto.descripcion);

                SqlParameter rendimientoParameter = new SqlParameter("@rendimiento", producto.rendimiento);

                SqlParameter precioParameter = new SqlParameter("@precio", producto.precio);


                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.Add(idParameter);
                command.Parameters.Add(nombreClienteParameter);
                command.Parameters.Add(codigoParameter);
                command.Parameters.Add(nombreParameter);
                command.Parameters.Add(descripcionParameter);
                command.Parameters.Add(rendimientoParameter);
                command.Parameters.Add(precioParameter);

                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException) { throw; }
        }
        public static void eliminarProducto(int ID)
        {
            try
            {
                conn.Open();
                string query = @"DELETE FROM productos WHERE Id = @id";
                SqlParameter nombreClienteParameter = new SqlParameter("@id", ID);
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(nombreClienteParameter);
                command.ExecuteNonQuery();
                conn.Close();
            }

            catch (SqlException) { throw; }
        }

        public static void actualizarListaProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            try
            {
                conn.Open();

                string query = "SELECT * FROM productos";

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Producto producto = new Producto();

                    producto.id = int.Parse(reader["Id"].ToString());
                    producto.nombreCliente = reader["nombreCliente"].ToString();
                    producto.codigo = reader["codigo"].ToString();
                    producto.nombre = reader["nombre"].ToString();
                    producto.descripcion = reader["descripcion"].ToString();
                    producto.rendimiento = int.Parse(reader["rendimiento"].ToString());
                    producto.precio = decimal.Parse(reader["precio"].ToString());


                    listaProductos.Add(producto);
                }
                conn.Close();
            }
            catch (Exception) { throw; }
            DgvProductos.DataSource = null;
            DgvProductos.DataSource = listaProductos;
        }

        public static void insertarTrabajador(Trabajador trabajador)
        {
            try
            {
                conn.Open();

                string query = @"INSERT INTO trabajadores (nombre, apellido1, apellido2, dni, segSocial, telefono, email)
                            VALUES (@nombre, @apellido1, @apellido2, @dni, @segSocial, @telefono, @email)";

                SqlParameter nombreParameter = new SqlParameter("@nombre", trabajador.nombre);

                SqlParameter apellido1Parameter = new SqlParameter("@apellido1", trabajador.apellido1);

                SqlParameter apellido2Parameter = new SqlParameter("@apellido2", trabajador.apellido2);

                SqlParameter dniParameter = new SqlParameter("@dni", trabajador.dni);

                SqlParameter ssParameter = new SqlParameter("@segSocial", trabajador.ss);

                SqlParameter telefonoParameter = new SqlParameter("@telefono", trabajador.telefono);

                SqlParameter emailParameter = new SqlParameter("@email", trabajador.email);


                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.Add(nombreParameter);
                command.Parameters.Add(apellido1Parameter);
                command.Parameters.Add(apellido2Parameter);
                command.Parameters.Add(dniParameter);
                command.Parameters.Add(ssParameter);
                command.Parameters.Add(telefonoParameter);
                command.Parameters.Add(emailParameter);

                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException) { throw; }
        }

        public static void updateTrabajador(Trabajador trabajador)
        {
            try
            {
                conn.Open();
                string query = @"UPDATE trabajadores 
                                SET nombre = @nombre, 
                                apellido1 = @apellido1, 
                                apellido2 = @apellido2, 
                                dni = @dni, 
                                segSocial = @segSocial, 
                                telefono = @telefono,
                                email = @email
                                WHERE Id = @id";

                SqlParameter idParameter = new SqlParameter("@id", trabajador.id);

                SqlParameter nombreTrabajadorParameter = new SqlParameter("@nombre", trabajador.nombre);

                SqlParameter apellido1Parameter = new SqlParameter("@apellido1", trabajador.apellido1);

                SqlParameter apellido2Parameter = new SqlParameter("@apellido2", trabajador.apellido2);

                SqlParameter dniParameter = new SqlParameter("@dni", trabajador.dni);

                SqlParameter segSocialParameter = new SqlParameter("@segSocial", trabajador.ss);

                SqlParameter telefonoParameter = new SqlParameter("@telefono", trabajador.telefono);

                SqlParameter emailParameter = new SqlParameter("@email", trabajador.email);


                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.Add(idParameter);
                command.Parameters.Add(nombreTrabajadorParameter);
                command.Parameters.Add(apellido1Parameter);
                command.Parameters.Add(apellido2Parameter);
                command.Parameters.Add(dniParameter);
                command.Parameters.Add(segSocialParameter);
                command.Parameters.Add(telefonoParameter);
                command.Parameters.Add(emailParameter);

                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException) { throw; }
        }

        public static void eliminarTrabajador(int ID)
        {
            try
            {
                conn.Open();
                string query = @"DELETE FROM trabajadores WHERE Id = @id";
                SqlParameter nombreClienteParameter = new SqlParameter("@id", ID);
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(nombreClienteParameter);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException) { throw; }
            
        }

        public static void actualizarListaTrabajadores()
        {
            List<Trabajador> listaTrabajadores = new List<Trabajador>();
            try
            {
                conn.Open();

                string query = "SELECT * FROM trabajadores";

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Trabajador trabajador = new Trabajador();

                    trabajador.id = int.Parse(reader["Id"].ToString());
                    trabajador.nombre = reader["nombre"].ToString();
                    trabajador.apellido1 = reader["apellido1"].ToString();
                    trabajador.apellido2 = reader["apellido2"].ToString();
                    trabajador.dni = reader["dni"].ToString();
                    trabajador.ss = reader["segSocial"].ToString();
                    trabajador.telefono = reader["telefono"].ToString();
                    trabajador.email = reader["email"].ToString();


                    listaTrabajadores.Add(trabajador);
                }
                conn.Close();
            }
            catch (Exception) { throw; }
            
            DgvTrabajadores.DataSource = null;
            DgvTrabajadores.DataSource = listaTrabajadores;
        }

        private void tsmiNuevoCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente nuevoCliente = new NuevoCliente();
            nuevoCliente.Visible = true;
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevoProducto_Click(object sender, EventArgs e)
        {
            NuevoProducto nuevoProducto = new NuevoProducto();
            nuevoProducto.Visible = true;
        }

        private void tsmiConectarDB_Click(object sender, EventArgs e)
        {
            actualizarListaClientes();
            actualizarListaProductos();
            actualizarListaTrabajadores();
            tsmiConectarDB.Enabled = false;
            tsbConectarDB.Enabled = false;
        }

        private void tsbNuevoTrabajador_Click(object sender, EventArgs e)
        {
            NuevoTrabajador nuevoTrabajador = new NuevoTrabajador();
            nuevoTrabajador.Visible = true;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)DgvClientes.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Modificar")
            {
                Cliente cliente = new Cliente();
                cliente.id = int.Parse(DgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
                cliente.nombre = DgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                cliente.nif = DgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                cliente.direccion = DgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
                cliente.codPostal = DgvClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
                cliente.poblacion = DgvClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
                cliente.telefono = DgvClientes.Rows[e.RowIndex].Cells[6].Value.ToString();
                cliente.email = DgvClientes.Rows[e.RowIndex].Cells[7].Value.ToString();
                ModificarCliente modificarCliente = new ModificarCliente(cliente);
                modificarCliente.Visible = true;
            }
            else if (cell.Value.ToString() == "Eliminar")
            {
                int id = int.Parse(DgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
                string nombre = DgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                eliminarCliente(id);
                eliminarProductosDeCliente(nombre);
                actualizarListaClientes();
                actualizarListaProductos();
            }
        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)DgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Modificar")
            {
                Producto producto = new Producto();
                producto.id = int.Parse(DgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString());
                producto.nombreCliente = DgvProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                producto.codigo = DgvProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                producto.nombre = DgvProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                producto.descripcion = DgvProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
                producto.rendimiento = int.Parse(DgvProductos.Rows[e.RowIndex].Cells[5].Value.ToString());
                producto.precio = decimal.Parse(DgvProductos.Rows[e.RowIndex].Cells[6].Value.ToString());
                ModificarProducto modificarProducto = new ModificarProducto(producto);
                modificarProducto.Visible = true;
            }
            else if (cell.Value.ToString() == "Eliminar")
            {
                int id = int.Parse(DgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString());
                eliminarProducto(id);
                actualizarListaProductos();
            }
        }

        private void dgvListaTrabajadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)DgvTrabajadores.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Modificar")
            {
                Trabajador trabajador = new Trabajador();
                trabajador.id = int.Parse(DgvTrabajadores.Rows[e.RowIndex].Cells[0].Value.ToString());
                trabajador.nombre = DgvTrabajadores.Rows[e.RowIndex].Cells[1].Value.ToString();
                trabajador.apellido1 = DgvTrabajadores.Rows[e.RowIndex].Cells[2].Value.ToString();
                trabajador.apellido2 = DgvTrabajadores.Rows[e.RowIndex].Cells[3].Value.ToString();
                trabajador.dni = DgvTrabajadores.Rows[e.RowIndex].Cells[4].Value.ToString();
                trabajador.ss = DgvTrabajadores.Rows[e.RowIndex].Cells[5].Value.ToString();
                trabajador.telefono = DgvTrabajadores.Rows[e.RowIndex].Cells[6].Value.ToString();
                trabajador.email = DgvTrabajadores.Rows[e.RowIndex].Cells[7].Value.ToString();
                ModificarTrabajador modificarTrabajador  = new ModificarTrabajador(trabajador);
                modificarTrabajador.Visible = true;
            }
            else if (cell.Value.ToString() == "Eliminar")
            {
                int id = int.Parse(DgvTrabajadores.Rows[e.RowIndex].Cells[0].Value.ToString());
                eliminarTrabajador(id);
                actualizarListaTrabajadores();
            }
        }

        private void tsbNuevoParte_Click(object sender, EventArgs e)
        {
            conn.Close();
            NuevoParteTrabajo nuevoParteTrabajo = new NuevoParteTrabajo();
            nuevoParteTrabajo.Visible = true;
        }
    }
}
