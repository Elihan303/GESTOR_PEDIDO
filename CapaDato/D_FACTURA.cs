using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace CapaDatos
{
    public class D_FACTURA
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_FACTURA> ListarFactura(int buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand comando = new SqlCommand("SP_BUSCAR_FACTURA", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@BUSCAR", buscar);
            LeerFilas = comando.ExecuteReader();
            List<E_FACTURA> Listar = new List<E_FACTURA>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_FACTURA
                {
                    IdFactura = LeerFilas.GetInt32(0),
                    TipoFactura = LeerFilas.GetString(1),
                    IdCliente = LeerFilas.GetInt32(2),
                    Monto = LeerFilas.GetInt32(3),
                });



            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarFactura(E_FACTURA FACTURA)
        {
            SqlCommand comando = new SqlCommand("SP_INSERTAR_FACTURA", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@TIPOFACTURA", FACTURA.TipoFactura);
            comando.Parameters.AddWithValue("@IDCLIENTE", FACTURA.IdCliente);
            comando.Parameters.AddWithValue("@MONTO", FACTURA.Monto);
            comando.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarFactura(E_FACTURA FACTURA)
        {
            SqlCommand comando = new SqlCommand("SP_ELIMINAR_FACTURA", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@IDFACTURA", FACTURA.IdFactura);
            comando.ExecuteNonQuery();
            conexion.Close();

        }

        public void SeleccionarFactura(E_FACTURA FACTURA) 
        {
            SqlCommand comando = new SqlCommand("SP_SELECCIONAR_FACTURA", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.ExecuteNonQuery();
            FACTURA.LastId= Convert.ToInt32(comando.ExecuteScalar());
            conexion.Close();
        }
    }
}
