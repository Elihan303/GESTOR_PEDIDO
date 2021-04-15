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
    public class D_PRODUCTO
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public List<E_PRODUCTO> ListarProducto(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand comando = new SqlCommand("SP_BUSCAR_PRODUCTO", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@BUSCAR", buscar);
            LeerFilas = comando.ExecuteReader();
            List<E_PRODUCTO> Listar = new List<E_PRODUCTO>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_PRODUCTO
                {
                    IdProducto = LeerFilas.GetInt32(0),
                    NombreProducto = LeerFilas.GetString(1),
                    PrecioProducto = LeerFilas.GetInt32(2),
                    StockProducto = LeerFilas.GetInt32(3)

                });
            


            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarProducto(E_PRODUCTO PRODUCTO)
        {
            SqlCommand comando = new SqlCommand("SP_INSERTAR_PRODUCTO", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@NOMBRE", PRODUCTO.NombreProducto);
            comando.Parameters.AddWithValue("@PRECIO", PRODUCTO.PrecioProducto);
            comando.Parameters.AddWithValue("@STOCK", PRODUCTO.StockProducto);
            comando.ExecuteNonQuery();
            conexion.Close();

        }
        public void EditarProducto(E_PRODUCTO PRODUCTO)
        {
            SqlCommand comando = new SqlCommand("SP_EDITAR_PRODUCTO", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@IDPRODUCTO", PRODUCTO.IdProducto);
            comando.Parameters.AddWithValue("@NOMBRE", PRODUCTO.NombreProducto);
            comando.Parameters.AddWithValue("@PRECIO", PRODUCTO.PrecioProducto);
            comando.Parameters.AddWithValue("@STOCK", PRODUCTO.StockProducto);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarProducto(E_PRODUCTO PRODUCTO)
        {
            SqlCommand comando = new SqlCommand("SP_ELIMINAR_PRODUCTO", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@IDPRODUCTO", PRODUCTO.IdProducto);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void ReducirStockProducto(E_PRODUCTO PRODUCTO)
        {
            SqlCommand comando = new SqlCommand("SP_DISMINUIR_PRODUCTO_STOCK", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@IDPRODUCTO", PRODUCTO.IdProducto);
            comando.Parameters.AddWithValue("@STOCK", PRODUCTO.StockProducto);
            comando.ExecuteNonQuery();
            conexion.Close();



        }





    }
}