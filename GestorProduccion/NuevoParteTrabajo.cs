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
    public partial class NuevoParteTrabajo : Form
    {
        private void ListaTrabajadores()
        {
            try
            {
                VPpal.conn.Open();
                List<string> listaTrabajadores = new List<string>();
                SqlCommand cmd = new SqlCommand("SELECT * FROM trabajadores", VPpal.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listaTrabajadores.Add(dr["nombre"] + "," + dr["apellido1"] + "," + dr["apellido2"]);
                }
                cbTrabajador.DataSource = listaTrabajadores;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                VPpal.conn.Close();
            }
        }

        private void ListaClientes()
        {
            try
            {
                VPpal.conn.Open();
                List<string> listaClientes = new List<string>();
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM clientes", VPpal.conn);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    listaClientes.Add(dr2["nombre"].ToString());
                }
                cbCliente.DataSource = listaClientes;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                VPpal.conn.Close();
            }
        }

        private void DatosProductoSeleccionado()
        {
            try
            {
                VPpal.conn.Open();
                string productoSeleccionado = cbProducto.Text;
                SqlCommand cmd4 = new SqlCommand("SELECT * FROM Productos WHERE codigo = '" + productoSeleccionado + "'", VPpal.conn);
                SqlDataReader dr4 = cmd4.ExecuteReader();
                while (dr4.Read())
                {
                    txtProducto.Text = dr4["nombre"].ToString();
                    if (dr4["rendimiento"].ToString() != "0")
                    {
                        txtTiempoInvertido.Enabled = false;
                    }
                    else
                    {
                        txtTiempoInvertido.Enabled = true;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                VPpal.conn.Close();
            }
        }

        private void ListaProductos()
        {
            try
            {
                VPpal.conn.Open();
                List<string> listaProductos = new List<string>();
                string clienteSeleccionado = cbCliente.Text;
                SqlCommand cmd3 = new SqlCommand("SELECT * FROM Productos WHERE nombreCliente = '" + clienteSeleccionado + "'", VPpal.conn);
                SqlDataReader dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    listaProductos.Add(dr3["codigo"].ToString());
                }
                cbProducto.DataSource = listaProductos;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                VPpal.conn.Close();
            }
        }

        public NuevoParteTrabajo()
        {
            InitializeComponent();
            ListaTrabajadores();
            VPpal.conn.Close();
            ListaClientes();
            VPpal.conn.Close();
            ListaProductos();
            VPpal.conn.Close();
            DatosProductoSeleccionado();
            VPpal.conn.Close();
        }

        private void btnBloquearFechaAndTrabajador_Click(object sender, EventArgs e)
        {
            dtpFecha.Enabled = false;
            cbTrabajador.Enabled = false;
        }

        private void nudCantidadPiezas_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                VPpal.conn.Open();

                string productoSeleccionado = cbProducto.Text;
                SqlCommand cmd4 = new SqlCommand("SELECT * FROM Productos WHERE codigo = '" + productoSeleccionado + "'", VPpal.conn);
                SqlDataReader dr4 = cmd4.ExecuteReader();
                while (dr4.Read())
                {
                    if (dr4["rendimiento"].ToString() != "0")
                    {
                        txtTiempoInvertido.Enabled = false;
                        txtTiempoInvertido.Text = (Convert.ToDecimal(nudCantidadPiezas.Value) / Convert.ToInt32(dr4["rendimiento"])).ToString("000.000");
                    }
                    else
                    {
                        txtTiempoInvertido.Enabled = true;
                    }
                }
                VPpal.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void btnAñadirTarea_Click(object sender, EventArgs e)
        {
            try
            {
                VPpal.conn.Open();

                string query = @"INSERT INTO PartesTrabajo (nombreTrabajador, 
                                                            apellido1Trabajador, 
                                                            apellido2Trabajador, 
                                                            fecha, 
                                                            nombreCliente, 
                                                            codigoProducto, 
                                                            nombreProducto, 
                                                            piezas,
                                                            tiempoInvertido) 
                    VALUES (@nombreTrabajador, @apellido1Trabajador, @apellido2Trabajador,
                            @fecha, @nombreCliente, @codigoProducto, @nombreProducto,
                            @piezas, @tiempoInvertido)";

                SqlCommand cmd = new SqlCommand(query, VPpal.conn);
                cmd.Parameters.AddWithValue("@nombreTrabajador", cbTrabajador.Text.Split(',')[0]);
                cmd.Parameters.AddWithValue("@apellido1Trabajador", cbTrabajador.Text.Split(',')[1]);
                cmd.Parameters.AddWithValue("@apellido2Trabajador", cbTrabajador.Text.Split(',')[2]);
                cmd.Parameters.AddWithValue("@fecha", dtpFecha.Text);
                cmd.Parameters.AddWithValue("@nombreCliente", cbCliente.Text);
                cmd.Parameters.AddWithValue("@codigoProducto", cbProducto.Text);
                cmd.Parameters.AddWithValue("@nombreProducto", txtProducto.Text);
                cmd.Parameters.AddWithValue("@piezas", nudCantidadPiezas.Value.ToString());
                cmd.Parameters.AddWithValue("@tiempoInvertido", txtTiempoInvertido.Text);

                cmd.ExecuteNonQuery();

                VPpal.conn.Close();

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            actualizarParte(dtpFecha.Value.ToString(), cbTrabajador.Text.Split(',')[0], cbTrabajador.Text.Split(',')[1], cbTrabajador.Text.Split(',')[2]);

        }

        private void actualizarParte(string fecha, string nombreTrabajador, string apellido1Trabajador, string apellido2Trabajador)
        {
            List<ParteTrabajo> ListaParteTrabajo = new List<ParteTrabajo>();
            try
            {
                VPpal.conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, nombreCliente, codigoProducto, nombreProducto, piezas, tiempoInvertido FROM PartesTrabajo WHERE fecha = '" + fecha + "' AND nombreTrabajador = '" + nombreTrabajador + "' AND apellido1Trabajador = '" + apellido1Trabajador + "' AND apellido2Trabajador = '" + apellido2Trabajador + "'", VPpal.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ParteTrabajo parte = new ParteTrabajo();
                    parte.id = int.Parse(dr["Id"].ToString());
                    parte.nombreTrabajador = nombreTrabajador;
                    parte.apellido1Trabajador = apellido1Trabajador;
                    parte.apellido2Trabajador = apellido2Trabajador;
                    parte.fecha = fecha;
                    parte.nombreCliente = dr["nombreCliente"].ToString();
                    parte.codigoProducto = dr["codigoProducto"].ToString();
                    parte.nombreProducto = dr["nombreProducto"].ToString();
                    parte.piezas = dr["piezas"].ToString();
                    parte.tiempoInvertido = dr["tiempoInvertido"].ToString();

                    ListaParteTrabajo.ToList().Add(parte);
                }

                VPpal.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            

            dgvParteTrabajo.DataSource = null;
            dgvParteTrabajo.DataSource = ListaParteTrabajo;
        }

        private void dgvParte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dgvParteTrabajo.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Eliminar")
            {
                int id = int.Parse(dgvParteTrabajo.Rows[e.RowIndex].Cells[0].Value.ToString());
                eliminarParteTarea(id);
                actualizarParte(dtpFecha.Value.ToString(), cbTrabajador.Text.Split(',')[0], cbTrabajador.Text.Split(',')[1], cbTrabajador.Text.Split(',')[2]);

            }
        }

        private void eliminarParteTarea(int id)
        {
            try
            {
                VPpal.conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM PartesTrabajo WHERE Id = " + id, VPpal.conn);
                cmd.ExecuteNonQuery();
                VPpal.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCalcularAndRegistrarRendimiento_Click(object sender, EventArgs e)
        {
            try
            {
                VPpal.conn.Open();
                string fecha = dtpFecha.Text;
                string nombreTrabajador = cbTrabajador.Text.Split(',')[0];
                string apellido1Trabajador = cbTrabajador.Text.Split(',')[1];
                string apellido2Trabajador = cbTrabajador.Text.Split(',')[2];
                string query = @"SELECT * FROM PartesTrabajo WHERE fecha = '" +fecha+ "' AND nombreTrabajador = '" +nombreTrabajador+ "' AND apellido1Trabajador = '" +apellido1Trabajador+ "' AND apellido2Trabajador = '" + apellido2Trabajador + "'";
                SqlCommand cmd = new SqlCommand(query, VPpal.conn);

                SqlDataReader dr = cmd.ExecuteReader();

                decimal tiempoInvertidoTotal = 0;
                while (dr.Read())
                {
                    tiempoInvertidoTotal = tiempoInvertidoTotal + decimal.Parse(dr["tiempoInvertido"].ToString());
                }
                decimal rendimientoPrima = decimal.Parse(((tiempoInvertidoTotal / decimal.Parse("7,5") )  * 100).ToString("000.000")) ;
                VPpal.conn.Close();

                VPpal.conn.Open();    


                string queryInsertarPrima = "INSERT INTO PrimaDiaria (fecha, nombreTrabajador, apellido1Trabajador, apellido2Trabajador, Prima) VALUES (@fecha, @nombreTrabajador, @apellido1Trabajador, @apellido2Trabajador, @Prima)";
                SqlCommand cmdInsertarPrima = new SqlCommand(queryInsertarPrima, VPpal.conn);
                cmdInsertarPrima.Parameters.AddWithValue("@fecha", dtpFecha.Text);
                cmdInsertarPrima.Parameters.AddWithValue("@nombreTrabajador", cbTrabajador.Text.Split(',')[0]);
                cmdInsertarPrima.Parameters.AddWithValue("@apellido1Trabajador", cbTrabajador.Text.Split(',')[1]);
                cmdInsertarPrima.Parameters.AddWithValue("@apellido2Trabajador", cbTrabajador.Text.Split(',')[2]);
                cmdInsertarPrima.Parameters.AddWithValue("@Prima", rendimientoPrima);
                cmdInsertarPrima.ExecuteNonQuery();

                txtRendimiento.Text = rendimientoPrima.ToString();
                btnCalcularAndRegistrarRendimiento.Enabled = false;

                VPpal.conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                VPpal.conn.Open();

                List<string> listaProductos = new List<string>();
                string clienteSeleccionado = cbCliente.Text;
                SqlCommand cmd3 = new SqlCommand("SELECT * FROM Productos WHERE nombreCliente = '" + clienteSeleccionado + "'", VPpal.conn);
                SqlDataReader dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    listaProductos.Add(dr3["codigo"].ToString());
                }
                cbProducto.DataSource = null;
                cbProducto.DataSource = listaProductos;
                VPpal.conn.Close();



                VPpal.conn.Open();
                string productoSeleccionado = cbProducto.Text;
                SqlCommand cmd4 = new SqlCommand("SELECT * FROM Productos WHERE codigo = '" + productoSeleccionado + "'", VPpal.conn);
                SqlDataReader dr4 = cmd4.ExecuteReader();
                while (dr4.Read())
                {
                    txtProducto.Text = dr4["nombre"].ToString();
                    if (dr4["rendimiento"].ToString() != "0")
                    {
                        txtTiempoInvertido.Enabled = false;
                    }
                    else
                    {
                        txtTiempoInvertido.Enabled = true;
                    }
                }
                VPpal.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void cbProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                VPpal.conn.Open();

                string productoSeleccionado = cbProducto.Text;

                SqlCommand cmd4 = new SqlCommand("SELECT * FROM Productos WHERE codigo = '" + productoSeleccionado + "'", VPpal.conn);
                SqlDataReader dr4 = cmd4.ExecuteReader();
                while (dr4.Read())
                {
                    txtProducto.Text = dr4["nombre"].ToString();
                    if (dr4["rendimiento"].ToString() != "0")
                    {
                        txtTiempoInvertido.Enabled = false;
                    }
                    else
                    {
                        txtTiempoInvertido.Enabled = true;
                    }
                }
                VPpal.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
    }
}
