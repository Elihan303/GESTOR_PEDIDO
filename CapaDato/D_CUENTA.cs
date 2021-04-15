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
    public class D_CUENTA
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public void InsertarCuenta(E_CUENTA CUENTA)
        {
            SqlCommand comando = new SqlCommand("SP_INSERTAR_CUENTA", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@IDCLIENTE", CUENTA.IdCliente);
            comando.Parameters.AddWithValue("@BALANCE", CUENTA.BalanceCuenta);
            comando.Parameters.AddWithValue("@NUM_CUENTA", CUENTA.Num_Cuenta);
            comando.ExecuteNonQuery();
            conexion.Close();

        }

        public void AñadirMonto(E_CUENTA CUENTA)
        {
            SqlCommand comando = new SqlCommand("SP_AÑADIRMONTO_CUENTA", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@IDCUENTA", CUENTA.IdCuenta);
            comando.Parameters.AddWithValue("@BALANCE", CUENTA.BalanceCuenta);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        
        public void DisminuirCuenta(E_CUENTA CUENTA)
        {
            SqlCommand comando = new SqlCommand("SP_DISMINUIR_CUENTA", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@NUM_CUENTA", CUENTA.Num_Cuenta);
            comando.Parameters.AddWithValue("@BALANCE", CUENTA.BalanceCuenta);
            comando.ExecuteNonQuery();
            conexion.Close();

        }
        

        public List<E_CUENTA> ListarCuenta(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand comando = new SqlCommand("SP_BUSCAR_CUENTA", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@IDCLIENTE", buscar);
            LeerFilas = comando.ExecuteReader();
            List<E_CUENTA> Listar = new List<E_CUENTA>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_CUENTA
                {
                    IdCuenta = LeerFilas.GetInt32(0),
                    IdCliente = LeerFilas.GetInt32(1),
                    BalanceCuenta = LeerFilas.GetInt32(2),
                    Num_Cuenta = LeerFilas.GetInt32(3),
                });



            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void EliminarCuenta(E_CUENTA CUENTA)
        {
            SqlCommand comando = new SqlCommand("SP_ELIMINAR_CUENTA", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@IDCUENTA", CUENTA.IdCuenta);
            comando.ExecuteNonQuery();
            conexion.Close();

        }

    }
}
