using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class D_CLIENTE
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public List<E_CLIENTE> ListarCliente(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand comando = new SqlCommand("SP_BUSCAR_CLIENTE", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@BUSCAR", buscar);
            LeerFilas = comando.ExecuteReader();
            List<E_CLIENTE> Listar = new List<E_CLIENTE>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_CLIENTE
                {
                    IdCliente = LeerFilas.GetInt32(0),
                    NombreCliente = LeerFilas.GetString(1),
                    DireccionCliente = LeerFilas.GetString(2),
                    TelefonoCliente =LeerFilas.GetString(3),
                    EmailCliente= LeerFilas.GetString(4)

                });
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarCliente(E_CLIENTE CLIENTE)
        {
            SqlCommand comando = new SqlCommand("SP_INSERTAR_CLIENTE", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@NOMBRE", CLIENTE.NombreCliente);
            comando.Parameters.AddWithValue("@DIRECCION", CLIENTE.DireccionCliente);
            comando.Parameters.AddWithValue("@TELEFONO", CLIENTE.TelefonoCliente);
            comando.Parameters.AddWithValue("@EMAIL", CLIENTE.EmailCliente);
            comando.ExecuteNonQuery();
            conexion.Close();

        }

        public void EditarCliente(E_CLIENTE CLIENTE)
        {
            SqlCommand comando = new SqlCommand("SP_EDITAR_CLIENTE", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@IDCLIENTE", CLIENTE.IdCliente);
            comando.Parameters.AddWithValue("@NOMBRE", CLIENTE.NombreCliente);
            comando.Parameters.AddWithValue("@DIRECCION", CLIENTE.DireccionCliente);
            comando.Parameters.AddWithValue("@TELEFONO", CLIENTE.TelefonoCliente);
            comando.Parameters.AddWithValue("@EMAIL", CLIENTE.EmailCliente);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarCliente(E_CLIENTE CLIENTE)
        {
            SqlCommand comando = new SqlCommand("SP_ELIMINAR_CLIENTE", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@IDCLIENTE", CLIENTE.IdCliente);
            comando.ExecuteNonQuery();
            conexion.Close();

        }


    }
}
